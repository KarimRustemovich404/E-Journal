using System.Windows.Forms;
using ElectronicDiary.Database;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class ElectronicDiaryLoginForm : Form
    {
        #region �������
        /// <summary>
        /// �����, ������� ������������ ������� �� ������ "����".
        /// </summary>
        /// <param name="sender"> ������-���������. </param>
        /// <param name="e"> ������-�������. </param>
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
                        errorMessagesLabel.Text = "������ �������� �����";
                        loginFieldTextBox.BackColor = Color.LightCoral;
                    }
                    else if (loginResult.Item2 == "Password")
                    {
                        errorMessagesLabel.Text = "������ �������� ������";
                        passwordFieldTextBox.BackColor = Color.LightCoral;
                    }
                    else if (loginResult.Item2 == "IsAccountActive")
                    {
                        errorMessagesLabel.Text = "������������ �� ����������";
                        loginFieldTextBox.BackColor = Color.LightCoral;
                        passwordFieldTextBox.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        /// <summary>
        /// �����, ������� ������������ ������� �� ������ Enter.
        /// </summary>
        /// <param name="sender"> ������-���������. </param>
        /// <param name="e"> ������-�������. </param>
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnteryButtonClick(sender, e);
            }
        }

        /// <summary>
        /// �����, ������� ������������ ������� �� ��� �������� �����.
        /// </summary>
        /// <param name="sender"> ������-���������. </param>
        /// <param name="e"> ������-�������. </param>
        private void EnteryFormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        /// <summary>
        /// �����, ������� ������������ �������, ����� TextBox � ������� ���������� ��������.
        /// </summary>
        /// <param name="sender"> ������-���������. </param>
        /// <param name="e"> ������-�������. </param>
        private void DataFieldsTextBoxEnter(object sender, EventArgs e)
        {
            loginFieldTextBox.BackColor = SystemColors.ControlLightLight;
            passwordFieldTextBox.BackColor = SystemColors.ControlLightLight;
            errorMessagesLabel.Text = "���� � �������";
        }
        #endregion

        #region ������������
        public ElectronicDiaryLoginForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}