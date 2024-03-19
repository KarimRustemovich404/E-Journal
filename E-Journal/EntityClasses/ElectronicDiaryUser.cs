using System.ComponentModel.DataAnnotations.Schema;

namespace WorkWithDatabase;

[Table("ElectronicDiaryUsersTable")]
public partial class ElectronicDiaryUser
{
    private int userId;
    private string userLogin;
    private string userPassword;
    private int isAccountActive;
    private int isAdmin;
    private Administrator administratorsTable = null!;
    private Student studentsTable = null!;

    public int UserId
    {
        get
        {
            return userId;
        }
    }

    public string UserLogin
    {
        get
        {
            return userLogin;
        }
    }

    public string UserPassword
    {
        get
        {
            return userPassword;
        }
    }

    public int IsAccountActive
    {
        get
        {
            return isAccountActive;
        }
    }

    public int IsAdmin
    {
        get
        {
            return isAdmin;
        }
    }

    public Administrator AdministratorsTable
    {
        get
        {
            return administratorsTable;
        }
    }

    public Student StudentsTable
    {
        get
        {
            return studentsTable;
        }
    }

    public ElectronicDiaryUser(string userLogin, string userPassword, int isAccountActive, int isAdmin)
    {
        this.userLogin = userLogin;
        this.userPassword = userPassword;
        this.isAccountActive = isAccountActive;
        this.isAdmin = isAdmin;
    }
}
