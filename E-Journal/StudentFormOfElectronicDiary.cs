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
        private string[] studentSubjects;
        private List<List<string>> studentSchedule;
        private List<Control> controlsInTableLayoutPanel = new List<Control>();
        #endregion

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

                controlsInTableLayoutPanel.Clear();

                var myProfileTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(myProfileTableLayoutPanel, 1, 0);
                myProfileTableLayoutPanel.Dock = DockStyle.Fill;
                myProfileTableLayoutPanel.ColumnCount = 4;
                myProfileTableLayoutPanel.RowCount = 7;
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));

                var myProfileTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(myProfileTitleLabel, 1, 0);
                myProfileTitleLabel.Text = "Мой профиль";
                myProfileTitleLabel.Font = new Font("Arial", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
                myProfileTitleLabel.ForeColor = SystemColors.WindowText;
                myProfileTitleLabel.TextAlign = ContentAlignment.TopLeft;
                myProfileTitleLabel.Dock = DockStyle.Fill;
                myProfileTitleLabel.Margin = new Padding(0, 33, 0, 0);
                controlsInTableLayoutPanel.Add(myProfileTableLayoutPanel);

                var surnameTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameTitleLabel, 1, 1);
                surnameTitleLabel.Text = "Фамилия";
                surnameTitleLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameTitleLabel.ForeColor = SystemColors.WindowText;
                surnameTitleLabel.TextAlign = ContentAlignment.TopLeft;
                surnameTitleLabel.Dock = DockStyle.Fill;

                var nameTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameTitleLabel, 1, 2);
                nameTitleLabel.Text = "Имя";
                nameTitleLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameTitleLabel.ForeColor = SystemColors.WindowText;
                nameTitleLabel.TextAlign = ContentAlignment.TopLeft;
                nameTitleLabel.Dock = DockStyle.Fill;

                var patronymicTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicTitleLabel, 1, 3);
                patronymicTitleLabel.Text = "Отчество";
                patronymicTitleLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicTitleLabel.ForeColor = SystemColors.WindowText;
                patronymicTitleLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicTitleLabel.Dock = DockStyle.Fill;

                var birthDayTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthDayTitleLabel, 1, 4);
                birthDayTitleLabel.Text = "Дата рождения";
                birthDayTitleLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthDayTitleLabel.ForeColor = SystemColors.WindowText;
                birthDayTitleLabel.TextAlign = ContentAlignment.TopLeft;
                birthDayTitleLabel.Dock = DockStyle.Fill;

                var studyGroupTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupTitleLabel, 1, 5);
                studyGroupTitleLabel.Text = "Группа";
                studyGroupTitleLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupTitleLabel.ForeColor = SystemColors.WindowText;
                studyGroupTitleLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupTitleLabel.Dock = DockStyle.Fill;

                var surnameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameLabel, 2, 1);
                surnameLabel.Text = studentSurname;
                surnameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameLabel.ForeColor = SystemColors.WindowText;
                surnameLabel.TextAlign = ContentAlignment.TopLeft;
                surnameLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel.Add(surnameLabel);

                var nameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameLabel, 2, 2);
                nameLabel.Text = studentName;
                nameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameLabel.ForeColor = SystemColors.WindowText;
                nameLabel.TextAlign = ContentAlignment.TopLeft;
                nameLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel.Add(nameLabel);

                var patronymicLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicLabel, 2, 3);
                patronymicLabel.Text = studentPatronymic;
                patronymicLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicLabel.ForeColor = SystemColors.WindowText;
                patronymicLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel.Add(patronymicLabel);

                var birthdayDateLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthdayDateLabel, 2, 4);
                birthdayDateLabel.Text = DateTime.ParseExact(studentBirthday, "dd.MM.yyyy", null).ToLongDateString();
                birthdayDateLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthdayDateLabel.ForeColor = SystemColors.WindowText;
                birthdayDateLabel.TextAlign = ContentAlignment.TopLeft;
                birthdayDateLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel.Add(birthdayDateLabel);

                var studyGroupLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupLabel, 2, 5);
                studyGroupLabel.Text = studentStudyGroup;
                studyGroupLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupLabel.ForeColor = SystemColors.WindowText;
                studyGroupLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel.Add(studyGroupLabel);

                var editButton = new Button();
                myProfileTableLayoutPanel.Controls.Add(editButton, 1, 6);
                editButton.Text = "Редактировать";
                editButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                editButton.ForeColor = SystemColors.WindowText;
                editButton.TextAlign = ContentAlignment.MiddleCenter;
                editButton.Dock = DockStyle.Fill;
                editButton.Margin = new Padding(35, 25, 100, 50);
                editButton.BackColor = SystemColors.ControlLight;
                editButton.FlatStyle = FlatStyle.Flat;
                editButton.FlatAppearance.BorderColor = Color.Black;
                editButton.FlatAppearance.BorderSize = 2;
                editButton.Click += EditButtonClick;
                controlsInTableLayoutPanel.Add(editButton);

                var saveButton = new Button();
                myProfileTableLayoutPanel.Controls.Add(saveButton, 2, 6);
                saveButton.Text = "Сохранить";
                saveButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                saveButton.ForeColor = SystemColors.WindowText;
                saveButton.TextAlign = ContentAlignment.MiddleCenter;
                saveButton.Dock = DockStyle.Fill;
                saveButton.Margin = new Padding(35, 25, 100, 50);
                saveButton.BackColor = SystemColors.ControlLight;
                saveButton.FlatStyle = FlatStyle.Flat;
                saveButton.FlatAppearance.BorderColor = Color.Black;
                saveButton.FlatAppearance.BorderSize = 2;
                saveButton.Click += SaveButtonClick;
                saveButton.Enabled = false;
                controlsInTableLayoutPanel.Add(saveButton);
            }
            else
            {
                myProfileLabel.ForeColor = SystemColors.WindowText;
                myProfileLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

                studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Редактировать".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void EditButtonClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            var editButton = sender as Button;
            var myProfileTableLayoutPanel = controlsInTableLayoutPanel.First() as TableLayoutPanel;

            for (int i = 1; i < (controlsInTableLayoutPanel.Count - 2); i++)
            {
                myProfileTableLayoutPanel.Controls.Remove(controlsInTableLayoutPanel[i]);
            }

            if (controlsInTableLayoutPanel.Last().Enabled == false)
            {
                editButton.BackColor = Color.Silver;
                editButton.FlatAppearance.BorderSize = 3;
                controlsInTableLayoutPanel.Last().Enabled = true;

                var surnameTextBox = new TextBox();
                myProfileTableLayoutPanel.Controls.Add(surnameTextBox, 2, 1);
                surnameTextBox.Text = studentSurname;
                surnameTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameTextBox.ForeColor = SystemColors.WindowText;
                surnameTextBox.Dock = DockStyle.Fill;
                surnameTextBox.BorderStyle = BorderStyle.FixedSingle;
                surnameTextBox.Enter += FullNameTextBoxEnter;
                controlsInTableLayoutPanel[1] = surnameTextBox;

                var nameTextBox = new TextBox();
                myProfileTableLayoutPanel.Controls.Add(nameTextBox, 2, 2);
                nameTextBox.Text = studentName;
                nameTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameTextBox.ForeColor = SystemColors.WindowText;
                nameTextBox.Dock = DockStyle.Fill;
                nameTextBox.BorderStyle = BorderStyle.FixedSingle;
                nameTextBox.Enter += FullNameTextBoxEnter;
                controlsInTableLayoutPanel[2] = nameTextBox;

                var patronymicTextBox = new TextBox();
                myProfileTableLayoutPanel.Controls.Add(patronymicTextBox, 2, 3);
                patronymicTextBox.Text = studentPatronymic;
                patronymicTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicTextBox.ForeColor = SystemColors.WindowText;
                patronymicTextBox.Dock = DockStyle.Fill;
                patronymicTextBox.BorderStyle = BorderStyle.FixedSingle;
                patronymicTextBox.Enter += FullNameTextBoxEnter;
                controlsInTableLayoutPanel[3] = patronymicTextBox;


                var birthDayDateTimePicker = new DateTimePicker();
                myProfileTableLayoutPanel.Controls.Add(birthDayDateTimePicker, 2, 4);
                birthDayDateTimePicker.Value = DateTime.ParseExact(studentBirthday, "dd.MM.yyyy", null);
                birthDayDateTimePicker.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthDayDateTimePicker.CalendarForeColor = SystemColors.WindowText;
                birthDayDateTimePicker.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[4] = birthDayDateTimePicker;

                var studyGroupComboBox = new ComboBox();
                myProfileTableLayoutPanel.Controls.Add(studyGroupComboBox, 2, 5);
                studyGroupComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingStudyGroups());
                studyGroupComboBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupComboBox.ForeColor = SystemColors.WindowText;
                studyGroupComboBox.Dock = DockStyle.Fill;
                studyGroupComboBox.SelectedItem = studentStudyGroup;
                studyGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                controlsInTableLayoutPanel[5] = studyGroupComboBox;
            }
            else
            {
                editButton.BackColor = SystemColors.ControlLight;
                editButton.FlatAppearance.BorderSize = 2;
                controlsInTableLayoutPanel.Last().Enabled = false;

                var surnameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameLabel, 2, 1);
                surnameLabel.Text = studentSurname;
                surnameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameLabel.ForeColor = SystemColors.WindowText;
                surnameLabel.TextAlign = ContentAlignment.TopLeft;
                surnameLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[1] = surnameLabel;

                var nameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameLabel, 2, 2);
                nameLabel.Text = studentName;
                nameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameLabel.ForeColor = SystemColors.WindowText;
                nameLabel.TextAlign = ContentAlignment.TopLeft;
                nameLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[2] = nameLabel;

                var patronymicLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicLabel, 2, 3);
                patronymicLabel.Text = studentPatronymic;
                patronymicLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicLabel.ForeColor = SystemColors.WindowText;
                patronymicLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[3] = patronymicLabel;

                var birthdayDateLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthdayDateLabel, 2, 4);
                birthdayDateLabel.Text = DateTime.ParseExact(studentBirthday, "dd.MM.yyyy", null).ToLongDateString();
                birthdayDateLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthdayDateLabel.ForeColor = SystemColors.WindowText;
                birthdayDateLabel.TextAlign = ContentAlignment.TopLeft;
                birthdayDateLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[4] = birthdayDateLabel;

                var studyGroupLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupLabel, 2, 5);
                studyGroupLabel.Text = studentStudyGroup;
                studyGroupLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupLabel.ForeColor = SystemColors.WindowText;
                studyGroupLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[5] = studyGroupLabel;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void SaveButtonClick(object sender, EventArgs e)
        {
            var myProfileTableLayoutPanel = controlsInTableLayoutPanel.First() as TableLayoutPanel;
            var surnameTexBox = controlsInTableLayoutPanel[1] as TextBox;
            var nameTexBox = controlsInTableLayoutPanel[2] as TextBox;
            var patronymicTexBox = controlsInTableLayoutPanel[3] as TextBox;
            var birthDayDateTimePicker = controlsInTableLayoutPanel[4] as DateTimePicker;
            var studyGroupComboBox = controlsInTableLayoutPanel[5] as ComboBox;
            var editButton = controlsInTableLayoutPanel[6] as Button;

            if ((surnameTexBox.Text != String.Empty) && (nameTexBox.Text != String.Empty) && (patronymicTexBox.Text != String.Empty))
            {
                studentSurname = surnameTexBox.Text;
                studentName = nameTexBox.Text;
                studentPatronymic = patronymicTexBox.Text;
                studentBirthday = birthDayDateTimePicker.Value.ToString("dd.MM.yyyy");
                studentStudyGroup = studyGroupComboBox.SelectedItem.ToString();

                ClassForWorkWithDatabase.ChangeStudentData(studentId, studentName, studentSurname, studentPatronymic, studentBirthday, studentStudyGroup);

                editButton.BackColor = SystemColors.ControlLight;
                editButton.FlatAppearance.BorderSize = 2;
                controlsInTableLayoutPanel.Last().Enabled = false;

                for (int i = 1; i < (controlsInTableLayoutPanel.Count - 2); i++)
                {
                    myProfileTableLayoutPanel.Controls.Remove(controlsInTableLayoutPanel[i]);
                }

                var surnameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameLabel, 2, 1);
                surnameLabel.Text = studentSurname;
                surnameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                surnameLabel.ForeColor = SystemColors.WindowText;
                surnameLabel.TextAlign = ContentAlignment.TopLeft;
                surnameLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[1] = surnameLabel;

                var nameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameLabel, 2, 2);
                nameLabel.Text = studentName;
                nameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                nameLabel.ForeColor = SystemColors.WindowText;
                nameLabel.TextAlign = ContentAlignment.TopLeft;
                nameLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[2] = nameLabel;

                var patronymicLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicLabel, 2, 3);
                patronymicLabel.Text = studentPatronymic;
                patronymicLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                patronymicLabel.ForeColor = SystemColors.WindowText;
                patronymicLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[3] = patronymicLabel;

                var birthdayDateLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthdayDateLabel, 2, 4);
                birthdayDateLabel.Text = DateTime.ParseExact(studentBirthday, "dd.MM.yyyy", null).ToLongDateString();
                birthdayDateLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                birthdayDateLabel.ForeColor = SystemColors.WindowText;
                birthdayDateLabel.TextAlign = ContentAlignment.TopLeft;
                birthdayDateLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[4] = birthdayDateLabel;

                var studyGroupLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupLabel, 2, 5);
                studyGroupLabel.Text = studentStudyGroup;
                studyGroupLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupLabel.ForeColor = SystemColors.WindowText;
                studyGroupLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel[5] = studyGroupLabel;
            }
            else
            {
                if (surnameTexBox.Text.Length == 0)
                {
                    surnameTexBox.BackColor = Color.LightCoral;
                }
                if (nameTexBox.Text.Length == 0)
                {
                    nameTexBox.BackColor = Color.LightCoral;
                }
                if (patronymicTexBox.Text.Length == 0)
                {
                    patronymicTexBox.BackColor = Color.LightCoral;
                }
            }
        }

        /// <summary>
        /// Метод, который обрабатывает вход в textBox с ФИО.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FullNameTextBoxEnter(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i++)
            {
                controlsInTableLayoutPanel[i].BackColor = SystemColors.Window;
            }
        }
        #endregion

        #region Раздел "Успеваемость"
        /// <summary>
        /// Метод, который обрабатывает нажатие на элемент academicPerformanceLabel.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
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

                controlsInTableLayoutPanel.Clear();

                var academicPerformanceTitleTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(academicPerformanceTitleTableLayoutPanel, 1, 0);
                academicPerformanceTitleTableLayoutPanel.Dock = DockStyle.Fill;
                academicPerformanceTitleTableLayoutPanel.ColumnCount = 3;
                academicPerformanceTitleTableLayoutPanel.RowCount = 4;
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
                academicPerformanceTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8));
                academicPerformanceTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84));
                academicPerformanceTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8));

                var academicPerformanceTitleLabel = new Label();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(academicPerformanceTitleLabel, 1, 0);
                academicPerformanceTitleLabel.Text = "Успеваемость";
                academicPerformanceTitleLabel.Font = new Font("Arial", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
                academicPerformanceTitleLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceTitleLabel.TextAlign = ContentAlignment.TopLeft;
                academicPerformanceTitleLabel.Dock = DockStyle.Fill;
                academicPerformanceTitleLabel.Margin = new Padding(8, 22, 0, 0);

                var selectSemesterTableLayoutPanel = new TableLayoutPanel();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(selectSemesterTableLayoutPanel, 1, 1);
                selectSemesterTableLayoutPanel.Dock = DockStyle.Fill;
                selectSemesterTableLayoutPanel.ColumnCount = 2;
                selectSemesterTableLayoutPanel.RowCount = 0;
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));

                var semesterComboBox = new ComboBox();
                selectSemesterTableLayoutPanel.Controls.Add(semesterComboBox, 0, 0);
                semesterComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadSemesters().ToArray());
                semesterComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                semesterComboBox.ForeColor = SystemColors.WindowText;
                semesterComboBox.Dock = DockStyle.Fill;
                semesterComboBox.SelectedItem = String.Empty;
                semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                semesterComboBox.SelectedIndexChanged += SemesterComboBoxSelectedIndexChanged;
                controlsInTableLayoutPanel.Add(semesterComboBox);

                var academicPerformanceContentTableLayoutPanel = new TableLayoutPanel();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(academicPerformanceContentTableLayoutPanel, 1, 2);
                academicPerformanceContentTableLayoutPanel.BackColor = SystemColors.Window;
                academicPerformanceContentTableLayoutPanel.Dock = DockStyle.Fill;
                academicPerformanceContentTableLayoutPanel.ColumnCount = 3;
                academicPerformanceContentTableLayoutPanel.RowCount = 2;
                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                academicPerformanceContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
                academicPerformanceContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
                academicPerformanceContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                controlsInTableLayoutPanel.Add(academicPerformanceContentTableLayoutPanel);

                var subjectNameTitleLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(subjectNameTitleLabel, 0, 0);
                subjectNameTitleLabel.Text = "Дисциплина";
                subjectNameTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                subjectNameTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                subjectNameTitleLabel.Dock = DockStyle.Fill;

                var typeOfPointsTitleLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(typeOfPointsTitleLabel, 1, 0);
                typeOfPointsTitleLabel.Text = "Тип учебного мероприятия";
                typeOfPointsTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                typeOfPointsTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                typeOfPointsTitleLabel.Dock = DockStyle.Fill;

                var markTitleLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(markTitleLabel, 2, 0);
                markTitleLabel.Text = "Оценка";
                markTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                markTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                markTitleLabel.Dock = DockStyle.Fill;

                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
            }
            else
            {
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        /// <summary>
        /// Метод, который обрабатывает изменение в semesterComboBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void SemesterComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var semesterComboBox = controlsInTableLayoutPanel[0] as ComboBox;
            var academicPerformanceContentTableLayoutPanel = controlsInTableLayoutPanel[1] as TableLayoutPanel;

            academicPerformanceContentTableLayoutPanel.Controls.Clear();
            academicPerformanceContentTableLayoutPanel.RowStyles.Clear();

            var subjectNameTitleLabel = new Label();
            academicPerformanceContentTableLayoutPanel.Controls.Add(subjectNameTitleLabel, 0, 0);
            subjectNameTitleLabel.Text = "Дисциплина";
            subjectNameTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            subjectNameTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subjectNameTitleLabel.Dock = DockStyle.Fill;

            var typeOfPointsTitleLabel = new Label();
            academicPerformanceContentTableLayoutPanel.Controls.Add(typeOfPointsTitleLabel, 1, 0);
            typeOfPointsTitleLabel.Text = "Тип учебного мероприятия";
            typeOfPointsTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typeOfPointsTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            typeOfPointsTitleLabel.Dock = DockStyle.Fill;

            var markTitleLabel = new Label();
            academicPerformanceContentTableLayoutPanel.Controls.Add(markTitleLabel, 2, 0);
            markTitleLabel.Text = "Оценка";
            markTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            markTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            markTitleLabel.Dock = DockStyle.Fill;

            int semesterIndex = semesterComboBox.SelectedIndex + 1;
            var studentMarks = ClassForWorkWithDatabase.LoadStudentMarks(semesterIndex, int.Parse(studentId));
            academicPerformanceContentTableLayoutPanel.RowCount = studentMarks.Count + 2;
            academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));

            for (int i = 0; i < studentMarks.Count; i++)
            {
                var subjectNameLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(subjectNameLabel, 0, i + 1);
                subjectNameLabel.Text = studentMarks[i].Subject.SubjectName;
                subjectNameLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                subjectNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                subjectNameLabel.Dock = DockStyle.Fill;

                var typeOfPointsLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(typeOfPointsLabel, 1, i + 1);
                typeOfPointsLabel.Text = studentMarks[i].TypeOfMark.TypeOfMarkName;
                typeOfPointsLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                typeOfPointsLabel.TextAlign = ContentAlignment.MiddleCenter;
                typeOfPointsLabel.Dock = DockStyle.Fill;

                var markLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(markLabel, 2, i + 1);
                markLabel.Text = studentMarks[i].Mark;
                markLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                markLabel.TextAlign = ContentAlignment.MiddleCenter;
                markLabel.Dock = DockStyle.Fill;

                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82 / (academicPerformanceContentTableLayoutPanel.RowCount)));
            }

            academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82 / (academicPerformanceContentTableLayoutPanel.RowCount)));
        }
        #endregion

        #region Раздел "Расписание"
        /// <summary>
        /// Метод, который обрабатывает нажатие на элемент scheduleLabel.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
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

                controlsInTableLayoutPanel.Clear();

                var scheduleTitleTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(scheduleTitleTableLayoutPanel, 1, 0);
                scheduleTitleTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleTitleTableLayoutPanel.ColumnCount = 1;
                scheduleTitleTableLayoutPanel.RowCount = 3;
                scheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                scheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                scheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

                var scheduleTitleLabel = new Label();
                scheduleTitleTableLayoutPanel.Controls.Add(scheduleTitleLabel, 0, 0);
                scheduleTitleLabel.Text = "Расписание";
                scheduleTitleLabel.Font = new Font("Arial", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleTitleLabel.ForeColor = SystemColors.WindowText;
                scheduleTitleLabel.TextAlign = ContentAlignment.TopLeft;
                scheduleTitleLabel.Dock = DockStyle.Fill;
                scheduleTitleLabel.Margin = new Padding(20, 18, 0, 0);

                var scheduleContentTableLayoutPanel = new TableLayoutPanel();
                scheduleTitleTableLayoutPanel.Controls.Add(scheduleContentTableLayoutPanel, 0, 1);
                scheduleContentTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleContentTableLayoutPanel.ColumnCount = 7;
                scheduleContentTableLayoutPanel.RowCount = 3;
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.33F));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.33F));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.33F));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));

                var scheduleMondayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleMondayTableLayoutPanel, 1, 0);
                scheduleMondayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleMondayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleMondayTableLayoutPanel.ColumnCount = 0;
                scheduleMondayTableLayoutPanel.RowCount = studentSchedule[0].Count + 2;
                scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleMondayTableLayoutPanel.DoubleClick += ScheduleDayOfWeekDoubleClick;
                controlsInTableLayoutPanel.Add(scheduleMondayTableLayoutPanel);

                var scheduleMondayTitleLable = new Label();
                scheduleMondayTableLayoutPanel.Controls.Add(scheduleMondayTitleLable, 0, 0);
                scheduleMondayTitleLable.Text = "Понедельник";
                scheduleMondayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleMondayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleMondayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleMondayTitleLable.Dock = DockStyle.Fill;
                scheduleMondayTitleLable.DoubleClick += ScheduleDayOfWeekDoubleClick;

                for (int i = 0; i < studentSchedule[0].Count; i++)
                {
                    var sheduleMondayLable = new Label();
                    scheduleMondayTableLayoutPanel.Controls.Add(sheduleMondayLable, 0, i + 1);
                    sheduleMondayLable.Text = (studentSchedule[0][i].Length != 0) || (studentSchedule[0].Count != 1) ? $"{i + 1}. {studentSchedule[0][i]}" : String.Empty;
                    sheduleMondayLable.ForeColor = Color.WhiteSmoke;
                    sheduleMondayLable.Dock = DockStyle.Fill;
                    sheduleMondayLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                    scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                }
                scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * studentSchedule[0].Count))));

                var scheduleTuesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleTuesdayTableLayoutPanel, 3, 0);
                scheduleTuesdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleTuesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleTuesdayTableLayoutPanel.ColumnCount = 0;
                scheduleTuesdayTableLayoutPanel.RowCount = studentSchedule[1].Count + 2;
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleTuesdayTableLayoutPanel.DoubleClick += ScheduleDayOfWeekDoubleClick;
                controlsInTableLayoutPanel.Add(scheduleTuesdayTableLayoutPanel);


                var scheduleTuesdayTitleLable = new Label();
                scheduleTuesdayTableLayoutPanel.Controls.Add(scheduleTuesdayTitleLable, 0, 0);
                scheduleTuesdayTitleLable.Text = "Вторник";
                scheduleTuesdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleTuesdayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleTuesdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleTuesdayTitleLable.Dock = DockStyle.Fill;
                scheduleTuesdayTitleLable.DoubleClick += ScheduleDayOfWeekDoubleClick;

                for (int i = 0; i < studentSchedule[1].Count; i++)
                {
                    var sheduleTuesdayLable = new Label();
                    scheduleTuesdayTableLayoutPanel.Controls.Add(sheduleTuesdayLable, 0, i + 1);
                    sheduleTuesdayLable.Text = (studentSchedule[1][i].Length != 0) || (studentSchedule[1].Count != 1) ? $"{i + 1}. {studentSchedule[1][i]}" : String.Empty;
                    sheduleTuesdayLable.ForeColor = Color.WhiteSmoke;
                    sheduleTuesdayLable.Dock = DockStyle.Fill;
                    sheduleTuesdayLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                    scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                }

                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * studentSchedule[1].Count))));

                var scheduleWednesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleWednesdayTableLayoutPanel, 5, 0);
                scheduleWednesdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleWednesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleWednesdayTableLayoutPanel.ColumnCount = 0;
                scheduleWednesdayTableLayoutPanel.RowCount = studentSchedule[2].Count + 2;
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleWednesdayTableLayoutPanel.DoubleClick += ScheduleDayOfWeekDoubleClick;
                controlsInTableLayoutPanel.Add(scheduleWednesdayTableLayoutPanel);

                var scheduleWednesdayTitleLable = new Label();
                scheduleWednesdayTableLayoutPanel.Controls.Add(scheduleWednesdayTitleLable, 0, 0);
                scheduleWednesdayTitleLable.Text = "Среда";
                scheduleWednesdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleWednesdayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleWednesdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleWednesdayTitleLable.Dock = DockStyle.Fill;
                scheduleWednesdayTitleLable.DoubleClick += ScheduleDayOfWeekDoubleClick;

                for (int i = 0; i < studentSchedule[2].Count; i++)
                {
                    var sheduleWednesdayLable = new Label();
                    scheduleWednesdayTableLayoutPanel.Controls.Add(sheduleWednesdayLable, 0, i + 1);
                    sheduleWednesdayLable.Text = (studentSchedule[2][i].Length != 0) || (studentSchedule[2].Count != 1) ? $"{i + 1}. {studentSchedule[2][i]}" : String.Empty;
                    sheduleWednesdayLable.ForeColor = Color.WhiteSmoke;
                    sheduleWednesdayLable.Dock = DockStyle.Fill;
                    sheduleWednesdayLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                    scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                }

                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * studentSchedule[2].Count))));

                var scheduleThursdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleThursdayTableLayoutPanel, 1, 2);
                scheduleThursdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleThursdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleThursdayTableLayoutPanel.ColumnCount = 0;
                scheduleThursdayTableLayoutPanel.RowCount = studentSchedule[3].Count + 2;
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleThursdayTableLayoutPanel.DoubleClick += ScheduleDayOfWeekDoubleClick;
                controlsInTableLayoutPanel.Add(scheduleThursdayTableLayoutPanel);

                var scheduleThursdayTitleLable = new Label();
                scheduleThursdayTableLayoutPanel.Controls.Add(scheduleThursdayTitleLable, 0, 0);
                scheduleThursdayTitleLable.Text = "Четверг";
                scheduleThursdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleThursdayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleThursdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleThursdayTitleLable.Dock = DockStyle.Fill;
                scheduleThursdayTitleLable.DoubleClick += ScheduleDayOfWeekDoubleClick;

                for (int i = 0; i < studentSchedule[3].Count; i++)
                {
                    var sheduleThursdayLable = new Label();
                    scheduleThursdayTableLayoutPanel.Controls.Add(sheduleThursdayLable, 0, i + 1);
                    sheduleThursdayLable.Text = (studentSchedule[3][i].Length != 0) || (studentSchedule[3].Count != 1) ? $"{i + 1}. {studentSchedule[3][i]}" : String.Empty;
                    sheduleThursdayLable.ForeColor = Color.WhiteSmoke;
                    sheduleThursdayLable.Dock = DockStyle.Fill;
                    sheduleThursdayLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                    scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                }

                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * studentSchedule[3].Count))));

                var scheduleFridayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleFridayTableLayoutPanel, 3, 2);
                scheduleFridayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleFridayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleFridayTableLayoutPanel.ColumnCount = 0;
                scheduleFridayTableLayoutPanel.RowCount = studentSchedule[4].Count + 2;
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleFridayTableLayoutPanel.DoubleClick += ScheduleDayOfWeekDoubleClick;
                controlsInTableLayoutPanel.Add(scheduleFridayTableLayoutPanel);

                var scheduleFridayTitleLable = new Label();
                scheduleFridayTableLayoutPanel.Controls.Add(scheduleFridayTitleLable, 0, 0);
                scheduleFridayTitleLable.Text = "Пятница";
                scheduleFridayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleFridayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleFridayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleFridayTitleLable.Dock = DockStyle.Fill;
                scheduleFridayTitleLable.DoubleClick += ScheduleDayOfWeekDoubleClick;

                for (int i = 0; i < studentSchedule[4].Count; i++)
                {
                    var sheduleFridayLable = new Label();
                    scheduleFridayTableLayoutPanel.Controls.Add(sheduleFridayLable, 0, i + 1);
                    sheduleFridayLable.Text = (studentSchedule[4][i].Length != 0) || (studentSchedule[4].Count != 1) ? $"{i + 1}. {studentSchedule[4][i]}" : String.Empty;
                    sheduleFridayLable.ForeColor = Color.WhiteSmoke;
                    sheduleFridayLable.Dock = DockStyle.Fill;
                    sheduleFridayLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                    scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                }

                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * studentSchedule[4].Count))));

                var scheduleSaturdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleSaturdayTableLayoutPanel, 5, 2);
                scheduleSaturdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleSaturdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleSaturdayTableLayoutPanel.ColumnCount = 0;
                scheduleSaturdayTableLayoutPanel.RowCount = studentSchedule[5].Count + 2;
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleSaturdayTableLayoutPanel.DoubleClick += ScheduleDayOfWeekDoubleClick;
                controlsInTableLayoutPanel.Add(scheduleSaturdayTableLayoutPanel);

                var schedulуSaturdayTitleLable = new Label();
                scheduleSaturdayTableLayoutPanel.Controls.Add(schedulуSaturdayTitleLable, 0, 0);
                schedulуSaturdayTitleLable.Text = "Суббота";
                schedulуSaturdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                schedulуSaturdayTitleLable.ForeColor = Color.WhiteSmoke;
                schedulуSaturdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                schedulуSaturdayTitleLable.Dock = DockStyle.Fill;
                schedulуSaturdayTitleLable.DoubleClick += ScheduleDayOfWeekDoubleClick;

                for (int i = 0; i < studentSchedule[5].Count; i++)
                {
                    var sheduleSaturdayLable = new Label();
                    scheduleSaturdayTableLayoutPanel.Controls.Add(sheduleSaturdayLable, 0, i + 1);
                    sheduleSaturdayLable.Text = (studentSchedule[5][i].Length != 0) || (studentSchedule[5].Count != 1) ? $"{i + 1}. {studentSchedule[5][i]}" : String.Empty;
                    sheduleSaturdayLable.ForeColor = Color.WhiteSmoke;
                    sheduleSaturdayLable.Dock = DockStyle.Fill;
                    sheduleSaturdayLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                    scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                }

                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * studentSchedule[5].Count))));
            }
            else
            {
                scheduleLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на элементы дня недели в расписании.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ScheduleDayOfWeekDoubleClick(object sender, EventArgs e)
        {
            TableLayoutPanel dayOfWeekTableLayoutPanel;

            if (sender is TableLayoutPanel)
            {
                dayOfWeekTableLayoutPanel = sender as TableLayoutPanel;
            }
            else
            {
                dayOfWeekTableLayoutPanel = (TableLayoutPanel)(sender as Control).Parent;
            }

            int dayIndex = controlsInTableLayoutPanel.IndexOf(dayOfWeekTableLayoutPanel);
            int todayDayOfWeek = (int)DateTime.Today.DayOfWeek;
            string dateOfDay = DateTime.Today.AddDays(dayIndex - todayDayOfWeek + 1).ToShortDateString();

            var cardWithDailySchedule = new CardWithDailySchedule(dateOfDay, studentId, studentSchedule[dayIndex]);
            cardWithDailySchedule.Show();
        }
        #endregion

        #region Раздел "Выйти"
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Выход".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ExitLabelClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход из приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Конструкторы
        public StudentFormOfElectronicDiary(string informationAboutAccount)
        {
            var informationAboutStudent = ClassForWorkWithDatabase.LoadingUserData(informationAboutAccount);

            studentId = informationAboutStudent[0];
            studentName = informationAboutStudent[1];
            studentSurname = informationAboutStudent[2];
            studentPatronymic = informationAboutStudent[3];
            studentStudyGroup = informationAboutStudent[4];
            studentBirthday = informationAboutStudent[5];

            studentSchedule = ClassForWorkWithDatabase.LoadingScheduleData(studentStudyGroup);

            studentSubjects = ClassForWorkWithDatabase.LoadStudentSubjects();

            InitializeComponent();
        }
        #endregion
    }
}