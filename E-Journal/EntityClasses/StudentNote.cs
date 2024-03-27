namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий заметку студента в базе данных.
/// </summary>
public partial class StudentNote
{
    public int NoteId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public string NoteText { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public StudentNote(int studentId, int subjectId, string noteText)
    {
        StudentId = studentId;
        SubjectId = subjectId;
        NoteText = noteText;
    }
}