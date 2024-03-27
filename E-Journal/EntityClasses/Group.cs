using System.Collections.Generic;

namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий учебную группу в базе данных.
/// </summary>
public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual ICollection<Student> StudentsTable { get; set; } = new List<Student>();

    public virtual ICollection<GroupSchedule> GroupsScheduleTable { get; set; } = new List<GroupSchedule>();

    public Group(string groupName)
    {
        GroupName = groupName;
    }
}