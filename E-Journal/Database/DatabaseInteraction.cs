using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace ElectronicDiary.Database
{
    /// <summary>
    /// Класс, содержащий методы для работы с базой данных.
    /// </summary>
    public static class DatabaseInteraction
    {
        /// <summary>
        /// Метод, который проверяет введенный логин, пароль и разрешает/запрещает вход.
        /// </summary>
        /// <param name="login"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        /// <returns> true, если вход разрешен, false, если вход запрещен. </returns>
        public static bool CheckLoginData(string login, string password)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var enteredLogin = DataEncryption.HashingData(login);
                var diaryUser = database.Users.Where(user => user.UserLogin == enteredLogin).FirstOrDefault();

                if (diaryUser != null)
                {
                    var enteredPassword = DataEncryption.HashingData(password);

                    if (diaryUser.UserPassword == enteredPassword)
                    {
                        Program.SetLoginInformation(true, Convert.ToBoolean(diaryUser.IsAdmin), diaryUser.UserId);
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Метод, который загружает информацию об аккаунте студента из базы данных.
        /// </summary>
        /// <param name="userId"> Идентификатор пользователя. </param>
        /// <returns> Массив с данными студента. </returns>
        public static string[]? LoadStudentData(int userId)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var diaryStudent = database.Students.Include(student => student.StudentGroupNumberNavigation)
                                      .Include(university => university.UniversityIdNavigation)
                                      .Where(student => student.NumberInUserTable == userId).FirstOrDefault();

                if (diaryStudent != null)
                {
                    return [diaryStudent.StudentId.ToString(), diaryStudent.StudentName, diaryStudent.StudentSurname,
                            diaryStudent.StudentPatronymic, diaryStudent.StudentGroupNumberNavigation.GroupName,
                            diaryStudent.StudentBirthday, diaryStudent.UniversityIdNavigation.UniversityName];
                }

                return null;
            }
        }

        /// <summary>
        /// Метод, который загружает расписание учебной группы из базы данных.
        /// </summary>
        /// <param name="groupId"> Идентификатор группы. </param>
        /// <param name="weekTypeId"> Идентификатор типа недели. </param>
        /// <param name="dayOfWeek"> Номер дня недели. </param>
        /// <param name="lessonNumber"> Номер пары. </param>
        /// <returns> Название предмета. </returns>
        public static string? LoadScheduleData(int groupId, int weekTypeId, int dayOfWeek, int lessonNumber)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var dailySchedule = database.GroupsSchedule.Include(p => p.Subject).Where(schedule => schedule.GroupId == groupId)
                    .Where(schedule => schedule.DayOfWeek == dayOfWeek).Where(schedule => schedule.WeekTypeId == weekTypeId).ToList();

                if (dailySchedule.Any())
                {
                    var lessonAtSpecificNumber = dailySchedule.Where(lesson => lesson.LessonNumber == lessonNumber).FirstOrDefault();

                    if (lessonAtSpecificNumber != null) 
                    {
                        return lessonAtSpecificNumber.Subject.SubjectName;
                    }

                    return String.Empty;
                }

                return null;
            }
        }
     
        /// <summary>
        /// Метод, который загружает типы недель из базы данных.
        /// </summary>
        /// <returns> Массив с названиями типов недель. </returns>
        public static string[] LoadWeeksTypes()
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.WeekTypes.Select(weekType => weekType.WeekTypeName).ToArray();
            }
        }

        /// <summary>
        /// Метод, который загружает типы оценок из базы данных.
        /// </summary>
        /// <returns> Массив с названиями типов оценок. </returns>
        public static string[] LoadMarksTypes()
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.MarksTypes.Select(markType => markType.MarkTypeName).ToArray();
            }
        }

        /// <summary>
        /// Метод, который загружает учебные группы из базы данных.
        /// </summary>
        /// <returns> Массив с названиями групп. </returns>
        public static string[] LoadStudyGroups()
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.Groups.Select(studyGroup => studyGroup.GroupName).ToArray();
            }
        }

        /// <summary>
        /// Метод, который загружает семестры из базы данных.
        /// </summary>
        /// <returns> Массив с названиями семестров. </returns>
        public static string[] LoadSemesters()
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.Semesters.Select(semester => semester.SemesterName).ToArray();
            }
        }

        /// <summary>
        /// Метод, который загружает учебные предметы из базы данных.
        /// </summary>
        /// <returns> Массив с названиями учебных предметов. </returns>
        public static string[] LoadSubjects()
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.Subjects.Select(subject => subject.SubjectName).ToArray();
            }
        }

        /// <summary>
        /// Метод, который загружает продолжительность пары из базы данных.
        /// </summary>
        /// <returns> Продолжительность пары. </returns>
        public static string LoadLessonsTime(int numberOfLesson)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.LessonsTimes.Where(lesson => lesson.LessonId == numberOfLesson)
                         .Select(lesson => lesson.LessonTime).FirstOrDefault() ?? String.Empty;
            }
        }

        /// <summary>
        /// Метод, который загружает заметки студента из базы данных.
        /// </summary>
        /// <param name="studentId"> Идентификатор студента. </param>
        /// <param name="subjectId"> Идентификатор предмета. </param>
        /// <returns> Заметка студента к предмету. </returns>
        public static string LoadStudentNote(int studentId, int subjectId)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var studentNote = database.StudentsNotes.Where(note => note.StudentId == studentId)
                                  .Where(note => note.SubjectId == subjectId).FirstOrDefault();

                if (studentNote != null) 
                {
                    return studentNote.NoteText;
                }

                return String.Empty;
            }
        }

        /// <summary>
        /// Метод, который загружает оценки студента в семестре из базы данных.
        /// </summary>
        /// <param name="semesterId"> Идентификатор семестра. </param>
        /// <param name="studentId"> Идентификатор студента. </param>
        /// <returns> Массив с оценками студента в семестре. </returns>
        public static StudentMark[] LoadStudentMarks(int semesterId, int studentId)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                return database.StudentsMarks.Include(mark => mark.Subject).Include(mark => mark.MarkType)
                    .Where(mark => mark.SemesterId == semesterId).Where(mark => mark.StudentId == studentId).ToArray();
            }
        }

        /// <summary>
        /// Метод, который загружает количество пар в день из базы данных.
        /// </summary>
        /// <param name="groupId"> Идентификатор группы </param>
        /// <param name="weekTypeId"> Идентификатор типа недели. </param>
        /// <param name="dayOfWeek"> День недели. </param>
        /// <returns> Количество пар в день. </returns>
        public static int LoadNumberOfSubjects(int groupId, int weekTypeId, int dayOfWeek)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var dailySchedule = database.GroupsSchedule.Where(schedule => schedule.GroupId == groupId)
                                .Where(schedule => schedule.DayOfWeek == dayOfWeek)
                                .Where(schedule => schedule.WeekTypeId == weekTypeId).ToArray();

                return dailySchedule.Any() ? dailySchedule.Max(schedule => schedule.LessonNumber) : 0;
            }
        }

        /// <summary>
        /// Метод, который загружает студентов из учебных групп.
        /// </summary>
        /// <param name="groupId"> Идентификатор группы. </param>
        /// <param name="searchInThisGroup"> true - ищет в текущей группе, false - ищет во всех группах, кроме текущей. </param>
        /// <returns> Массив с студентами. </returns>
        public static Student[] LoadStudentsFromGroups(int groupId, bool searchInThisGroup)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                if (searchInThisGroup)
                {
                    return database.Students.Where(student => student.StudentGroupNumber == groupId).ToArray();
                }

                return database.Students.Where(student => student.StudentGroupNumber != groupId).ToArray();
            }
        }

        /// <summary>
        /// Метод, который добавляет новую учебную группу.
        /// </summary>
        /// <param name="groupName"> Название группы. </param>
        /// <returns> true, если группа создана. false, если группа не создана. </returns>
        public static bool AddNewStudyGroup(string groupName)
        {
            using (var database = new ElectronicDiaryDatabaseContext()) 
            {
                var studyGroup = database.Groups.Where(group => group.GroupName == groupName).FirstOrDefault(); 

                if (studyGroup == null) 
                {
                    var newStudyGroup = new Group(groupName);
                    database.Groups.Add(newStudyGroup);
                    database.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Метод, который добавляет студента в учебную группу.
        /// </summary>
        /// <param name="studentId"> Идентификатор студента. </param>
        /// <param name="groupId"> Идентификатор группы. </param>
        public static void AddStudentToGroup(int studentId, int groupId)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var studyGroup = database.Groups.Where(group => group.GroupId == groupId).FirstOrDefault();
                var diaryStudent = database.Students.Where(student => student.StudentId == studentId).FirstOrDefault();

                if ((diaryStudent != null) && (studyGroup != null))
                {
                    studyGroup.StudentsTable.Add(diaryStudent);
                    diaryStudent.StudentGroupNumber = groupId;

                    database.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Метод, который добавляет оценку студенту.
        /// </summary>
        /// <param name="studentId"> Идентификатор студента. </param>
        /// <param name="subjectId"> Идентификатор предмета. </param>
        /// <param name="markTypeId"> Идентификатор типа оценки. </param>
        /// <param name="semesterId"> Идентификатор семестра. </param>
        /// <param name="subjectMark"> Оценка по предмету. </param>
        public static void AddStudentMark(int studentId, int subjectId, int markTypeId, int semesterId, int subjectMark)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var studentMark = database.StudentsMarks.Where(mark => mark.StudentId == studentId)
                    .Where(mark => mark.SubjectId == subjectId).Where(mark => mark.MarkTypeId == markTypeId)
                    .Where(mark => mark.SemesterId == semesterId).FirstOrDefault();

                if (studentMark != null)
                {
                    studentMark.Mark = subjectMark;
                }
                else
                {
                    var newStudentMark = new StudentMark(semesterId, markTypeId, subjectId, studentId, subjectMark);
                    var markSemester = database.Semesters.Where(semester => semester.SemesterId == semesterId).FirstOrDefault();
                    var markType = database.MarksTypes.Where(type => type.MarkTypeId == markTypeId).FirstOrDefault();
                    var markSubject = database.Subjects.Where(subject => subject.SubjectId == subjectId).FirstOrDefault();
                    var diaryStudent = database.Students.Where(student => student.StudentId == studentId).FirstOrDefault();

                    if ((markSemester != null) && (markType != null) && (diaryStudent != null) && (markSubject != null))
                    {
                        newStudentMark.Semester = markSemester;
                        newStudentMark.MarkType = markType;
                        newStudentMark.Subject = markSubject;
                        newStudentMark.Student = diaryStudent;
                        database.StudentsMarks.Add(newStudentMark);
                    }
                }

                database.SaveChanges();
            }
        }

        /// <summary>
        /// Метод, который сохраняет заметку студента в базу данных.
        /// </summary>
        /// <param name="studentId"> Идентификатор студента. </param>
        /// <param name="subjectId"> Идентификатор учебного предмета. </param>
        /// <param name="noteContent"> Содержание заметки. </param>
        public static void SaveStudentNote(int studentId, int subjectId, string noteContent)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var studentNote = database.StudentsNotes.Where(note => note.StudentId == studentId).Where(note => note.SubjectId == subjectId).FirstOrDefault();

                if (studentNote != null) 
                {
                    studentNote.NoteText = noteContent;
                }
                else
                {
                    var newStudentNote = new StudentNote(studentId, subjectId, noteContent);
                    var noteSubject = database.Subjects.Where(subject => subject.SubjectId == subjectId).FirstOrDefault();
                    var diaryStudent = database.Students.Where(student => student.StudentId == studentId).FirstOrDefault();

                    if ((diaryStudent != null) && (noteSubject != null))
                    {
                        newStudentNote.Student = diaryStudent;
                        newStudentNote.Subject = noteSubject;
                        database.StudentsNotes.Add(newStudentNote);
                    }
                }

                database.SaveChanges();
            }
        }

        /// <summary>
        /// Метод, который сохраняет расписание учебной группы в базу данных.
        /// </summary>
        /// <param name="groupId"> Идентификатор группы. </param>
        /// <param name="subjectId"> Идентификатор предмета. </param>
        /// <param name="weekTypeId"> Идентификатор типа недели. </param>
        /// <param name="dayOfWeek"> День недели. </param>
        /// <param name="lessonNumber"> Номер пары. </param>
        public static void SaveStudyGroupSchedule(int groupId, int subjectId, int weekTypeId, int dayOfWeek, int lessonNumber)
        {
            using (var database = new ElectronicDiaryDatabaseContext())
            {
                var scheduleAtSpecificNumber = database.GroupsSchedule.Where(schedule => schedule.GroupId == groupId)
                    .Where(schedule => schedule.WeekTypeId == weekTypeId).Where(schedule => schedule.DayOfWeek == dayOfWeek)
                    .Where(schedule => schedule.LessonNumber == lessonNumber).FirstOrDefault();

                if (scheduleAtSpecificNumber != null) 
                {
                    if (subjectId != 0)
                    {
                        var scheduleSubject = database.Subjects.Where(subject => subject.SubjectId == subjectId).FirstOrDefault();

                        if (scheduleSubject != null)
                        {
                            scheduleAtSpecificNumber.SubjectId = subjectId;
                            scheduleAtSpecificNumber.Subject = scheduleSubject;
                        }
                    }
                    else
                    {
                        database.GroupsSchedule.Remove(scheduleAtSpecificNumber);
                    }
                }
                else
                {
                    if (subjectId != 0)
                    {
                        var newScheduleAtSpecificNumber = new GroupSchedule(groupId, subjectId, weekTypeId, dayOfWeek, lessonNumber);
                        var scheduleSubject = database.Subjects.Where(subject => subject.SubjectId == subjectId).FirstOrDefault();
                        var typeOfWeek = database.WeekTypes.Where(type => type.WeekTypeId == weekTypeId).FirstOrDefault();
                        var scheduleGroup = database.Groups.Where(group => group.GroupId == groupId).FirstOrDefault();

                        if ((scheduleSubject != null) && (scheduleGroup != null) && (typeOfWeek != null))
                        {
                            newScheduleAtSpecificNumber.Subject = scheduleSubject;
                            newScheduleAtSpecificNumber.WeekType = typeOfWeek;
                            newScheduleAtSpecificNumber.Group = scheduleGroup;
                            database.GroupsSchedule.Add(newScheduleAtSpecificNumber);
                        }
                    }
                }

                database.SaveChanges();
            }
        }
    }
}