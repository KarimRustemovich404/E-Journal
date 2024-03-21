using System;
using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class StudentMark
{
    public int MarkId { get; set; }

    public int SemesterId { get; set; }

    public int TypeOfMarkId { get; set; }

    public int SubjectId { get; set; }

    public int StudentId { get; set; }

    public string Mark { get; set; } = null!;

    public virtual Semester Semester { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual TypeOfMark TypeOfMark { get; set; } = null!;
}
