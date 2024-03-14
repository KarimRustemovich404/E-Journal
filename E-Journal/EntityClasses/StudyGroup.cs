using System;
using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class StudyGroup
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual ICollection<Student> StudentsTables { get; set; } = new List<Student>();

    public StudyGroup(string groupName)
    {
        GroupName = groupName;
    }
}
