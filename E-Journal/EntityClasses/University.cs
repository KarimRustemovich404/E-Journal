using System.Collections.Generic;

namespace ElectronicDiary.Database
{
    /// <summary>
    /// Класс, описывающий университет в базе данных.
    /// </summary>
    public partial class University
    {
        public int UniversityId { get; set; }

        public string UniversityName { get; set; } = null!;

        public virtual ICollection<Student> StudentsTable { get; set; } = new List<Student>();
    }
}