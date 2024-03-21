using System;
using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<StudentNote> StudentNotesTables { get; set; } = new List<StudentNote>();

    public virtual ICollection<StudentMark> StudentsMarksTables { get; set; } = new List<StudentMark>();
}
