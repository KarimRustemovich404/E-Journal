using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Reflection.Emit;

namespace WorkWithDatabase
{
    static class ClassForWorkWithDatabase
    {
        public static (bool, string) CheckingLoginToDiary(string login, string password)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                var diaryUser = (from user in database.Users where user.UserLogin == login select user).ToList();

                if (diaryUser.Count != 0)
                {
                    if (diaryUser[0].UserPassword == password)
                    {
                        if (diaryUser[0].IsAccountActive == 1)
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
                            return (false, "IsAccountActive");
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

        public static List<string> LoadingUserData(string informationAboutAccount)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                int userIndex = int.Parse(informationAboutAccount.Remove(0, 7));

                var diaryStudent = (from student in database.Students.Include(u => u.StudentGroupNumberNavigation) where student.NumberInUserTable == userIndex select student).ToList()[0];
                return new List<string> { diaryStudent.StudentId.ToString(), diaryStudent.StudentName, diaryStudent.StudentSurname, diaryStudent.StudentPatronymic, diaryStudent.StudentGroupNumberNavigation.GroupName, diaryStudent.studentBirthday };
            }
        }

        public static string LoadingScheduleData(int groupId, int dayOfWeek, int WeekTypeId, int lessonNumber)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
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

        public static int LoadingNumberOfPairs(int groupId, int dayOfWeek, int weekTypeId)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
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

        public static string[] LoadingTypesOfWeek()
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                return (from typeOfWeek in database.WeekTypes select typeOfWeek.WeekTypeName).ToArray();
            }
        }

        public static List<string> LoadingStudyGroups()
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                return (from studyGroup in database.Groups select studyGroup.GroupName).ToList();
            }
        }

        public static List<StudentMark> LoadStudentMarks(int semesterId, int studentId)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                return (from mark in database.StudentsMarks.Include(p => p.Subject).Include(p => p.TypeOfMark) where mark.SemesterId == semesterId where mark.StudentId == studentId select mark).ToList();
            }
        }

        public static List<string> LoadSemesters()
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                return (from semester in database.Semesters select semester.SemesterName).ToList();
            }
        }

        public static string[] LoadStudentSubjects()
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                return (from cl in database.Subjects select cl.SubjectName).ToArray();
            }
        }

        public static bool AddingNewStudyGroup(string groupName)
        {
            using (var database = new DatabaseForElectronicDiaryContext()) 
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

        

        public static void ChangeStudentData(int studentId, string studentName, string studentSurname, string studentPatronymic, string studentBirthday, string studentGroupName)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                var student = (from stud in database.Students where stud.StudentId == studentId select stud).ToList()[0];
                var studyGroup = (from gr in database.Groups where gr.GroupName == studentGroupName select gr).ToList()[0];

                student.StudentName = studentName;
                student.StudentSurname = studentSurname;
                student.StudentPatronymic = studentPatronymic;
                student.StudentGroupNumber = studyGroup.GroupId;
                student.studentBirthday = studentBirthday;

                student.StudentGroupNumberNavigation = studyGroup;

                database.SaveChanges();
            }        
        }

        public static string LoadStudentNote(int studentId, int subjectId)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
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

        public static string LoadLessonsTime(int numberOfLesson)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                return (from lesson in database.LessonsTimes where lesson.LessonId == numberOfLesson select lesson.LessonTime).ToList()[0];
            }
        }

        public static void SaveStudentNote(int studentId, int subjectId, string noteText)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
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
    }
}
