using System;
using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class WeekType
{
    public int WeekTypeId { get; set; }

    public string WeekTypeName { get; set; } = null!;

    public virtual ICollection<GroupSchedule> GroupsScheduleTables { get; set; } = new List<GroupSchedule>();
}
