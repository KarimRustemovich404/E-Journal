using System.Collections.Generic;

namespace WorkWithDatabase;

public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual ICollection<Student> StudentsTables { get; set; } = new List<Student>();

    public virtual ICollection<GroupSchedule> GroupsScheduleTables { get; set; } = new List<GroupSchedule>();

    public Group(string groupName)
    {
        GroupName = groupName;
    }
}
