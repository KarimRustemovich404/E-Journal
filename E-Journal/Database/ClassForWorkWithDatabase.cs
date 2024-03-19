using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace WorkWithDatabase
{
    static class ClassForWorkWithDatabase
    {
        public static (bool, string) CheckingLoginToDiary(string login, string password)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                var diaryUser = (from user in database.ElectronicDiaryUsers where user.UserLogin == login select user).ToList();

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
                int userIndex = int.Parse(informationAboutAccount[informationAboutAccount.Length - 1].ToString());
                string isAdmin = informationAboutAccount.Substring(0, informationAboutAccount.Length - 1);

                if (isAdmin == "Admin")
                {
                    var diaryAdmin = (from admin in database.Administrators where admin.NumberInUserTable == userIndex select admin).ToList()[0];

                    return new List<string> { diaryAdmin.AdministratorId.ToString(), diaryAdmin.AdministratorName, diaryAdmin.AdministratorSurname, diaryAdmin.AdministratorPatronymic };
                }

                else
                {
                    var diaryStudent = (from student in database.Students.Include(u => u.StudentGroupNumberNavigation) where student.NumberInUserTable == userIndex select student).ToList()[0];

                    return new List<string> { diaryStudent.StudentId.ToString(), diaryStudent.StudentName, diaryStudent.StudentSurname, diaryStudent.StudentPatronymic, diaryStudent.StudentGroupNumberNavigation.GroupName, diaryStudent.studentBirthday};
                }
            }
        }

        public static List<List<string>> LoadingScheduleData(int groupId)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                var groupSchedule = (from schedule in database.StudyGroupSchedule where schedule.GroupNumberInGroupTable == groupId select schedule).ToList()[0];

                return new List<List<string>>() { groupSchedule.Monday.Split('/').ToList(), groupSchedule.Tuesday.Split('/').ToList(), groupSchedule.Wednesday.Split('/').ToList(),
                                                  groupSchedule.Thursday.Split('/').ToList(), groupSchedule.Friday.Split('/').ToList(), groupSchedule.Saturday.Split('/').ToList() };
            }
        }

        public static string[] LoadingStudyGroups()
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                var studyGroups = (from studyGroup in database.Groups select studyGroup.GroupName).ToArray();
                return studyGroups;
            }
        }

        public static bool AddingNewStudyGroup(string groupName)
        {
            using (var database = new DatabaseForElectronicDiaryContext()) 
            {
                bool isGroupExist = (from studyGroup in database.Groups where studyGroup.GroupName == groupName select studyGroup).ToList().Count == 0; 

                if (isGroupExist) 
                {
                    var newStudyGroup = new StudyGroup(groupName);
                    database.Groups.Add(newStudyGroup);

                    database.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public static bool AddingNewAdministrator(string administratorLogin, string administratorPassword, string administratorName, string administratorSurname, string administratorPatronymic)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                bool isLoginExist = (from user in database.ElectronicDiaryUsers where user.UserLogin == administratorLogin select user).ToList().Count == 0;

                if (isLoginExist)
                {
                    var newUser = new ElectronicDiaryUser(administratorLogin, administratorPassword, Convert.ToInt32(true), Convert.ToInt32(true));
                    database.ElectronicDiaryUsers.Add(newUser);

                    var newAdministrator = new Administrator(database.ElectronicDiaryUsers.ToList().Count, administratorName, administratorSurname, administratorPatronymic);
                    newAdministrator.NumberInUserTableNavigation = newUser;
                    database.Administrators.Add(newAdministrator);

                    database.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public static bool AddingNewStudent(string studentLogin, string studentPassword, string studentName, string studentSurname, string studentPatronymic, string groupName)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                bool isLoginExist = (from user in database.ElectronicDiaryUsers where user.UserLogin == studentLogin select user).ToList().Count == 0;

                if (isLoginExist)
                {
                    var studentStudyGroup = (from studyGroup in database.Groups where studyGroup.GroupName == groupName select studyGroup).ToList();

                    if (studentStudyGroup.Count != 0)
                    {
                        var newUser = new ElectronicDiaryUser(studentLogin, studentPassword, Convert.ToInt32(true), Convert.ToInt32(false));
                        database.ElectronicDiaryUsers.Add(newUser);

                        var newStudent = new Student(database.ElectronicDiaryUsers.Count(), studentName, studentSurname, studentPatronymic, studentStudyGroup[0].GroupId);
                        newStudent.StudentGroupNumberNavigation = studentStudyGroup[0];
                        newStudent.NumberInUserTableNavigation = newUser;
                        database.Students.Add(newStudent);

                        database.SaveChanges();
                        return true;
                    }
                }

                return false;
            }
        }

        public static void ChangeStudentData(string studentId, string studentName, string studentSurname, string studentPatronymic, string studentBirthday, string studentGroupName)
        {
            using (var database = new DatabaseForElectronicDiaryContext())
            {
                var student = (from stud in database.Students where stud.StudentId == int.Parse(studentId) select stud).ToList()[0];
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
    }
}
