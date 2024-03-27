using System.Collections.Generic;

namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий тип недели в базе данных.
/// </summary>
public partial class WeekType
{
    public int WeekTypeId { get; set; }

    public string WeekTypeName { get; set; } = null!;

    public virtual ICollection<GroupSchedule> GroupsScheduleTable { get; set; } = new List<GroupSchedule>();
}