using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class AddNewStudyGroup : Form
    {
        #region Поля
        ComboBox groupSelectionComboBox;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region События
        private void AddNewStudyGroupButtonClick(object sender, EventArgs e)
        {
            if (addNewStudyGroupTextBox.Text.Length != 0)
            {
                if (DatabaseInteraction.AddNewStudyGroup(addNewStudyGroupTextBox.Text))
                {
                    groupSelectionComboBox.Items.Add(addNewStudyGroupTextBox.Text);
                    Close();
                }
                else
                {
                    addNewStudyGroupTextBox.BackColor = Color.LightCoral;
                }
            }
            else
            {
                addNewStudyGroupTextBox.BackColor = Color.LightCoral;
            }
        }

        private void AddNewStudyGroupTextBoxEnter(object sender, EventArgs e)
        {
            addNewStudyGroupTextBox.BackColor = SystemColors.Window;
        }

        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            addNewStudyGroupTextBox.BackColor = SystemColors.Window;
        }

        private void AddNewStudyGroupTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '\b'))
            {
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Конструкторы
        public AddNewStudyGroup(ComboBox groupSelectionComboBox)
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            ActiveControl = null;
            this.groupSelectionComboBox = groupSelectionComboBox;

            addNewStudyGroupTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            addNewStudyGroupTextBox.Font = new Font(fontCollection.Families[0], 14);
            addNewStudyGroupButton.Font = new Font(fontCollection.Families[0], 14);
        }
        #endregion
    }
}