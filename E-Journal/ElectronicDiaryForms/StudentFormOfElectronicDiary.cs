using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ElectronicDiary.Database;

namespace ElectronicDiary
{
    public partial class StudentFormOfElectronicDiary : Form
    {
        #region Поля
        private int studentId;
        private string studentName;
        private string studentSurname;
        private string studentPatronymic;
        private string studentGroupName;
        private string studentBirthday;
        private int studentGroupId;
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
            controlsInTableLayoutPanel.Clear();

            if (studentFormTableLayoutPanel.Controls.Count > 1)
            {
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }

            if (myProfileLabel.ForeColor == SystemColors.WindowText)
            {
                myProfileLabel.ForeColor = Color.DeepSkyBlue;
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.ForeColor = SystemColors.WindowText;

                var myProfileTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(myProfileTableLayoutPanel, 1, 0);
                myProfileTableLayoutPanel.Dock = DockStyle.Fill;
                myProfileTableLayoutPanel.RowCount = 7;
                myProfileTableLayoutPanel.ColumnCount = 4;
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
                myProfileTitleLabel.Font = new Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
                myProfileTitleLabel.ForeColor = SystemColors.WindowText;
                myProfileTitleLabel.TextAlign = ContentAlignment.TopLeft;
                myProfileTitleLabel.Dock = DockStyle.Fill;
                myProfileTitleLabel.Margin = new Padding(0, 27, 0, 0);

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
                studyGroupLabel.Text = studentGroupName;
                studyGroupLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studyGroupLabel.ForeColor = SystemColors.WindowText;
                studyGroupLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupLabel.Dock = DockStyle.Fill;
                controlsInTableLayoutPanel.Add(studyGroupLabel);
            }
            else
            {
                myProfileLabel.ForeColor = SystemColors.WindowText;
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
            controlsInTableLayoutPanel.Clear();

            if (studentFormTableLayoutPanel.Controls.Count > 1)
            {
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }

            if (academicPerformanceLabel.ForeColor == SystemColors.WindowText)
            {
                academicPerformanceLabel.ForeColor = Color.DeepSkyBlue;
                myProfileLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.ForeColor = SystemColors.WindowText;

                var academicPerformanceTitleTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(academicPerformanceTitleTableLayoutPanel, 1, 0);
                academicPerformanceTitleTableLayoutPanel.Dock = DockStyle.Fill;
                academicPerformanceTitleTableLayoutPanel.RowCount = 4;
                academicPerformanceTitleTableLayoutPanel.ColumnCount = 3;
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
                academicPerformanceTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
                academicPerformanceTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
                academicPerformanceTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88));
                academicPerformanceTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));

                var academicPerformanceTitleLabel = new Label();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(academicPerformanceTitleLabel, 1, 0);
                academicPerformanceTitleLabel.Text = "Успеваемость";
                academicPerformanceTitleLabel.Font = new Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
                academicPerformanceTitleLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceTitleLabel.TextAlign = ContentAlignment.TopLeft;
                academicPerformanceTitleLabel.Dock = DockStyle.Fill;
                academicPerformanceTitleLabel.Margin = new Padding(0, 22, 0, 0);

                var selectSemesterTableLayoutPanel = new TableLayoutPanel();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(selectSemesterTableLayoutPanel, 1, 1);
                selectSemesterTableLayoutPanel.Dock = DockStyle.Fill;
                selectSemesterTableLayoutPanel.ColumnCount = 3;
                selectSemesterTableLayoutPanel.RowCount = 1;
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));

                var semesterTitleLable = new Label();
                selectSemesterTableLayoutPanel.Controls.Add(semesterTitleLable, 0, 0);
                semesterTitleLable.Text = "Выберите семестр:";
                semesterTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                semesterTitleLable.ForeColor = SystemColors.WindowText;
                semesterTitleLable.TextAlign = ContentAlignment.TopLeft;
                semesterTitleLable.Dock = DockStyle.Fill;
                semesterTitleLable.Margin = new Padding(0, 6, 0, 0);

                var semesterComboBox = new ComboBox();
                selectSemesterTableLayoutPanel.Controls.Add(semesterComboBox, 1, 0);
                semesterComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadSemesters().ToArray());
                semesterComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                semesterComboBox.ForeColor = SystemColors.WindowText;
                semesterComboBox.Dock = DockStyle.Fill;
                semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                semesterComboBox.SelectedIndexChanged += SemesterComboBoxSelectedIndexChanged;
                controlsInTableLayoutPanel.Add(semesterComboBox);

                var academicPerformanceContentTableLayoutPanel = new TableLayoutPanel();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(academicPerformanceContentTableLayoutPanel, 1, 2);
                academicPerformanceContentTableLayoutPanel.BackColor = SystemColors.Window;
                academicPerformanceContentTableLayoutPanel.Dock = DockStyle.Fill;
                academicPerformanceContentTableLayoutPanel.RowCount = 2;
                academicPerformanceContentTableLayoutPanel.ColumnCount = 3;
                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85));
                academicPerformanceContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38));
                academicPerformanceContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41));
                academicPerformanceContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
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
            }
            else
            {
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
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

            academicPerformanceContentTableLayoutPanel.RowStyles.Clear();
            var studentMarks = ClassForWorkWithDatabase.LoadStudentMarks(semesterComboBox.SelectedIndex + 1, studentId);
            academicPerformanceContentTableLayoutPanel.RowCount = studentMarks.Count + 2;
            academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

            for (int i = academicPerformanceContentTableLayoutPanel.Controls.Count - 1; i > 2; i--)
            {
                academicPerformanceContentTableLayoutPanel.Controls[i].Dispose();
            }

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
                markLabel.Text = studentMarks[i].Mark.ToString();
                markLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                markLabel.TextAlign = ContentAlignment.MiddleCenter;
                markLabel.Dock = DockStyle.Fill;

                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 / (academicPerformanceContentTableLayoutPanel.RowCount)));
            }

            academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 / (academicPerformanceContentTableLayoutPanel.RowCount)));
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
            controlsInTableLayoutPanel.Clear();

            if (studentFormTableLayoutPanel.Controls.Count > 1)
            {
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }

            if (scheduleLabel.ForeColor == SystemColors.WindowText)
            {
                scheduleLabel.ForeColor = Color.DeepSkyBlue;
                myProfileLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;

                var scheduleTitleTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(scheduleTitleTableLayoutPanel, 1, 0);
                scheduleTitleTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleTitleTableLayoutPanel.RowCount = 3;
                scheduleTitleTableLayoutPanel.ColumnCount = 1;
                scheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13));
                scheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                scheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12));

                var scheduleTitleLabel = new Label();
                scheduleTitleTableLayoutPanel.Controls.Add(scheduleTitleLabel, 0, 0);
                scheduleTitleLabel.Text = "Расписание";
                scheduleTitleLabel.Font = new Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleTitleLabel.ForeColor = SystemColors.WindowText;
                scheduleTitleLabel.TextAlign = ContentAlignment.TopLeft;
                scheduleTitleLabel.Dock = DockStyle.Fill;
                scheduleTitleLabel.Margin = new Padding(20, 16, 0, 0);

                var scheduleContentTableLayoutPanel = new TableLayoutPanel();
                scheduleTitleTableLayoutPanel.Controls.Add(scheduleContentTableLayoutPanel, 0, 1);
                scheduleContentTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleContentTableLayoutPanel.RowCount = 3;
                scheduleContentTableLayoutPanel.ColumnCount = 7;
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.66F));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.66F));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.66F));
                scheduleContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));

                var weekSelectionTableLayoutPanel = new TableLayoutPanel();
                scheduleTitleTableLayoutPanel.Controls.Add(weekSelectionTableLayoutPanel, 0, 2);
                weekSelectionTableLayoutPanel.Dock = DockStyle.Fill;
                weekSelectionTableLayoutPanel.ColumnCount = 4;
                weekSelectionTableLayoutPanel.RowCount = 1;
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43));

                var weekSelectionTitleLable = new Label();
                weekSelectionTableLayoutPanel.Controls.Add(weekSelectionTitleLable, 1, 0);
                weekSelectionTitleLable.Text = "Выберите неделю:";
                weekSelectionTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                weekSelectionTitleLable.ForeColor = SystemColors.WindowText;
                weekSelectionTitleLable.TextAlign = ContentAlignment.TopLeft;
                weekSelectionTitleLable.Dock = DockStyle.Fill;
                weekSelectionTitleLable.Margin = new Padding(0, 18, 0, 0);

                var weekSelectionComboBox = new ComboBox();
                weekSelectionTableLayoutPanel.Controls.Add(weekSelectionComboBox, 2, 0);
                weekSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingTypesOfWeek().ToArray());
                weekSelectionComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                weekSelectionComboBox.ForeColor = SystemColors.WindowText;
                weekSelectionComboBox.Dock = DockStyle.Fill;
                weekSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                weekSelectionComboBox.Margin = new Padding(0, 16, 0, 0);
                weekSelectionComboBox.SelectedIndexChanged += WeekComboBoxSelectedIndexChanged;
                controlsInTableLayoutPanel.Add(weekSelectionComboBox);

                var scheduleMondayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleMondayTableLayoutPanel, 1, 0);
                scheduleMondayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleMondayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleMondayTableLayoutPanel.ColumnCount = 0;
                scheduleMondayTableLayoutPanel.RowCount = 2;
                scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77));
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

                var scheduleTuesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleTuesdayTableLayoutPanel, 3, 0);
                scheduleTuesdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleTuesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleTuesdayTableLayoutPanel.ColumnCount = 0;
                scheduleTuesdayTableLayoutPanel.RowCount = 2;
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77));
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

                var scheduleWednesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleWednesdayTableLayoutPanel, 5, 0);
                scheduleWednesdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleWednesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleWednesdayTableLayoutPanel.ColumnCount = 0;
                scheduleWednesdayTableLayoutPanel.RowCount = 2;
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77));
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

                var scheduleThursdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleThursdayTableLayoutPanel, 1, 2);
                scheduleThursdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleThursdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleThursdayTableLayoutPanel.ColumnCount = 0;
                scheduleThursdayTableLayoutPanel.RowCount = 2;
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77));
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

                var scheduleFridayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleFridayTableLayoutPanel, 3, 2);
                scheduleFridayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleFridayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleFridayTableLayoutPanel.ColumnCount = 0;
                scheduleFridayTableLayoutPanel.RowCount = 2;
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77));
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

                var scheduleSaturdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleSaturdayTableLayoutPanel, 5, 2);
                scheduleSaturdayTableLayoutPanel.BackColor = Color.DeepSkyBlue;
                scheduleSaturdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleSaturdayTableLayoutPanel.ColumnCount = 0;
                scheduleSaturdayTableLayoutPanel.RowCount = 2;
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77));
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
            }
            else
            {
                scheduleLabel.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает изменение в weekSelectionComboBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void WeekComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var weekSelectionComboBox = sender as ComboBox;

            for (int i = 1; i < controlsInTableLayoutPanel.Count; i++)
            {
                int numberOfLessons = ClassForWorkWithDatabase.LoadingNumberOfPairs(studentGroupId, i, weekSelectionComboBox.SelectedIndex + 1); 
                var scheduleTableLayoutPanel = controlsInTableLayoutPanel[i] as TableLayoutPanel;
                scheduleTableLayoutPanel.RowCount = numberOfLessons + 2;
                scheduleTableLayoutPanel.RowStyles.Clear();
                int controlsCount = scheduleTableLayoutPanel.Controls.Count - 1;
                scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                scheduleTableLayoutPanel.Cursor = Cursors.Hand;

                for (int j = controlsCount; j > 0; j--)
                {
                    scheduleTableLayoutPanel.Controls[j].Dispose();
                }

                for (int j = 0; j < numberOfLessons; j++)
                {
                    string scheduleName = ClassForWorkWithDatabase.LoadingScheduleData(studentGroupId, i, weekSelectionComboBox.SelectedIndex + 1, j + 1);

                    if (scheduleName != null)
                    {                       
                        var sheduleNameLable = new Label();
                        scheduleTableLayoutPanel.Controls.Add(sheduleNameLable, 0, j + 1);
                        sheduleNameLable.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        sheduleNameLable.Text = $"{j + 1}. {scheduleName}";
                        sheduleNameLable.ForeColor = Color.WhiteSmoke;
                        sheduleNameLable.Dock = DockStyle.Fill;
                        sheduleNameLable.DoubleClick += ScheduleDayOfWeekDoubleClick;
                        scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                    }
                    else
                    {
                        break;
                    }
                }

                scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * numberOfLessons))));
            }
        }

        /// <summary>
        /// Метод, который обрабатывает двойное нажатие на элементы дня недели в расписании.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ScheduleDayOfWeekDoubleClick(object sender, EventArgs e)
        {
            var weekSelectionComboBox = controlsInTableLayoutPanel.First() as ComboBox;

            if (weekSelectionComboBox.SelectedItem != null)
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

                var cardWithDailySchedule = new CardWithDailySchedule(studentGroupId, studentId, weekSelectionComboBox.SelectedIndex + 1, dayIndex);
                cardWithDailySchedule.Show();
            }
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

            studentId = int.Parse(informationAboutStudent[0]);
            studentName = informationAboutStudent[1];
            studentSurname = informationAboutStudent[2];
            studentPatronymic = informationAboutStudent[3];
            studentGroupName = informationAboutStudent[4];
            studentBirthday = informationAboutStudent[5];
            studentGroupId = ClassForWorkWithDatabase.LoadingStudyGroups().IndexOf(studentGroupName) + 1;

            InitializeComponent();
        }
        #endregion
    }
}