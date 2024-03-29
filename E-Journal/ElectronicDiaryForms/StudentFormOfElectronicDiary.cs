using System.Collections.Generic;
using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System;


namespace ElectronicDiary
{
    public partial class StudentFormOfElectronicDiary : Form
    {
        #region Поля
        int studentId;
        int studentGroupId;
        string studentName = null!;
        string studentSurname = null!;
        string studentPatronymic = null!;
        string studentGroupName = null!;
        string studentBirthday = null!;
        string studentInstitute = null!;
        List<Control> controlsInTableLayoutPanel = new List<Control>();
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        private void CleanStudentFormTableLayoutPanel()
        {
            controlsInTableLayoutPanel.Clear();

            if (studentFormTableLayoutPanel.Controls.Count == 2)
            {
                studentFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        #region Раздел "Мой профиль"
        private void MyProfileLabelClick(object sender, EventArgs e)
        {
            CleanStudentFormTableLayoutPanel();

            if (myProfileLabel.ForeColor == SystemColors.WindowText)
            {
                myProfileLabel.ForeColor = Color.DeepSkyBlue;
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
                scheduleLabel.ForeColor = SystemColors.WindowText;

                var myProfileTableLayoutPanel = new TableLayoutPanel();
                studentFormTableLayoutPanel.Controls.Add(myProfileTableLayoutPanel, 1, 0);
                myProfileTableLayoutPanel.Dock = DockStyle.Fill;
                myProfileTableLayoutPanel.RowCount = 8;
                myProfileTableLayoutPanel.ColumnCount = 4;
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                myProfileTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));

                var myProfileTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(myProfileTitleLabel, 1, 0);
                myProfileTitleLabel.Text = "Мой профиль";
                myProfileTitleLabel.Font = new Font(fontCollection.Families[0], 30);
                myProfileTitleLabel.ForeColor = SystemColors.WindowText;
                myProfileTitleLabel.TextAlign = ContentAlignment.TopLeft;
                myProfileTitleLabel.Dock = DockStyle.Fill;
                myProfileTitleLabel.Margin = new Padding(0, 27, 0, 0);

                var surnameTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameTitleLabel, 1, 1);
                surnameTitleLabel.Text = "Фамилия";
                surnameTitleLabel.Font = new Font(fontCollection.Families[0], 18);
                surnameTitleLabel.ForeColor = SystemColors.WindowText;
                surnameTitleLabel.TextAlign = ContentAlignment.TopLeft;
                surnameTitleLabel.Dock = DockStyle.Fill;

                var nameTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameTitleLabel, 1, 2);
                nameTitleLabel.Text = "Имя";
                nameTitleLabel.Font = new Font(fontCollection.Families[0], 18);
                nameTitleLabel.ForeColor = SystemColors.WindowText;
                nameTitleLabel.TextAlign = ContentAlignment.TopLeft;
                nameTitleLabel.Dock = DockStyle.Fill;

                var patronymicTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicTitleLabel, 1, 3);
                patronymicTitleLabel.Text = "Отчество";
                patronymicTitleLabel.Font = new Font(fontCollection.Families[0], 18);
                patronymicTitleLabel.ForeColor = SystemColors.WindowText;
                patronymicTitleLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicTitleLabel.Dock = DockStyle.Fill;

                var birthDayTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthDayTitleLabel, 1, 4);
                birthDayTitleLabel.Text = "Дата рождения";
                birthDayTitleLabel.Font = new Font(fontCollection.Families[0], 18);
                birthDayTitleLabel.ForeColor = SystemColors.WindowText;
                birthDayTitleLabel.TextAlign = ContentAlignment.TopLeft;
                birthDayTitleLabel.Dock = DockStyle.Fill;

                var studyGroupTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupTitleLabel, 1, 5);
                studyGroupTitleLabel.Text = "Группа";
                studyGroupTitleLabel.Font = new Font(fontCollection.Families[0], 18);
                studyGroupTitleLabel.ForeColor = SystemColors.WindowText;
                studyGroupTitleLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupTitleLabel.Dock = DockStyle.Fill;

                var instituteTitleLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(instituteTitleLabel, 1, 6);
                instituteTitleLabel.Text = "Институт";
                instituteTitleLabel.Font = new Font(fontCollection.Families[0], 18);
                instituteTitleLabel.ForeColor = SystemColors.WindowText;
                instituteTitleLabel.TextAlign = ContentAlignment.TopLeft;
                instituteTitleLabel.Dock = DockStyle.Fill;

                var surnameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(surnameLabel, 2, 1);
                surnameLabel.Text = studentSurname;
                surnameLabel.Font = new Font(fontCollection.Families[0], 18);
                surnameLabel.ForeColor = SystemColors.WindowText;
                surnameLabel.TextAlign = ContentAlignment.TopLeft;
                surnameLabel.Dock = DockStyle.Fill;

                var nameLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(nameLabel, 2, 2);
                nameLabel.Text = studentName;
                nameLabel.Font = new Font(fontCollection.Families[0], 18);
                nameLabel.ForeColor = SystemColors.WindowText;
                nameLabel.TextAlign = ContentAlignment.TopLeft;
                nameLabel.Dock = DockStyle.Fill;

                var patronymicLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(patronymicLabel, 2, 3);
                patronymicLabel.Text = studentPatronymic;
                patronymicLabel.Font = new Font(fontCollection.Families[0], 18);
                patronymicLabel.ForeColor = SystemColors.WindowText;
                patronymicLabel.TextAlign = ContentAlignment.TopLeft;
                patronymicLabel.Dock = DockStyle.Fill;

                var birthdayDateLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(birthdayDateLabel, 2, 4);
                birthdayDateLabel.Text = studentBirthday;
                birthdayDateLabel.Font = new Font(fontCollection.Families[0], 18);
                birthdayDateLabel.ForeColor = SystemColors.WindowText;
                birthdayDateLabel.TextAlign = ContentAlignment.TopLeft;
                birthdayDateLabel.Dock = DockStyle.Fill;

                var studyGroupLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(studyGroupLabel, 2, 5);
                studyGroupLabel.Text = studentGroupName;
                studyGroupLabel.Font = new Font(fontCollection.Families[0], 18);
                studyGroupLabel.ForeColor = SystemColors.WindowText;
                studyGroupLabel.TextAlign = ContentAlignment.TopLeft;
                studyGroupLabel.Dock = DockStyle.Fill;

                var instituteLabel = new Label();
                myProfileTableLayoutPanel.Controls.Add(instituteLabel, 2, 6);
                instituteLabel.Text = studentInstitute;
                instituteLabel.Font = new Font(fontCollection.Families[0], 18);
                instituteLabel.ForeColor = SystemColors.WindowText;
                instituteLabel.TextAlign = ContentAlignment.TopLeft;
                instituteLabel.Dock = DockStyle.Fill;
            }
            else
            {
                myProfileLabel.ForeColor = SystemColors.WindowText;
            }
        }
        #endregion

        #region Раздел "Успеваемость"
        private void AcademicPerformanceLabelClick(object sender, EventArgs e)
        {
            CleanStudentFormTableLayoutPanel();

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
                academicPerformanceTitleLabel.Font = new Font(fontCollection.Families[0], 30);
                academicPerformanceTitleLabel.ForeColor = SystemColors.WindowText;
                academicPerformanceTitleLabel.TextAlign = ContentAlignment.TopLeft;
                academicPerformanceTitleLabel.Dock = DockStyle.Fill;
                academicPerformanceTitleLabel.Margin = new Padding(0, 19, 0, 0);

                var selectSemesterTableLayoutPanel = new TableLayoutPanel();
                academicPerformanceTitleTableLayoutPanel.Controls.Add(selectSemesterTableLayoutPanel, 1, 1);
                selectSemesterTableLayoutPanel.Dock = DockStyle.Fill;
                selectSemesterTableLayoutPanel.ColumnCount = 3;
                selectSemesterTableLayoutPanel.RowCount = 1;
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                selectSemesterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));

                var semesterTitleLabel = new Label();
                selectSemesterTableLayoutPanel.Controls.Add(semesterTitleLabel, 0, 0);
                semesterTitleLabel.Text = "Выберите семестр:";
                semesterTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                semesterTitleLabel.ForeColor = SystemColors.WindowText;
                semesterTitleLabel.TextAlign = ContentAlignment.TopLeft;
                semesterTitleLabel.Dock = DockStyle.Fill;
                semesterTitleLabel.Margin = new Padding(4, 6, 0, 0);

                var semesterComboBox = new ComboBox();
                selectSemesterTableLayoutPanel.Controls.Add(semesterComboBox, 1, 0);
                semesterComboBox.Items.AddRange(DatabaseInteraction.LoadSemesters());
                semesterComboBox.Font = new Font(fontCollection.Families[0], 12);
                semesterComboBox.ForeColor = SystemColors.WindowText;
                semesterComboBox.Dock = DockStyle.Fill;
                semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                semesterComboBox.SelectedIndexChanged += SemesterComboBoxSelectedIndexChanged;
                semesterComboBox.Cursor = Cursors.Hand;
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
                subjectNameTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                subjectNameTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                subjectNameTitleLabel.Dock = DockStyle.Fill;

                var typeOfPointsTitleLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(typeOfPointsTitleLabel, 1, 0);
                typeOfPointsTitleLabel.Text = "Тип учебного мероприятия";
                typeOfPointsTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                typeOfPointsTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                typeOfPointsTitleLabel.Dock = DockStyle.Fill;

                var markTitleLabel = new Label();
                academicPerformanceContentTableLayoutPanel.Controls.Add(markTitleLabel, 2, 0);
                markTitleLabel.Text = "Оценка";
                markTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                markTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                markTitleLabel.Dock = DockStyle.Fill;
            }
            else
            {
                academicPerformanceLabel.ForeColor = SystemColors.WindowText;
            }
        }

        private void SemesterComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var academicPerformanceContentTableLayoutPanel = controlsInTableLayoutPanel[1] as TableLayoutPanel;
            var semesterComboBox = sender as ComboBox;

            if ((semesterComboBox != null) && (academicPerformanceContentTableLayoutPanel != null))
            {
                var studentMarks = DatabaseInteraction.LoadStudentMarks(semesterComboBox.SelectedIndex + 1, studentId);
                academicPerformanceContentTableLayoutPanel.RowStyles.Clear();
                academicPerformanceContentTableLayoutPanel.RowCount = studentMarks.Length + 2;
                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

                for (int i = academicPerformanceContentTableLayoutPanel.Controls.Count - 1; i > 2; i--)
                {
                    academicPerformanceContentTableLayoutPanel.Controls[i].Dispose();
                }

                for (int i = 0; i < studentMarks.Length; i++)
                {
                    var subjectNameLabel = new Label();
                    academicPerformanceContentTableLayoutPanel.Controls.Add(subjectNameLabel, 0, i + 1);
                    subjectNameLabel.Text = studentMarks[i].Subject.SubjectName;
                    subjectNameLabel.Font = new Font(fontCollection.Families[0], 12);
                    subjectNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    subjectNameLabel.Dock = DockStyle.Fill;

                    var typeOfPointsLabel = new Label();
                    academicPerformanceContentTableLayoutPanel.Controls.Add(typeOfPointsLabel, 1, i + 1);
                    typeOfPointsLabel.Text = studentMarks[i].MarkType.MarkTypeName;
                    typeOfPointsLabel.Font = new Font(fontCollection.Families[0], 12);
                    typeOfPointsLabel.TextAlign = ContentAlignment.MiddleCenter;
                    typeOfPointsLabel.Dock = DockStyle.Fill;

                    var markLabel = new Label();
                    academicPerformanceContentTableLayoutPanel.Controls.Add(markLabel, 2, i + 1);
                    markLabel.Text = studentMarks[i].Mark.ToString();
                    markLabel.Font = new Font(fontCollection.Families[0], 12);
                    markLabel.TextAlign = ContentAlignment.MiddleCenter;
                    markLabel.Dock = DockStyle.Fill;

                    academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent,
                                                85 / (academicPerformanceContentTableLayoutPanel.RowCount - 1)));
                }

                academicPerformanceContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 
                                                85 / (academicPerformanceContentTableLayoutPanel.RowCount - 1)));
            }
        }
        #endregion

        #region Раздел "Расписание"
        private void ScheduleLabelClick(object sender, EventArgs e)
        {
            CleanStudentFormTableLayoutPanel();

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
                scheduleTitleLabel.Font = new Font(fontCollection.Families[0], 30);
                scheduleTitleLabel.ForeColor = SystemColors.WindowText;
                scheduleTitleLabel.TextAlign = ContentAlignment.TopLeft;
                scheduleTitleLabel.Dock = DockStyle.Fill;
                scheduleTitleLabel.Margin = new Padding(11, 10, 0, 0);

                var scheduleContentTableLayoutPanel = new TableLayoutPanel();
                scheduleTitleTableLayoutPanel.Controls.Add(scheduleContentTableLayoutPanel, 0, 1);
                scheduleContentTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleContentTableLayoutPanel.RowCount = 3;
                scheduleContentTableLayoutPanel.ColumnCount = 7;
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48));
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                scheduleContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48));
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
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                weekSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53));

                var weekSelectionTitleLabel = new Label();
                weekSelectionTableLayoutPanel.Controls.Add(weekSelectionTitleLabel, 1, 0);
                weekSelectionTitleLabel.Text = "Выберите неделю:";
                weekSelectionTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                weekSelectionTitleLabel.ForeColor = SystemColors.WindowText;
                weekSelectionTitleLabel.TextAlign = ContentAlignment.TopLeft;
                weekSelectionTitleLabel.Dock = DockStyle.Fill;
                weekSelectionTitleLabel.Margin = new Padding(0, 18, 0, 0);

                var weekSelectionComboBox = new ComboBox();
                weekSelectionTableLayoutPanel.Controls.Add(weekSelectionComboBox, 2, 0);
                weekSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadWeeksTypes());
                weekSelectionComboBox.Font = new Font(fontCollection.Families[0], 12);
                weekSelectionComboBox.ForeColor = SystemColors.WindowText;
                weekSelectionComboBox.Dock = DockStyle.Fill;
                weekSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                weekSelectionComboBox.Margin = new Padding(0, 16, 0, 0);
                weekSelectionComboBox.SelectedIndexChanged += WeekComboBoxSelectedIndexChanged;
                weekSelectionComboBox.Cursor = Cursors.Hand;
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

                var scheduleMondayTitleLabel = new Label();
                scheduleMondayTableLayoutPanel.Controls.Add(scheduleMondayTitleLabel, 0, 0);
                scheduleMondayTitleLabel.Text = "Понедельник";
                scheduleMondayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleMondayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleMondayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleMondayTitleLabel.Dock = DockStyle.Fill;
                scheduleMondayTitleLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;

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

                var scheduleTuesdayTitleLabel = new Label();
                scheduleTuesdayTableLayoutPanel.Controls.Add(scheduleTuesdayTitleLabel, 0, 0);
                scheduleTuesdayTitleLabel.Text = "Вторник";
                scheduleTuesdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleTuesdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleTuesdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleTuesdayTitleLabel.Dock = DockStyle.Fill;
                scheduleTuesdayTitleLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;

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

                var scheduleWednesdayTitleLabel = new Label();
                scheduleWednesdayTableLayoutPanel.Controls.Add(scheduleWednesdayTitleLabel, 0, 0);
                scheduleWednesdayTitleLabel.Text = "Среда";
                scheduleWednesdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleWednesdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleWednesdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleWednesdayTitleLabel.Dock = DockStyle.Fill;
                scheduleWednesdayTitleLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;

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

                var scheduleThursdayTitleLabel = new Label();
                scheduleThursdayTableLayoutPanel.Controls.Add(scheduleThursdayTitleLabel, 0, 0);
                scheduleThursdayTitleLabel.Text = "Четверг";
                scheduleThursdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleThursdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleThursdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleThursdayTitleLabel.Dock = DockStyle.Fill;
                scheduleThursdayTitleLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;

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

                var scheduleFridayTitleLabel = new Label();
                scheduleFridayTableLayoutPanel.Controls.Add(scheduleFridayTitleLabel, 0, 0);
                scheduleFridayTitleLabel.Text = "Пятница";
                scheduleFridayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleFridayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleFridayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleFridayTitleLabel.Dock = DockStyle.Fill;
                scheduleFridayTitleLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;

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

                var scheduleSaturdayTitleLabel = new Label();
                scheduleSaturdayTableLayoutPanel.Controls.Add(scheduleSaturdayTitleLabel, 0, 0);
                scheduleSaturdayTitleLabel.Text = "Суббота";
                scheduleSaturdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleSaturdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleSaturdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleSaturdayTitleLabel.Dock = DockStyle.Fill;
                scheduleSaturdayTitleLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;
            }
            else
            {
                scheduleLabel.ForeColor = SystemColors.WindowText;
            }
        }

        private void WeekComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var weekSelectionComboBox = sender as ComboBox;

            if (weekSelectionComboBox != null)
            {
                for (int i = 1; i < controlsInTableLayoutPanel.Count; i++)
                {
                    var scheduleTableLayoutPanel = controlsInTableLayoutPanel[i] as TableLayoutPanel;

                    if (scheduleTableLayoutPanel != null)
                    {
                        var numberOfLessons = DatabaseInteraction.LoadNumberOfSubjects(studentGroupId,
                                                 weekSelectionComboBox.SelectedIndex + 1, i);
                        var controlsCount = scheduleTableLayoutPanel.Controls.Count - 1;
                        scheduleTableLayoutPanel.RowCount = numberOfLessons + 2;
                        scheduleTableLayoutPanel.RowStyles.Clear();
                        scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                        scheduleTableLayoutPanel.Cursor = Cursors.Hand;

                        for (int j = controlsCount; j > 0; j--)
                        {
                            scheduleTableLayoutPanel.Controls[j].Dispose();
                        }

                        for (int j = 0; j < numberOfLessons; j++)
                        {
                            var scheduleName = DatabaseInteraction.LoadScheduleData(studentGroupId,
                                                weekSelectionComboBox.SelectedIndex + 1, i, j + 1);

                            if (scheduleName != null)
                            {
                                var scheduleNameLabel = new Label();
                                scheduleTableLayoutPanel.Controls.Add(scheduleNameLabel, 0, j + 1);
                                scheduleNameLabel.Font = new Font(fontCollection.Families[0], 10);
                                scheduleNameLabel.Text = $"{j + 1}. {scheduleName}";
                                scheduleNameLabel.ForeColor = Color.WhiteSmoke;
                                scheduleNameLabel.Dock = DockStyle.Fill;
                                scheduleNameLabel.DoubleClick += ScheduleDayOfWeekDoubleClick;
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
            }
        }

        private void ScheduleDayOfWeekDoubleClick(object sender, EventArgs e)
        {
            var weekSelectionComboBox = controlsInTableLayoutPanel.First() as ComboBox;

            if ((weekSelectionComboBox != null) && (weekSelectionComboBox.SelectedItem != null))
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

                if (dayIndex != -1)
                {
                    var cardWithDailySchedule = new CardWithDailySchedule(studentGroupId, studentId,
                                                    weekSelectionComboBox.SelectedIndex + 1, dayIndex);
                    cardWithDailySchedule.Show();
                }
            }
        }
        #endregion

        #region Раздел "Выйти"
        private void ExitLabelClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из своего аккаунта?", "Выход из аккаунта",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.SetLoginInformation(true);
                Close();
            }
        }
        #endregion

        #region Конструкторы
        public StudentFormOfElectronicDiary(int userId)
        {
            var informationAboutStudent = DatabaseInteraction.LoadStudentData(userId);

            if (informationAboutStudent != null)
            {
                studentId = int.Parse(informationAboutStudent[0]);
                studentName = informationAboutStudent[1];
                studentSurname = informationAboutStudent[2];
                studentPatronymic = informationAboutStudent[3];
                studentGroupName = informationAboutStudent[4];
                studentBirthday = informationAboutStudent[5];
                studentInstitute = informationAboutStudent[6];
                studentGroupId = Array.IndexOf(DatabaseInteraction.LoadStudyGroups(), studentGroupName) + 1;
                fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

                InitializeComponent();

                myProfileLabel.Font = new Font(fontCollection.Families[0], 12);
                academicPerformanceLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleLabel.Font = new Font(fontCollection.Families[0], 12);
                exitLabel.Font = new Font(fontCollection.Families[0], 14);
            }
        }
        #endregion
    }
}