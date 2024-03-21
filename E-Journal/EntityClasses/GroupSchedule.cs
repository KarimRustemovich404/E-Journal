using System;
using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class GroupSchedule
{
    public int StudyGroupId { get; set; }

    public string? Monday { get; set; }

    public string? Tuesday { get; set; }

    public string? Wednesday { get; set; }

    public string? Thursday { get; set; }

    public string? Friday { get; set; }

    public string? Saturday { get; set; }

    public virtual Group StudyGroup { get; set; } = null!;
}
