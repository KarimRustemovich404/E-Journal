namespace ElectronicDiary.Database;

/// <summary>
/// Класс, описывающий пользователя в базе данных.
/// </summary>
public partial class User
{
    public int UserId { get; set; }

    public string UserLogin { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int IsAdmin { get; set; }

    public Student StudentsTable { get; set; } = null!;
}