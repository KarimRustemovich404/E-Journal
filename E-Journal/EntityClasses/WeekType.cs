using System;
using System.Collections.Generic;

namespace ElectronicDiary.Database;

public partial class WeekType
{
    public int WeekTypeId { get; set; }

    public string WeekTypeName { get; set; } = null!;

    public virtual ICollection<GroupSchedule> GroupsScheduleTables { get; set; } = new List<GroupSchedule>();
}
