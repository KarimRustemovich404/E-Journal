using System.Collections.Generic;

namespace ElectronicDiary.Database;

public partial class Student
{
    public int StudentId { get; set; }

    public int NumberInUserTable { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentSurname { get; set; } = null!;

    public string StudentPatronymic { get; set; } = null!;

    public string studentBirthday { get; set; } = null!;

    public int StudentGroupNumber { get; set; }

    public virtual User NumberInUserTableNavigation { get; set; } = null!;

    public virtual Group StudentGroupNumberNavigation { get; set; } = null!;

    public virtual ICollection<StudentNote> StudentNotesTables { get; set; } = new List<StudentNote>();

    public virtual ICollection<StudentMark> StudentsMarksTables { get; set; } = new List<StudentMark>();
}
