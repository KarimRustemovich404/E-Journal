using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class ElectronicDiaryLoginForm : Form
    {
        #region Поля
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region События
        private void EntryButtonClick(object sender, EventArgs e)
        {
            if ((passwordFieldTextBox.Text != String.Empty) || (passwordFieldTextBox.Text != String.Empty))
            {
                var loginResult = DatabaseInteraction.CheckLoginData(loginFieldTextBox.Text, passwordFieldTextBox.Text);

                if (loginResult)
                {
                    Close();
                }

                errorMessageLabel.Text = "Введен неверный логин или пароль";
                errorMessageLabel.Font = new Font(fontCollection.Families[0], 14);
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntryButtonClick(sender, e);
            }
        }

        private void EntryFormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void DataFieldsTextBoxEnter(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "Вход в систему";
            errorMessageLabel.Font = new Font(fontCollection.Families[0], 16);
        }
        #endregion

        #region Конструкторы
        public ElectronicDiaryLoginForm()
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            errorMessageLabel.Font = new Font(fontCollection.Families[0], 16);
            loginFieldTextBox.Font = new Font(fontCollection.Families[0], 14);
            passwordFieldTextBox.Font = new Font(fontCollection.Families[0], 14);
            entryFormButton.Font = new Font(fontCollection.Families[0], 16);
        }
        #endregion
    }
}