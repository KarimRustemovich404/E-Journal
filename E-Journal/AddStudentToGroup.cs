using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithDatabase;

namespace ElectronicDiary
{
    public partial class AddStudentToGroup : Form
    {
        #region Поля
        private List<Student> listOfStudents;
        private TableLayoutPanel listOfStudyingGroupsContentTableLayoutPanel;
        private int groupId;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddStudentToGroupButtonClick(object sender, EventArgs e)
        {
            if (addStudentToGroupComboBox.SelectedItem != null)
            {
                var studentInNewGroup = listOfStudents[addStudentToGroupComboBox.SelectedIndex];
                ClassForWorkWithDatabase.AddingStudentToGroup(studentInNewGroup.StudentId, groupId);

                var studentFullNameLabel = new Label();
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles[listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Count - 1] = (new RowStyle(SizeType.Percent, 8));
                listOfStudyingGroupsContentTableLayoutPanel.Controls.Add(studentFullNameLabel, 0, listOfStudyingGroupsContentTableLayoutPanel.RowCount - 1);

                studentFullNameLabel.Text = $"{studentInNewGroup.StudentSurname} {studentInNewGroup.StudentName} {studentInNewGroup.StudentPatronymic}";
                studentFullNameLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studentFullNameLabel.ForeColor = SystemColors.WindowText;
                studentFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                studentFullNameLabel.Dock = DockStyle.Fill;

                listOfStudyingGroupsContentTableLayoutPanel.RowCount += 1;
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - (8 * listOfStudyingGroupsContentTableLayoutPanel.RowCount - 2)));
                Close();
            }
            else
            {
                addStudentToGroupComboBox.BackColor = Color.LightCoral;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает вход в addStudentToGroupComboBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddStudentToGroupComboBoxEnter(object sender, EventArgs e)
        {
            addStudentToGroupComboBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на все элементы формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            addStudentToGroupComboBox.BackColor = SystemColors.Window;
        }
        #endregion

        #region Конструторы
        public AddStudentToGroup(int groupId, TableLayoutPanel listOfStudyingGroupsContentTableLayoutPanel)
        {
            InitializeComponent();

            this.groupId = groupId;
            this.listOfStudyingGroupsContentTableLayoutPanel = listOfStudyingGroupsContentTableLayoutPanel;
            listOfStudents = ClassForWorkWithDatabase.LoadingStudentsFromOtherGroups(groupId);
            var studentsFullName = new List<string>();

            foreach (Student student in listOfStudents)
            {
                studentsFullName.Add($"{student.StudentSurname} {student.StudentName} {student.StudentPatronymic}");
            }

            addStudentToGroupComboBox.Items.AddRange(studentsFullName.ToArray());
        }
        #endregion
    }
}