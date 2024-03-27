namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий время проведения пары в базе данных.
/// </summary>
public partial class LessonTimetable
{
    public int LessonId { get; set; }

    public string LessonTime { get; set; } = null!;
}