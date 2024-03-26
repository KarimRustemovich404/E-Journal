using System;
using System.Collections.Generic;

namespace ElectronicDiary.Database;

public partial class StudentMark
{
    public int MarkId { get; set; }

    public int SemesterId { get; set; }

    public int TypeOfMarkId { get; set; }

    public int SubjectId { get; set; }

    public int StudentId { get; set; }

    public int Mark { get; set; }

    public virtual Semester Semester { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual TypeOfMark TypeOfMark { get; set; } = null!;

    public StudentMark(int semesterId, int typeOfMarkId, int subjectId, int studentId, int mark)
    {
        SemesterId = semesterId;
        TypeOfMarkId = typeOfMarkId;
        SubjectId = subjectId;
        StudentId = studentId;
        Mark = mark;
    }
}
