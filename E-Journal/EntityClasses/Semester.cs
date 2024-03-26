using System;
using System.Collections.Generic;

namespace ElectronicDiary.Database;

public partial class Semester
{
    public int SemesterId { get; set; }

    public string SemesterName { get; set; } = null!;

    public virtual ICollection<StudentMark> StudentsMarksTables { get; set; } = new List<StudentMark>();
}
