using System;
using System.Collections.Generic;

namespace ElectronicDiary.Database;

public partial class GroupSchedule
{
    public int ScheduleId { get; set; }

    public int GroupId { get; set; }

    public int SubjectId { get; set; }

    public int WeekTypeId { get; set; }

    public int DayOfWeek { get; set; }

    public int LessonNumber { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual WeekType WeekType { get; set; } = null!;

    public GroupSchedule(int groupId, int subjectId, int weekTypeId, int dayOfWeek, int lessonNumber)
    {
        GroupId = groupId;
        SubjectId = subjectId;
        WeekTypeId = weekTypeId;
        DayOfWeek = dayOfWeek;
        LessonNumber = lessonNumber;
    }
}
