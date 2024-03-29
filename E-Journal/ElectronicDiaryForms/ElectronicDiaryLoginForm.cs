using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class ElectronicDiaryLoginForm : Form
    {
        #region ����
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region �������
        private void EntryButtonClick(object sender, EventArgs e)
        {
            if ((passwordFieldTextBox.Text != String.Empty) || (passwordFieldTextBox.Text != String.Empty))
            {
                var loginResult = DatabaseInteraction.CheckLoginData(loginFieldTextBox.Text, passwordFieldTextBox.Text);

                if (loginResult)
                {
                    Close();
                }

                errorMessageLabel.Text = "������ �������� ����� ��� ������";
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
            errorMessageLabel.Text = "���� � �������";
            errorMessageLabel.Font = new Font(fontCollection.Families[0], 16);
        }
        #endregion

        #region ������������
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