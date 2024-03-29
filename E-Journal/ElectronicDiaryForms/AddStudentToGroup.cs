using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class AddStudentToGroup : Form
    {
        #region Поля
        int groupId;
        Student[] arrayOfStudents;
        TableLayoutPanel listOfStudyingGroupsContentTableLayoutPanel;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region События
        private void AddStudentToGroupButtonClick(object sender, EventArgs e)
        {
            if (addStudentToGroupComboBox.SelectedItem != null)
            {
                var studentInNewGroup = arrayOfStudents[addStudentToGroupComboBox.SelectedIndex];
                DatabaseInteraction.AddStudentToGroup(studentInNewGroup.StudentId, groupId);

                var studentFullNameLabel = new Label();
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles[listOfStudyingGroupsContentTableLayoutPanel
                                                       .RowStyles.Count - 1] = (new RowStyle(SizeType.Percent, 8));
                listOfStudyingGroupsContentTableLayoutPanel.Controls.Add(studentFullNameLabel, 0, 
                                                          listOfStudyingGroupsContentTableLayoutPanel.RowCount - 1);

                studentFullNameLabel.Text = $"{studentInNewGroup.StudentSurname} {studentInNewGroup.StudentName} " +
                                            $"{studentInNewGroup.StudentPatronymic}";
                studentFullNameLabel.Font = new Font(fontCollection.Families[0], 12);
                studentFullNameLabel.ForeColor = SystemColors.WindowText;
                studentFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                studentFullNameLabel.Dock = DockStyle.Fill;

                listOfStudyingGroupsContentTableLayoutPanel.RowCount += 1;
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - 
                                                (8 * listOfStudyingGroupsContentTableLayoutPanel.RowCount - 2)));
                Close();
            }
            else
            {
                addStudentToGroupComboBox.BackColor = Color.LightCoral;
            }
        }

        private void AddStudentToGroupComboBoxEnter(object sender, EventArgs e)
        {
            addStudentToGroupComboBox.BackColor = SystemColors.Window;
        }

        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            addStudentToGroupComboBox.BackColor = SystemColors.Window;
        }

        private void AddStudentToGroupKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddStudentToGroupButtonClick(sender, e);
            }
        }
        #endregion

        #region Конструторы
        public AddStudentToGroup(int groupId, TableLayoutPanel listOfStudyingGroupsContentTableLayoutPanel)
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            this.groupId = groupId;
            this.listOfStudyingGroupsContentTableLayoutPanel = listOfStudyingGroupsContentTableLayoutPanel;
            arrayOfStudents = DatabaseInteraction.LoadStudentsFromGroups(groupId, false);
            var studentsFullName = new string[arrayOfStudents.Length];

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                studentsFullName[i] = ($"{arrayOfStudents[i].StudentSurname} {arrayOfStudents[i].StudentName} " +
                                       $"{arrayOfStudents[i].StudentPatronymic}");
            }

            addStudentToGroupComboBox.Items.AddRange(studentsFullName);
            addStudentToGroupTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            addStudentToGroupComboBox.Font = new Font(fontCollection.Families[0], 12);
            addStudentToGroupButton.Font = new Font(fontCollection.Families[0], 14);
        }
        #endregion
    }
}