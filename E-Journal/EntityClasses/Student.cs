using System;
using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class Student
{
    public int StudentId { get; set; }

    public int NumberInUserTable { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentSurname { get; set; } = null!;

    public string StudentPatronymic { get; set; } = null!;

    public int StudentGroupNumber { get; set; }

    public virtual ElectronicDiaryUser NumberInUserTableNavigation { get; set; } = null!;

    public virtual StudyGroup StudentGroupNumberNavigation { get; set; } = null!;

    public Student(int numberInUserTable, string studentName, string studentSurname, string studentPatronymic, int studentGroupNumber)
    {
        NumberInUserTable = numberInUserTable;
        StudentName = studentName;
        StudentSurname = studentSurname;
        StudentPatronymic = studentPatronymic;
        StudentGroupNumber = studentGroupNumber;
    }
}
