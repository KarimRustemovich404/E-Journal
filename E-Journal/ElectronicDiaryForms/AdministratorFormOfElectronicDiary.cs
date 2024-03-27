using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ElectronicDiary.Database;

namespace ElectronicDiary
{
    public partial class AdministratorFormOfElectronicDiary : Form
    {
        #region Поля
        private int typeOfWeekId;
        private int groupId;
        private List<List<ComboBox>> weeklySchedule;
        private List<Control> controlsInTableLayoutPanel = new List<Control>();

        #endregion

        #region Раздел "Список групп"
        /// <summary>
        /// Метод, который обрабатывает нажатие на элемент listOfGroupsLabel.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ListOfGroupsLabelClick(object sender, EventArgs e)
        {
            controlsInTableLayoutPanel.Clear();

            if (administratorFormTableLayoutPanel.Controls.Count > 1)
            {
                administratorFormTableLayoutPanel.Controls[1].Dispose();
            }

            if (listOfGroupsLabel.ForeColor == SystemColors.WindowText)
            {
                listOfGroupsLabel.ForeColor = Color.DeepSkyBlue;
                scheduleLabel.ForeColor = SystemColors.WindowText;

                var listOfStudyingGroupsTitleTableLayoutPanel = new TableLayoutPanel();
                administratorFormTableLayoutPanel.Controls.Add(listOfStudyingGroupsTitleTableLayoutPanel, 1, 0);
                listOfStudyingGroupsTitleTableLayoutPanel.Dock = DockStyle.Fill;
                listOfStudyingGroupsTitleTableLayoutPanel.RowCount = 4;
                listOfStudyingGroupsTitleTableLayoutPanel.ColumnCount = 3;
                listOfStudyingGroupsTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12));
                listOfStudyingGroupsTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                listOfStudyingGroupsTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 63));
                listOfStudyingGroupsTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                listOfStudyingGroupsTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
                listOfStudyingGroupsTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88));
                listOfStudyingGroupsTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));

                var listOfStudyingGroupsTitleLabel = new Label();
                listOfStudyingGroupsTitleTableLayoutPanel.Controls.Add(listOfStudyingGroupsTitleLabel, 1, 0);
                listOfStudyingGroupsTitleLabel.Text = "Список учебных групп";
                listOfStudyingGroupsTitleLabel.Font = new Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
                listOfStudyingGroupsTitleLabel.ForeColor = SystemColors.WindowText;
                listOfStudyingGroupsTitleLabel.TextAlign = ContentAlignment.TopLeft;
                listOfStudyingGroupsTitleLabel.Dock = DockStyle.Fill;
                listOfStudyingGroupsTitleLabel.Margin = new Padding(0, 13, 0, 0);

                var groupSelectionTableLayoutPanel = new TableLayoutPanel();
                listOfStudyingGroupsTitleTableLayoutPanel.Controls.Add(groupSelectionTableLayoutPanel, 1, 1);
                groupSelectionTableLayoutPanel.Dock = DockStyle.Fill;
                groupSelectionTableLayoutPanel.RowCount = 1;
                groupSelectionTableLayoutPanel.ColumnCount = 3;
                groupSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37));
                groupSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                groupSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));

                var groupSelectionTitleLabel = new Label();
                groupSelectionTableLayoutPanel.Controls.Add(groupSelectionTitleLabel, 0, 0);
                groupSelectionTitleLabel.Text = "Выберите учебную группу:";
                groupSelectionTitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                groupSelectionTitleLabel.ForeColor = SystemColors.WindowText;
                groupSelectionTitleLabel.TextAlign = ContentAlignment.TopLeft;
                groupSelectionTitleLabel.Dock = DockStyle.Fill;
                groupSelectionTitleLabel.Margin = new Padding(12, 14, 0, 0);

                var groupSelectionComboBox = new ComboBox();
                groupSelectionTableLayoutPanel.Controls.Add(groupSelectionComboBox, 1, 0);
                groupSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingStudyGroups().ToArray());
                groupSelectionComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                groupSelectionComboBox.ForeColor = SystemColors.WindowText;
                groupSelectionComboBox.Dock = DockStyle.Fill;
                groupSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                groupSelectionComboBox.Margin = new Padding(0, 12, 0, 0);
                groupSelectionComboBox.Cursor = Cursors.Hand;
                groupSelectionComboBox.SelectedIndexChanged += GroupComboBoxSelectedIndexChanged;
                controlsInTableLayoutPanel.Add(groupSelectionComboBox);

                var listOfStudyingGroupsContentTableLayoutPanel = new TableLayoutPanel();
                listOfStudyingGroupsTitleTableLayoutPanel.Controls.Add(listOfStudyingGroupsContentTableLayoutPanel, 1, 2);
                listOfStudyingGroupsContentTableLayoutPanel.Dock = DockStyle.Fill;
                listOfStudyingGroupsContentTableLayoutPanel.RowCount = 2;
                listOfStudyingGroupsContentTableLayoutPanel.ColumnCount = 1;
                listOfStudyingGroupsContentTableLayoutPanel.BackColor = SystemColors.Window;
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85));
                controlsInTableLayoutPanel.Add(listOfStudyingGroupsContentTableLayoutPanel);

                var listOfStudyingGroupsContentTitleLabel = new Label();
                listOfStudyingGroupsContentTableLayoutPanel.Controls.Add(listOfStudyingGroupsContentTitleLabel, 0, 0);
                listOfStudyingGroupsContentTitleLabel.Text = "ФИО студента";
                listOfStudyingGroupsContentTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                listOfStudyingGroupsContentTitleLabel.ForeColor = SystemColors.WindowText;
                listOfStudyingGroupsContentTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                listOfStudyingGroupsContentTitleLabel.Dock = DockStyle.Fill;

                var actionsWithGroupsTableLayoutPanel = new TableLayoutPanel();
                listOfStudyingGroupsTitleTableLayoutPanel.Controls.Add(actionsWithGroupsTableLayoutPanel, 1, 3);
                actionsWithGroupsTableLayoutPanel.Dock = DockStyle.Fill;
                actionsWithGroupsTableLayoutPanel.RowCount = 1;
                actionsWithGroupsTableLayoutPanel.ColumnCount = 3;
                actionsWithGroupsTableLayoutPanel.BackColor = SystemColors.ControlLight;
                actionsWithGroupsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                actionsWithGroupsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                actionsWithGroupsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                controlsInTableLayoutPanel.Add(actionsWithGroupsTableLayoutPanel);

                var addStudyGroupButton = new Button();
                actionsWithGroupsTableLayoutPanel.Controls.Add(addStudyGroupButton, 2, 0);
                addStudyGroupButton.Text = "Добавить группу";
                addStudyGroupButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                addStudyGroupButton.ForeColor = SystemColors.WindowText;
                addStudyGroupButton.TextAlign = ContentAlignment.MiddleCenter;
                addStudyGroupButton.Dock = DockStyle.Fill;
                addStudyGroupButton.BackColor = Color.DeepSkyBlue;
                addStudyGroupButton.FlatStyle = FlatStyle.Flat;
                addStudyGroupButton.Margin = new Padding(16, 23, 13, 27);
                addStudyGroupButton.FlatAppearance.BorderSize = 0;
                actionsWithGroupsTableLayoutPanel.Cursor = Cursors.Hand;
                addStudyGroupButton.Click += AddStudyGroupButtonClick;        
            }
            else
            {
                listOfGroupsLabel.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает изменения в groupSelectionComboBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void GroupComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var groupSelectionComboBox = sender as ComboBox;
            var listOfStudyingGroupsContentTableLayoutPanel = controlsInTableLayoutPanel[1] as TableLayoutPanel;
            var actionsWithGroupsTableLayoutPanel = controlsInTableLayoutPanel[2] as TableLayoutPanel;
            Student[] studentsInGroup = ClassForWorkWithDatabase.LoadStudentsFromGroup(groupSelectionComboBox.SelectedIndex + 1);
            listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Clear();
            listOfStudyingGroupsContentTableLayoutPanel.RowCount = studentsInGroup.Length + 2;
            listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

            if (actionsWithGroupsTableLayoutPanel.Controls.Count == 1)
            {
                var addStudentToGroupButton = new Button();
                actionsWithGroupsTableLayoutPanel.Controls.Add(addStudentToGroupButton, 0, 0);
                addStudentToGroupButton.Text = "Добавить студента";
                addStudentToGroupButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                addStudentToGroupButton.ForeColor = SystemColors.WindowText;
                addStudentToGroupButton.TextAlign = ContentAlignment.MiddleCenter;
                addStudentToGroupButton.Dock = DockStyle.Fill;
                addStudentToGroupButton.BackColor = Color.DeepSkyBlue;
                addStudentToGroupButton.FlatStyle = FlatStyle.Flat;
                addStudentToGroupButton.FlatAppearance.BorderSize = 0;
                addStudentToGroupButton.Margin = new Padding(16, 23, 13, 27);
                addStudentToGroupButton.Cursor = Cursors.Hand;
                addStudentToGroupButton.Click += AddStudentToGroupButtonClick;

                var addStudentMarkButton = new Button();
                actionsWithGroupsTableLayoutPanel.Controls.Add(addStudentMarkButton, 1, 0);
                addStudentMarkButton.Text = "Добавить оценку";
                addStudentMarkButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                addStudentMarkButton.ForeColor = SystemColors.WindowText;
                addStudentMarkButton.TextAlign = ContentAlignment.MiddleCenter;
                addStudentMarkButton.Dock = DockStyle.Fill;
                addStudentMarkButton.BackColor = Color.DeepSkyBlue;
                addStudentMarkButton.FlatStyle = FlatStyle.Flat;
                addStudentMarkButton.FlatAppearance.BorderSize = 0;
                addStudentMarkButton.Margin = new Padding(16, 23, 13, 27);
                addStudentMarkButton.Cursor = Cursors.Hand;
                addStudentMarkButton.Click += AddStudentMarkButtonClick;
            }

            for (int i = listOfStudyingGroupsContentTableLayoutPanel.Controls.Count - 1; i > 0; i--)
            {
                listOfStudyingGroupsContentTableLayoutPanel.Controls[i].Dispose();
            }

            for (int i = 0; i < studentsInGroup.Length; i++) 
            {
                var studentFullNameLabel = new Label();
                listOfStudyingGroupsContentTableLayoutPanel.Controls.Add(studentFullNameLabel, 0, i + 1);
                studentFullNameLabel.Text = $"{studentsInGroup[i].StudentSurname} {studentsInGroup[i].StudentName} {studentsInGroup[i].StudentPatronymic}";
                studentFullNameLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                studentFullNameLabel.ForeColor = SystemColors.WindowText;
                studentFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                studentFullNameLabel.Dock = DockStyle.Fill;
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8));
            }

            listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - (8 * studentsInGroup.Length)));
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Добавить группу".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddStudyGroupButtonClick(object sender, EventArgs e)
        {
            AddNewStudyGroup addNewStudyGroup = new AddNewStudyGroup(controlsInTableLayoutPanel[0] as ComboBox);
            addNewStudyGroup.Show();            
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Добавить оценку".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddStudentMarkButtonClick(object sender, EventArgs e)
        {
            var groupSelectionComboBox = controlsInTableLayoutPanel[0] as ComboBox;
            AddStudentMark addStudentMark = new AddStudentMark(groupSelectionComboBox.SelectedIndex + 1);
            addStudentMark.Show();
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Добавить студента".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddStudentToGroupButtonClick(object sender, EventArgs e)
        {
            var groupSelectionComboBox = controlsInTableLayoutPanel[0] as ComboBox;
            AddStudentToGroup addStudentToGroup = new AddStudentToGroup(groupSelectionComboBox.SelectedIndex + 1, controlsInTableLayoutPanel[1] as TableLayoutPanel);
            addStudentToGroup.Show();
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

            if (administratorFormTableLayoutPanel.Controls.Count > 1)
            {
                administratorFormTableLayoutPanel.Controls[1].Dispose();
            }

            if (scheduleLabel.ForeColor == SystemColors.WindowText)
            {
                scheduleLabel.ForeColor = Color.DeepSkyBlue;
                listOfGroupsLabel.ForeColor = SystemColors.WindowText;

                var scheduleTitleTableLayoutPanel = new TableLayoutPanel();
                administratorFormTableLayoutPanel.Controls.Add(scheduleTitleTableLayoutPanel, 1, 0);
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
                scheduleTitleLabel.Margin = new Padding(9, 12, 0, 0);

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

                var scheduleButtonsTableLayoutPanel = new TableLayoutPanel();
                scheduleTitleTableLayoutPanel.Controls.Add(scheduleButtonsTableLayoutPanel, 0, 2);
                scheduleButtonsTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleButtonsTableLayoutPanel.ColumnCount = 2;
                scheduleButtonsTableLayoutPanel.RowCount = 1;
                scheduleButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                scheduleButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                var scheduleSelectionButton = new Button();
                scheduleButtonsTableLayoutPanel.Controls.Add(scheduleSelectionButton, 0, 0);
                scheduleSelectionButton.Text = "Выбрать расписание";
                scheduleSelectionButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleSelectionButton.ForeColor = SystemColors.WindowText;
                scheduleSelectionButton.TextAlign = ContentAlignment.MiddleCenter;
                scheduleSelectionButton.Dock = DockStyle.Fill;
                scheduleSelectionButton.BackColor = Color.DeepSkyBlue;
                scheduleSelectionButton.FlatStyle = FlatStyle.Flat;
                scheduleSelectionButton.Margin = new Padding(95, 12, 75, 15);
                scheduleSelectionButton.FlatAppearance.BorderSize = 0;
                scheduleSelectionButton.Click += ScheduleSelectionButtonClick;

                var scheduleSaveButton = new Button();
                scheduleButtonsTableLayoutPanel.Controls.Add(scheduleSaveButton, 1, 0);
                scheduleSaveButton.Text = "Сохранить";
                scheduleSaveButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleSaveButton.ForeColor = SystemColors.WindowText;
                scheduleSaveButton.TextAlign = ContentAlignment.MiddleCenter;
                scheduleSaveButton.Dock = DockStyle.Fill;
                scheduleSaveButton.BackColor = Color.DeepSkyBlue;
                scheduleSaveButton.FlatStyle = FlatStyle.Flat;
                scheduleSaveButton.Margin = new Padding(105, 12, 105, 15);
                scheduleSaveButton.FlatAppearance.BorderSize = 0;
                scheduleSaveButton.Click += ScheduleSaveButtonClick;

                var scheduleMondayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleMondayTableLayoutPanel, 1, 0);
                scheduleMondayTableLayoutPanel.BackColor = Color.Gray;
                scheduleMondayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleMondayTableLayoutPanel.ColumnCount = 0;
                scheduleMondayTableLayoutPanel.RowCount = 2;
                scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleMondayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleMondayTableLayoutPanel);

                var scheduleMondayTitleLable = new Label();
                scheduleMondayTableLayoutPanel.Controls.Add(scheduleMondayTitleLable, 0, 0);
                scheduleMondayTitleLable.Text = "Понедельник";
                scheduleMondayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleMondayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleMondayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleMondayTitleLable.Dock = DockStyle.Fill;

                var scheduleTuesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleTuesdayTableLayoutPanel, 3, 0);
                scheduleTuesdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleTuesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleTuesdayTableLayoutPanel.ColumnCount = 0;
                scheduleTuesdayTableLayoutPanel.RowCount = 2;
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleTuesdayTableLayoutPanel);

                var scheduleTuesdayTitleLable = new Label();
                scheduleTuesdayTableLayoutPanel.Controls.Add(scheduleTuesdayTitleLable, 0, 0);
                scheduleTuesdayTitleLable.Text = "Вторник";
                scheduleTuesdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleTuesdayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleTuesdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleTuesdayTitleLable.Dock = DockStyle.Fill;

                var scheduleWednesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleWednesdayTableLayoutPanel, 5, 0);
                scheduleWednesdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleWednesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleWednesdayTableLayoutPanel.ColumnCount = 0;
                scheduleWednesdayTableLayoutPanel.RowCount = 2;
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleWednesdayTableLayoutPanel);

                var scheduleWednesdayTitleLable = new Label();
                scheduleWednesdayTableLayoutPanel.Controls.Add(scheduleWednesdayTitleLable, 0, 0);
                scheduleWednesdayTitleLable.Text = "Среда";
                scheduleWednesdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleWednesdayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleWednesdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleWednesdayTitleLable.Dock = DockStyle.Fill;

                var scheduleThursdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleThursdayTableLayoutPanel, 1, 2);
                scheduleThursdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleThursdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleThursdayTableLayoutPanel.ColumnCount = 0;
                scheduleThursdayTableLayoutPanel.RowCount = 2;
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleThursdayTableLayoutPanel);

                var scheduleThursdayTitleLable = new Label();
                scheduleThursdayTableLayoutPanel.Controls.Add(scheduleThursdayTitleLable, 0, 0);
                scheduleThursdayTitleLable.Text = "Четверг";
                scheduleThursdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleThursdayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleThursdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleThursdayTitleLable.Dock = DockStyle.Fill;

                var scheduleFridayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleFridayTableLayoutPanel, 3, 2);
                scheduleFridayTableLayoutPanel.BackColor = Color.Gray;
                scheduleFridayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleFridayTableLayoutPanel.ColumnCount = 0;
                scheduleFridayTableLayoutPanel.RowCount = 2;
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleFridayTableLayoutPanel);

                var scheduleFridayTitleLable = new Label();
                scheduleFridayTableLayoutPanel.Controls.Add(scheduleFridayTitleLable, 0, 0);
                scheduleFridayTitleLable.Text = "Пятница";
                scheduleFridayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                scheduleFridayTitleLable.ForeColor = Color.WhiteSmoke;
                scheduleFridayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                scheduleFridayTitleLable.Dock = DockStyle.Fill;

                var scheduleSaturdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleSaturdayTableLayoutPanel, 5, 2);
                scheduleSaturdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleSaturdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleSaturdayTableLayoutPanel.ColumnCount = 0;
                scheduleSaturdayTableLayoutPanel.RowCount = 2;
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleSaturdayTableLayoutPanel);

                var schedulуSaturdayTitleLable = new Label();
                scheduleSaturdayTableLayoutPanel.Controls.Add(schedulуSaturdayTitleLable, 0, 0);
                schedulуSaturdayTitleLable.Text = "Суббота";
                schedulуSaturdayTitleLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                schedulуSaturdayTitleLable.ForeColor = Color.WhiteSmoke;
                schedulуSaturdayTitleLable.TextAlign = ContentAlignment.MiddleCenter;
                schedulуSaturdayTitleLable.Dock = DockStyle.Fill;
            }
            else
            {
                scheduleLabel.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Выбрать расписание".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ScheduleSelectionButtonClick(object sender, EventArgs e)
        {
            ScheduleSelectionForm scheduleSelectionForm = new ScheduleSelectionForm(controlsInTableLayoutPanel);
            scheduleSelectionForm.Owner = this;
            scheduleSelectionForm.Show();
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ScheduleSaveButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < weeklySchedule.Count; i++)
            {
                for (int j = 0; j < weeklySchedule[i].Count; j++)
                {
                    var subjectComboBox = weeklySchedule[i][j] as ComboBox;

                    ClassForWorkWithDatabase.SaveScedule(groupId, subjectComboBox.SelectedIndex != subjectComboBox.Items.Count - 1 ? subjectComboBox.SelectedIndex + 1 : 0, typeOfWeekId, i + 1, j + 1);
                }
            }
        }

        /// <summary>
        /// Метод, который возвращает данные из формы ScheduleSelectionForm.
        /// </summary>
        /// <param name="typeOfWeekId"> Id типа недели. </param>
        /// <param name="groupId"> Id группы. </param>
        /// <param name="weeklySchedule"> Расписание группы. </param>
        public void DownloadScheduleData(int typeOfWeekId, int groupId, List<List<ComboBox>> weeklySchedule)
        {
            this.typeOfWeekId = typeOfWeekId;
            this.groupId = groupId;
            this.weeklySchedule = weeklySchedule;
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
        public AdministratorFormOfElectronicDiary()
        {
            InitializeComponent();
        }
        #endregion
    }
}