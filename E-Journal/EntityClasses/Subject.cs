using System.Collections.Generic;

namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий учебный предмет в базе данных.
/// </summary>
public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<StudentNote> StudentNotesTable { get; set; } = new List<StudentNote>();

    public virtual ICollection<StudentMark> StudentsMarksTable { get; set; } = new List<StudentMark>();

    public virtual ICollection<GroupSchedule> GroupsScheduleTable { get; set; } = new List<GroupSchedule>();

}