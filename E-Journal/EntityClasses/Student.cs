using System.Collections.Generic;

namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий студента в базе данных.
/// </summary>
public partial class Student
{
    public int StudentId { get; set; }

    public int NumberInUserTable { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentSurname { get; set; } = null!;

    public string StudentPatronymic { get; set; } = null!;

    public string StudentBirthday { get; set; } = null!;

    public int UniversityId { get; set; }
         
    public int StudentGroupNumber { get; set; }

    public virtual User NumberInUserTableNavigation { get; set; } = null!;

    public virtual Group StudentGroupNumberNavigation { get; set; } = null!;

    public virtual University UniversityIdNavigation { get; set; } = null!;

    public virtual ICollection<StudentNote> StudentNotesTable { get; set; } = new List<StudentNote>();

    public virtual ICollection<StudentMark> StudentsMarksTable { get; set; } = new List<StudentMark>();
}