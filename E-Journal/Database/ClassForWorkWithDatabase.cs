using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ElectronicDiary.Database
{
    /// <summary>
    /// Класс для работы с базой данных.
    /// </summary>
    static class ClassForWorkWithDatabase
    {
        /// <summary>
        /// Метод, который проверяет введенный логин и пароль.
        /// </summary>
        /// <param name="login"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        /// <returns> (Разрешен ли вход, сообщение). </returns>
        public static (bool, string) CheckingLoginToDiary(string login, string password)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var diaryUser = (from user in database.Users where user.UserLogin == DataEncryption.HashingData(login) select user).ToList();

                if (diaryUser.Count != 0)
                {
                    if (diaryUser[0].UserPassword == DataEncryption.HashingData(password))
                    {
                            if (diaryUser[0].IsAdmin == 0)
                            {
                                return (true, $"Student{diaryUser[0].UserId}");
                            }
                            else
                            {
                                return (true, $"Admin{diaryUser[0].UserId}");
                            }
                    }
                    else
                    {
                        return (false, "Password");
                    }
                }
                else
                {
                    return (false, "Login");
                }
            }
        }

        /// <summary>
        /// Метод, который загружает информацию об аккаунте студента.
        /// </summary>
        /// <param name="informationAboutAccount"> Информация об аккаунте. </param>
        /// <returns> Список данных студента. </returns>
        public static List<string> LoadingUserData(string informationAboutAccount)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                int userIndex = int.Parse(informationAboutAccount.Remove(0, 7));

                var diaryStudent = (from student in database.Students.Include(u => u.StudentGroupNumberNavigation) where student.NumberInUserTable == userIndex select student).ToList()[0];
                return new List<string> { diaryStudent.StudentId.ToString(), diaryStudent.StudentName, diaryStudent.StudentSurname, diaryStudent.StudentPatronymic, diaryStudent.StudentGroupNumberNavigation.GroupName, diaryStudent.studentBirthday };
            }
        }

        /// <summary>
        /// Метод, который загружает всех студентов из группы.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static List<Student> LoadingStudentsInGroup(int groupId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from student in database.Students where student.StudentGroupNumber == groupId select student).ToList();
                
            }
        }

        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static List<Student> LoadingStudentsFromOtherGroups(int groupId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from student in database.Students where student.StudentGroupNumber != groupId select student).ToList();

            }
        }

        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static string LoadingScheduleData(int groupId, int dayOfWeek, int WeekTypeId, int lessonNumber)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var daySchedule = (from schedule in database.GroupsSchedule.Include(p => p.Subject) where schedule.GroupId == groupId where schedule.DayOfWeek == dayOfWeek where schedule.WeekTypeId == WeekTypeId select schedule).ToList();

                if (daySchedule.Count != 0)
                {
                    var f = (from s in daySchedule where s.LessonNumber == lessonNumber select s.Subject.SubjectName).ToList();

                    if (f.Count == 0)
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return f[0];
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static int LoadingNumberOfPairs(int groupId, int dayOfWeek, int weekTypeId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var a = (from s in database.GroupsSchedule where s.GroupId == groupId where s.DayOfWeek == dayOfWeek where s.WeekTypeId == weekTypeId select s).ToList();

                int maxNumber = 0;

                foreach(var s in a)
                {
                    if (s.LessonNumber > maxNumber)
                    {
                        maxNumber = s.LessonNumber;
                    }
                }

                return maxNumber;
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static string[] LoadingTypesOfWeek()
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from typeOfWeek in database.WeekTypes select typeOfWeek.WeekTypeName).ToArray();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static string[] LoadingTypesOfMarks()
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from typeOfMark in database.MarksTypes select typeOfMark.TypeOfMarkName).ToArray();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static List<string> LoadingStudyGroups()
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from studyGroup in database.Groups select studyGroup.GroupName).ToList();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static List<StudentMark> LoadStudentMarks(int semesterId, int studentId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from mark in database.StudentsMarks.Include(p => p.Subject).Include(p => p.TypeOfMark) where mark.SemesterId == semesterId where mark.StudentId == studentId select mark).ToList();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static List<string> LoadSemesters()
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from semester in database.Semesters select semester.SemesterName).ToList();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static string[] LoadStudentSubjects()
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from cl in database.Subjects select cl.SubjectName).ToArray();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static Student[] LoadStudentsFromGroup(int groupId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from student in database.Students where student.StudentGroupNumber == groupId select student).ToArray();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static bool AddingNewStudyGroup(string groupName)
        {
            using (var database = new ElectronicDiaryDataBaseContext()) 
            {
                bool isGroupExist = (from studyGroup in database.Groups where studyGroup.GroupName == groupName select studyGroup).ToList().Count == 0; 

                if (isGroupExist) 
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
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static void AddingStudentToGroup(int studentId, int groupId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var studyGroup = (from gr in database.Groups where gr.GroupId == groupId select gr).ToList()[0];
                var student = (from st in database.Students where st.StudentId == studentId select st).ToList()[0];

                studyGroup.StudentsTable.Add(student);
                student.StudentGroupNumber = groupId;

                database.SaveChanges();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static string LoadStudentNote(int studentId, int subjectId)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var studentNote = (from note in database.StudentsNotes where note.StudentId == studentId where note.SubjectId == subjectId select note).ToList();

                if (studentNote.Count != 0)
                {
                    return studentNote[0].NoteText;
                }
                else
                {
                    return String.Empty;
                }
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static string LoadLessonsTime(int numberOfLesson)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                return (from lesson in database.LessonsTimes where lesson.LessonId == numberOfLesson select lesson.LessonTime).ToList()[0];
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static void SaveStudentNote(int studentId, int subjectId, string noteText)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var studentNote = (from note in database.StudentsNotes where note.StudentId == studentId where note.SubjectId == subjectId select note).ToList();

                if (studentNote.Count != 0) 
                {
                    studentNote[0].NoteText = noteText;
                }
                else
                {
                    var newNote = new StudentNote(studentId, subjectId, noteText);
                    var noteSubject = (from subject in database.Subjects where subject.SubjectId == subjectId select subject).ToList()[0];
                    var noteStudent = (from student in database.Students where student.StudentId == studentId select student).ToList()[0];

                    newNote.Student = noteStudent;
                    newNote.Subject = noteSubject;

                    database.StudentsNotes.Add(newNote);
                }

                database.SaveChanges();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static void AddingStudentMark(int studentId, int subjectId, int markTypeId, int semesterId, int subjectMark)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var studentMark = (from mark in database.StudentsMarks where mark.StudentId == studentId where mark.SubjectId == subjectId where mark.TypeOfMarkId == markTypeId where mark.SemesterId == semesterId select mark).ToList();

                if (studentMark.Count != 0)
                {
                    studentMark[0].Mark += subjectMark;
                }
                else
                {
                    var newStudentMark = new StudentMark(semesterId, markTypeId, subjectId, studentId, subjectMark);

                    var markSemester = (from semester in database.Semesters where semester.SemesterId == semesterId select semester).ToList()[0];
                    var typeOfMark = (from type in database.MarksTypes where type.TypeOfMarkId == markTypeId select type).ToList()[0];
                    var markSubject = (from subject in database.Subjects where subject.SubjectId == subjectId select subject).ToList()[0];
                    var student = (from st in database.Students where st.StudentId == studentId select st).ToList()[0];

                    newStudentMark.Semester = markSemester;
                    newStudentMark.TypeOfMark = typeOfMark;
                    newStudentMark.Subject = markSubject;
                    newStudentMark.Student = student;

                    database.StudentsMarks.Add(newStudentMark);
                }

                database.SaveChanges();
            }
        }
        /// <summary>
        /// Метод, который загружает студентов из других групп.
        /// </summary>
        /// <param name="groupId"> Id группы. </param>
        /// <returns> Список студентов. </returns>
        public static void SaveScedule(int groupId, int subjectId, int weekTypeId, int dayOfWeek, int lessonNumber)
        {
            using (var database = new ElectronicDiaryDataBaseContext())
            {
                var schedule = (from sc in database.GroupsSchedule where sc.GroupId == groupId where sc.WeekTypeId == weekTypeId where sc.DayOfWeek == dayOfWeek where sc.LessonNumber == lessonNumber select sc).ToList();

                if (schedule.Count != 0) 
                {
                    if (subjectId != 0)
                    {
                        var subject = (from sb in database.Subjects where sb.SubjectId == subjectId select sb).ToList()[0];
                        schedule[0].SubjectId = subjectId;
                        schedule[0].Subject = subject;
                    }
                    else
                    {
                        database.GroupsSchedule.Remove(schedule[0]);
                    }
                }
                else
                {
                    if (subjectId != 0)
                    {
                        var newGroupSchedule = new GroupSchedule(groupId, subjectId, weekTypeId, dayOfWeek, lessonNumber);
                        var subject = (from sb in database.Subjects where sb.SubjectId == subjectId select sb).ToList()[0];
                        var typeOfWeek = (from tw in database.WeekTypes where tw.WeekTypeId == weekTypeId select tw).ToList()[0];
                        var group = (from gr in database.Groups where gr.GroupId == groupId select gr).ToList()[0];

                        newGroupSchedule.Subject = subject;
                        newGroupSchedule.WeekType = typeOfWeek;
                        newGroupSchedule.Group = group;

                        database.GroupsSchedule.Add(newGroupSchedule);
                    }
                }

                database.SaveChanges();
            }
        }
    }
}
