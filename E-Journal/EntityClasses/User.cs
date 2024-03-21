using System.ComponentModel.DataAnnotations.Schema;

namespace WorkWithDatabase;

[Table("UsersTable")]
public partial class User
{
    private int userId;
    private string userLogin;
    private string userPassword;
    private int isAccountActive;
    private int isAdmin;
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

    public Student StudentsTable
    {
        get
        {
            return studentsTable;
        }
    }

    public User(string userLogin, string userPassword, int isAccountActive, int isAdmin)
    {
        this.userLogin = userLogin;
        this.userPassword = userPassword;
        this.isAccountActive = isAccountActive;
        this.isAdmin = isAdmin;
    }
}
