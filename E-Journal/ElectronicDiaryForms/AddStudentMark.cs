using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class AddStudentMark : Form
    {
        #region Поля
        Student[] arrayOfStudents;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region События
        private void AddStudentMarkButtonClick(object sender, EventArgs e)
        {
            if ((studentFullNameComboBox.SelectedItem != null) && (semesterSelectionComboBox.SelectedItem != null)
                && (subjectSelectionComboBox.SelectedItem != null) && (markTypeSelectionComboBox.SelectedItem != null)
                && (markTextBox.Text.Length != 0))
            {
                DatabaseInteraction.AddStudentMark(arrayOfStudents[studentFullNameComboBox.SelectedIndex].StudentId,
                                     subjectSelectionComboBox.SelectedIndex + 1, markTypeSelectionComboBox.SelectedIndex + 1,
                                     semesterSelectionComboBox.SelectedIndex + 1, int.Parse(markTextBox.Text));
                Close();
            }
            else
            {
                studentFullNameComboBox.BackColor = Color.LightCoral;
                semesterSelectionComboBox.BackColor = Color.LightCoral;
                subjectSelectionComboBox.BackColor = Color.LightCoral;
                markTypeSelectionComboBox.BackColor = Color.LightCoral;
                markTextBox.BackColor = Color.LightCoral;
            }
        }

        private void ControlsWithDataEnter(object sender, EventArgs e)
        {
            studentFullNameComboBox.BackColor = SystemColors.Window;
            semesterSelectionComboBox.BackColor = SystemColors.Window;
            subjectSelectionComboBox.BackColor = SystemColors.Window;
            markTypeSelectionComboBox.BackColor = SystemColors.Window;
            markTextBox.BackColor = SystemColors.Window;
        }

        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            studentFullNameComboBox.BackColor = SystemColors.Window;
            semesterSelectionComboBox.BackColor = SystemColors.Window;
            subjectSelectionComboBox.BackColor = SystemColors.Window;
            markTypeSelectionComboBox.BackColor = SystemColors.Window;
            markTextBox.BackColor = SystemColors.Window;
        }

        private void MarkTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '\b'))
            {
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Конструкторы
        public AddStudentMark(int groupId)
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            arrayOfStudents = DatabaseInteraction.LoadStudentsFromGroups(groupId, true);
            var studentsFullName = new string[arrayOfStudents.Length];

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                studentsFullName[i] = ($"{arrayOfStudents[i].StudentSurname} {arrayOfStudents[i].StudentName} " +
                                       $"{arrayOfStudents[i].StudentPatronymic}");
            }

            studentFullNameComboBox.Items.AddRange(studentsFullName);
            semesterSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadSemesters());
            subjectSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadSubjects());
            markTypeSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadMarksTypes());

            studentFullNameTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            academicSemesterTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            subjectTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            markTypeTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            markTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            studentFullNameComboBox.Font = new Font(fontCollection.Families[0], 12);
            semesterSelectionComboBox.Font = new Font(fontCollection.Families[0], 12);
            subjectSelectionComboBox.Font = new Font(fontCollection.Families[0], 12);
            markTypeSelectionComboBox.Font = new Font(fontCollection.Families[0], 12);
            markTextBox.Font = new Font(fontCollection.Families[0], 12);
            addStudentMarkButton.Font = new Font(fontCollection.Families[0], 14);
        }
        #endregion
    }
}