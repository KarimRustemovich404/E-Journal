namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий оценку студента в базе данных.
/// </summary>
public partial class StudentMark
{
    public int MarkId { get; set; }

    public int SemesterId { get; set; }

    public int MarkTypeId { get; set; }

    public int SubjectId { get; set; }

    public int StudentId { get; set; }

    public int Mark { get; set; }

    public virtual Semester Semester { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual MarkType MarkType { get; set; } = null!;

    public StudentMark(int semesterId, int markTypeId, int subjectId, int studentId, int mark)
    {
        SemesterId = semesterId;
        MarkTypeId = markTypeId;
        SubjectId = subjectId;
        StudentId = studentId;
        Mark = mark;
    }
}