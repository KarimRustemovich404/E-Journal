using System;
using System.Collections.Generic;

namespace ElectronicDiary.Database;

public partial class TypeOfMark
{
    public int TypeOfMarkId { get; set; }

    public string TypeOfMarkName { get; set; } = null!;

    public virtual ICollection<StudentMark> StudentsMarksTables { get; set; } = new List<StudentMark>();
}
