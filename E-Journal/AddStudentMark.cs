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
    public partial class AddStudentMark : Form
    {
        #region Поля
        private List<Student> listOfStudents;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает нажатие кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddStudentMarkButtonClick(object sender, EventArgs e)
        {
            if ((studentFullNameComboBox.SelectedItem != null) && (semesterSelectionComboBox.SelectedItem != null) && (subjectSelectionComboBox.SelectedItem != null) && 
                (markTypeSelectionComboBox.SelectedItem != null) && (markTextBox.Text.Length != 0))
            {
                ClassForWorkWithDatabase.AddingStudentMark(listOfStudents[studentFullNameComboBox.SelectedIndex].StudentId, subjectSelectionComboBox.SelectedIndex + 1, 
                                                           markTypeSelectionComboBox.SelectedIndex + 1, semesterSelectionComboBox.SelectedIndex + 1, int.Parse(markTextBox.Text));
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

        /// <summary>
        /// Метод, который обрабатывает вход в элементы управления с данными.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ControlsWithDataEnter(object sender, EventArgs e)
        {
            studentFullNameComboBox.BackColor = SystemColors.Window;
            semesterSelectionComboBox.BackColor = SystemColors.Window;
            subjectSelectionComboBox.BackColor = SystemColors.Window;
            markTypeSelectionComboBox.BackColor = SystemColors.Window;
            markTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на все элементы формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            studentFullNameComboBox.BackColor = SystemColors.Window;
            semesterSelectionComboBox.BackColor = SystemColors.Window;
            subjectSelectionComboBox.BackColor = SystemColors.Window;
            markTypeSelectionComboBox.BackColor = SystemColors.Window;
            markTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Метод, который обрабатывает ввод символов в markTextBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
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
            InitializeComponent();

            listOfStudents = ClassForWorkWithDatabase.LoadingStudentsFullNameInGroup(groupId);
            var studentsFullName = new List<string>();

            foreach (Student student in listOfStudents)
            {
                studentsFullName.Add($"{student.StudentSurname} {student.StudentName} {student.StudentPatronymic}");
            }

            studentFullNameComboBox.Items.AddRange(studentsFullName.ToArray());
            semesterSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadSemesters().ToArray());
            subjectSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadStudentSubjects());
            markTypeSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingTypesOfMarks());
        }
        #endregion
    }
}