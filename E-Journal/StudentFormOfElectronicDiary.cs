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

namespace E_Journal
{
    public partial class StudentFormOfElectronicDiary : Form
    {
        #region Поля
        private string studentId;
        private string studentName;
        private string studentSurname;
        private string studentPatronymic;
        private string studentStudyGroup;
        private string studentBirthday;
        private List<Control> controls = new List<Control>();
        #endregion

        public StudentFormOfElectronicDiary(string informationAboutAccount)
        {
            InitializeComponent();

            var informationAboutStudent = ClassForWorkWithDatabase.LoadingUserData(informationAboutAccount);

            studentId = informationAboutStudent[0];
            studentName = informationAboutStudent[1];
            studentSurname = informationAboutStudent[2];
            studentPatronymic = informationAboutStudent[3];
            studentStudyGroup = informationAboutStudent[4];
            studentBirthday = informationAboutStudent[5];
        }
        #region Раздел "Мой профиль"
        /// <summary>
        /// Метод, который обрабатывает нажатие на элемент myProfileLabel.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void MyProfileLabelClick(object sender, EventArgs e)
        {
            if (myProfileLabel.ForeColor == SystemColors.WindowText)
            {
                myProfileLabel.ForeColor = Color.DeepSkyBlue;
                myProfileLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);

                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                scheduleLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                if (studentFormTableLayoutPanel.Controls.Count > 1)
                {
                    studentFormTableLayoutPanel.Controls[1].Dispose();
                }

                controls.Clear();

                var myProfileTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(myProfileTableLayoutPanel, 1, 0);

                myProfileTableLayoutPanel.Name = "myProfileTableLayoutPanel";
                myProfileTableLayoutPanel.Dock = DockStyle.Fill;
                myProfileTableLayoutPanel.ColumnCount = 4;
                myProfileTableLayoutPanel.RowCount = 7;

                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));

                var myProfileTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(myProfileTitleLabel, 1, 0);

                myProfileTitleLabel.Text = "Мой профиль";
                myProfileTitleLabel.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
                myProfileTitleLabel.ForeColor = SystemColors.WindowText;
                myProfileTitleLabel.TextAlign = ContentAlignment.TopLeft;
                myProfileTitleLabel.Dock = DockStyle.Fill;
                myProfileTitleLabel.Margin = new Padding(0, 20, 0, 0);

                var surnameTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameTitleLabel, 1, 1);

                surnameTitleLabel.Text = "Фамилия";
                surnameTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameTitleLabel.ForeColor = SystemColors.WindowText;
                surnameTitleLabel.TextAlign = ContentAlignment.TopLeft;
                surnameTitleLabel.Dock = DockStyle.Fill;

                var nameTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameTitleLabel, 1, 2);

                nameTitleLabel.Text = "Имя";
                nameTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameTitleLabel.ForeColor = SystemColors.WindowText;
                nameTitleLabel.TextAlign = ContentAlignment.TopLeft;
                nameTitleLabel.Dock = DockStyle.Fill;

                var patronymicTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicTitleLabel, 1, 3);

                patronymicTitleLabel.Text = "Отчество";
                patronymicTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicTitleLabel.ForeColor = SystemColors.WindowText;
                patronymicTitleLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicTitleLabel.Dock = DockStyle.Fill;

                var birthDayTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthDayTitleLabel, 1, 4);

                birthDayTitleLabel.Text = "Дата рождения";
                birthDayTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthDayTitleLabel.ForeColor = SystemColors.WindowText;
                birthDayTitleLabel.TextAlign = ContentAlignment.TopLeft;
                birthDayTitleLabel.Dock = DockStyle.Fill;

                var studyGroupTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupTitleLabel, 1, 5);

                studyGroupTitleLabel.Text = "Группа";
                studyGroupTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupTitleLabel.ForeColor = SystemColors.WindowText;
                studyGroupTitleLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupTitleLabel.Dock = DockStyle.Fill;

                var surnameTextBox = new TextBox();
                myProfileTableLayoutPanel.Controls.Add(surnameTextBox, 2, 1);

                surnameTextBox.Text = studentSurname;
                surnameTextBox.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameTextBox.ForeColor = SystemColors.WindowText;
                surnameTextBox.Dock = DockStyle.Fill;
                surnameTextBox.Name = "surnameTexBox";
                surnameTextBox.Enabled = false;
                surnameTextBox.BorderStyle = BorderStyle.FixedSingle;
                controls.Add(surnameTextBox);
                surnameTextBox.Enter += FullNameTextBoxEnter;

                var nameTextBox = new TextBox();
                myProfileTableLayoutPanel.Controls.Add(nameTextBox, 2, 2);

                nameTextBox.Text = studentName;
                nameTextBox.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameTextBox.ForeColor = SystemColors.WindowText;
                nameTextBox.Dock = DockStyle.Fill;
                nameTextBox.Name = "nameTexBox";
                nameTextBox.Enabled = false;
                nameTextBox.BorderStyle = BorderStyle.FixedSingle;
                controls.Add(nameTextBox);
                nameTextBox.Enter += FullNameTextBoxEnter;

                var patronymicTextBox = new TextBox();
                myProfileTableLayoutPanel.Controls.Add(patronymicTextBox, 2, 3);

                patronymicTextBox.Text = studentPatronymic;
                patronymicTextBox.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicTextBox.ForeColor = SystemColors.WindowText;
                patronymicTextBox.Dock = DockStyle.Fill;
                patronymicTextBox.Name = "patronymicTexBox";
                patronymicTextBox.Enabled = false;
                patronymicTextBox.BorderStyle = BorderStyle.FixedSingle;
                controls.Add(patronymicTextBox);
                patronymicTextBox.Enter += FullNameTextBoxEnter;

                var birthDayDateTimePicker = new DateTimePicker();
                myProfileTableLayoutPanel.Controls.Add(birthDayDateTimePicker, 2, 4);

                birthDayDateTimePicker.Value = DateTime.ParseExact(studentBirthday, "dd.MM.yyyy", null);
                birthDayDateTimePicker.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthDayDateTimePicker.CalendarForeColor = SystemColors.WindowText;
                birthDayDateTimePicker.Dock = DockStyle.Fill;
                birthDayDateTimePicker.Name = "birthDayDateTimePicker";
                birthDayDateTimePicker.Enabled = false;
                controls.Add(birthDayDateTimePicker);

                var studyGroupComboBox = new ComboBox();
                myProfileTableLayoutPanel.Controls.Add(studyGroupComboBox, 2, 5);

                studyGroupComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingStudyGroups());
                studyGroupComboBox.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupComboBox.ForeColor = SystemColors.WindowText;
                studyGroupComboBox.Dock = DockStyle.Fill;
                studyGroupComboBox.Name = "studyGroupComboBox";
                studyGroupComboBox.Enabled = false;
                studyGroupComboBox.SelectedItem = studentStudyGroup;
                controls.Add(studyGroupComboBox);

                var editButton = new Button();
                myProfileTableLayoutPanel.Controls.Add(editButton, 1, 6);

                editButton.Text = "Редактировать";
                editButton.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
                editButton.TextAlign = ContentAlignment.MiddleCenter;
                editButton.ForeColor = SystemColors.WindowText;
                editButton.Dock = DockStyle.Fill;
                editButton.Name = "editButton";
                editButton.Margin = new Padding(50, 25, 50, 15);
                editButton.Click += EditButtonClick;

                var saveButton = new Button();
                myProfileTableLayoutPanel.Controls.Add(saveButton, 2, 6);

                saveButton.Text = "Сохранить";
                saveButton.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
                saveButton.TextAlign = ContentAlignment.MiddleCenter;
                saveButton.ForeColor = SystemColors.WindowText;
                saveButton.Dock = DockStyle.Fill;
                saveButton.Name = "saveButton";
                saveButton.Margin = new Padding(50, 25, 50, 15);
                saveButton.Enabled = false;
                controls.Add(saveButton);
                saveButton.Click += SaveButtonClick;

                ActiveControl = null;
            }
            else
            {
                myProfileLabel.ForeColor = SystemColors.WindowText;
                myProfileLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                controls.Clear();
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            foreach (Control element in controls)
            {
                element.Enabled = true;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var myProfileTableLayoutPanel = studentFormTableLayoutPanel.Controls["myProfileTableLayoutPanel"];

            var surnameTexBox = myProfileTableLayoutPanel.Controls["surnameTexBox"] as TextBox;
            var nameTexBox = myProfileTableLayoutPanel.Controls["nameTexBox"] as TextBox;
            var patronymicTexBox = myProfileTableLayoutPanel.Controls["patronymicTexBox"] as TextBox;
            var birthDayDateTimePicker = myProfileTableLayoutPanel.Controls["birthDayDateTimePicker"] as DateTimePicker;
            var studyGroupComboBox = myProfileTableLayoutPanel.Controls["studyGroupComboBox"] as ComboBox;

            if ((surnameTexBox.Text != String.Empty) && (nameTexBox.Text != String.Empty) && (patronymicTexBox.Text != String.Empty))
            {
                studentSurname = surnameTexBox.Text;
                studentName = nameTexBox.Text;
                studentPatronymic = patronymicTexBox.Text;
                studentBirthday = birthDayDateTimePicker.Value.ToString("dd.MM.yyyy");
                studentStudyGroup = studyGroupComboBox.SelectedItem.ToString();

                ClassForWorkWithDatabase.ChangeStudentData(studentId, studentName, studentSurname, studentPatronymic, studentBirthday, studentStudyGroup);

                foreach (Control element in controls)
                {
                    element.Enabled = false;
                }
            }
            else
            {
                surnameTexBox.BackColor = Color.LightCoral;
                nameTexBox.BackColor = Color.LightCoral;
                patronymicTexBox.BackColor = Color.LightCoral;
            }      
        }

        private void FullNameTextBoxEnter(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                controls[i].BackColor = SystemColors.Window;
            }
        }
        #endregion

        private void ExitLabelClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход из приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AcademicPerformanceLabelClick(object sender, EventArgs e)
        {
            if (academicPerformanceLabel.ForeColor == SystemColors.WindowText)
            {
                academicPerformanceLabel.ForeColor = Color.DeepSkyBlue;
                academicPerformanceLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);

                myProfileLabel.ForeColor = SystemColors.WindowText;
                myProfileLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                scheduleLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                if (studentFormTableLayoutPanel.Controls.Count > 1)
                {
                    studentFormTableLayoutPanel.Controls[1].Dispose();
                }

                controls.Clear();
            }
            else
            {
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                controls.Clear();
                //studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        private void ScheduleLabelClick(object sender, EventArgs e)
        {
            if (scheduleLabel.ForeColor == SystemColors.WindowText)
            {
                scheduleLabel.ForeColor = Color.DeepSkyBlue;
                scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);

                myProfileLabel.ForeColor = SystemColors.WindowText;
                myProfileLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                if (studentFormTableLayoutPanel.Controls.Count > 1)
                {
                    studentFormTableLayoutPanel.Controls[1].Dispose();
                }

                controls.Clear();
            }
            else
            {
                scheduleLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                controls.Clear();
                //studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }
    }
}
