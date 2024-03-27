using System.Collections.Generic;

namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий тип оценки в базе данных
/// </summary>
public partial class MarkType
{
    public int TypeOfMarkId { get; set; }

    public string TypeOfMarkName { get; set; } = null!;

    public virtual ICollection<StudentMark> StudentsMarksTable { get; set; } = new List<StudentMark>();
}