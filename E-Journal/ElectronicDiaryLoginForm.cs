using System.Windows.Forms;
using WorkWithDatabase;

namespace E_Journal
{
    public partial class ElectronicDiaryLoginForm : Form
    {
        public ElectronicDiaryLoginForm()
        {
            InitializeComponent();
        }

        private void EnteryButtonClick(object sender, EventArgs e)
        {
            if ((passwordFieldTextBox.Text != String.Empty) && (passwordFieldTextBox.Text != String.Empty))
            {
                var loginResult = ClassForWorkWithDatabase.CheckingLoginToDiary(loginFieldTextBox.Text, passwordFieldTextBox.Text);

                if (loginResult.Item1)
                {
                    Program.informationAboutAccount = loginResult.Item2;
                    Close();
                }

                else
                {
                    if (loginResult.Item2 == "Login")
                    {
                        errorMessagesLabel.Text = "Введен неверный логин";
                        loginFieldTextBox.BackColor = Color.LightCoral;
                    }
                    else if (loginResult.Item2 == "Password")
                    {
                        errorMessagesLabel.Text = "Введен неверный пароль";
                        passwordFieldTextBox.BackColor = Color.LightCoral;
                    }
                    else if (loginResult.Item2 == "IsAccountActive")
                    {
                        errorMessagesLabel.Text = "Пользователя не существует";
                        loginFieldTextBox.BackColor = Color.LightCoral;
                        passwordFieldTextBox.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void EnteryFormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void DataFieldsTextBoxEnter(object sender, EventArgs e)
        {
            loginFieldTextBox.BackColor = SystemColors.Window;
            passwordFieldTextBox.BackColor = SystemColors.Window;
            errorMessagesLabel.Text = "Вход в систему";
        }
    }
}