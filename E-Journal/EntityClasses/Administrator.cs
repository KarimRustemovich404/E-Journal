using System.ComponentModel.DataAnnotations.Schema;

namespace WorkWithDatabase;

[Table("AdministratorsTable")]
public partial class Administrator
{
    #region Поля
    private int administratorId;
    private int numberInUserTable;
    private string administratorName;
    private string administratorSurname;
    private string administratorPatronymic;
    private ElectronicDiaryUser numberInUserTableNavigation = null!;
    #endregion

    #region Свойства
    /// <summary>
    /// Свойство, возвращающее id администратора в таблице администраторов.
    /// </summary>
    public int AdministratorId
    {
        get
        {
            return administratorId;
        }
    }

    /// <summary>
    /// Свойство, возвращающее id администратора в таблице пользователей.
    /// </summary>
    public int NumberInUserTable
    {
        get
        {
            return numberInUserTable;
        }
    }

    /// <summary>
    /// Свойство, возвращающее имя администратора.
    /// </summary>
    public string AdministratorName
    {
        get
        {
            return administratorName;
        }
    }

    /// <summary>
    /// Свойство, возвращающее фамилию администратора.
    /// </summary>
    public string AdministratorSurname
    {
        get
        {
            return administratorSurname;
        }
    }

    /// <summary>
    /// Свойство, созвращающее отчество администратора.
    /// </summary>
    public string AdministratorPatronymic
    {
        get
        {
            return administratorPatronymic;
        }
    }

    /// <summary>
    /// Свойство, возращающее объект типа ElectronicDiaryUsersTable, соответсвующий текущему объекту.
    /// </summary>
    public virtual ElectronicDiaryUser NumberInUserTableNavigation
    {
        get 
        {
            return numberInUserTableNavigation;
        }
        set
        {
            numberInUserTableNavigation = value;
        }
    }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор, создающий экземпляр класса Administrator.
    /// </summary>
    /// <param name="numberInUserTable"> Id администратора в таблице пользователей. </param>
    /// <param name="administratorName"> Имя администратора. </param>
    /// <param name="administratorSurname"> Фамилия администратора. </param>
    /// <param name="administratorPatronymic"> Отчество администратора. </param>
    public Administrator(int numberInUserTable, string administratorName, string administratorSurname, string administratorPatronymic)
    {
        this.numberInUserTable = numberInUserTable;
        this.administratorName = administratorName;
        this.administratorSurname = administratorSurname;
        this.administratorPatronymic = administratorPatronymic;
    }
    #endregion
}
