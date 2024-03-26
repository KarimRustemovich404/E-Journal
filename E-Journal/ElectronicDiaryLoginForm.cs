using System.Windows.Forms;
using ElectronicDiary.Database;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class ElectronicDiaryLoginForm : Form
    {
        #region События
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Вход".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void EnteryButtonClick(object sender, EventArgs e)
        {
            if ((passwordFieldTextBox.Text != String.Empty) && (passwordFieldTextBox.Text != String.Empty))
            {
                var loginResult = ClassForWorkWithDatabase.CheckingLoginToDiary(loginFieldTextBox.Text, passwordFieldTextBox.Text);

                if (loginResult.Item1)
                {
                    Program.SettingAccountInformationValue(loginResult.Item2);
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

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку Enter.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnteryButtonClick(sender, e);
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на все элементы формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void EnteryFormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        /// <summary>
        /// Метод, который обрабатывает событие, когда TextBox с данными становится активным.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void DataFieldsTextBoxEnter(object sender, EventArgs e)
        {
            loginFieldTextBox.BackColor = SystemColors.ControlLightLight;
            passwordFieldTextBox.BackColor = SystemColors.ControlLightLight;
            errorMessagesLabel.Text = "Вход в систему";
        }
        #endregion

        #region Конструкторы
        public ElectronicDiaryLoginForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}