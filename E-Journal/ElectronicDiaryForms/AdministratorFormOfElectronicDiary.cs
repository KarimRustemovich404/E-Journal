using System.Collections.Generic;
using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System;

namespace ElectronicDiary
{
    public partial class AdministratorFormOfElectronicDiary : Form
    {
        #region Поля
        int groupId;
        int typeOfWeekId;
        List<List<ComboBox>> weeklySchedule = new List<List<ComboBox>>();
        List<Control> controlsInTableLayoutPanel = new List<Control>();
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        private void CleanAdministratorFormTableLayoutPanel()
        {
            controlsInTableLayoutPanel.Clear();

            if (administratorFormTableLayoutPanel.Controls.Count > 1)
            {
                administratorFormTableLayoutPanel.Controls[1].Dispose();
            }
        }

        #region Раздел "Список групп"
        private void ListOfGroupsLabelClick(object sender, EventArgs e)
        {
            CleanAdministratorFormTableLayoutPanel();

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
                listOfStudyingGroupsTitleLabel.Font = new Font(fontCollection.Families[0], 30);
                listOfStudyingGroupsTitleLabel.ForeColor = SystemColors.WindowText;
                listOfStudyingGroupsTitleLabel.TextAlign = ContentAlignment.TopLeft;
                listOfStudyingGroupsTitleLabel.Dock = DockStyle.Fill;
                listOfStudyingGroupsTitleLabel.Margin = new Padding(0, 10, 0, 0);

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
                groupSelectionTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                groupSelectionTitleLabel.ForeColor = SystemColors.WindowText;
                groupSelectionTitleLabel.TextAlign = ContentAlignment.TopLeft;
                groupSelectionTitleLabel.Dock = DockStyle.Fill;
                groupSelectionTitleLabel.Margin = new Padding(8, 14, 0, 0);

                var groupSelectionComboBox = new ComboBox();
                groupSelectionTableLayoutPanel.Controls.Add(groupSelectionComboBox, 1, 0);
                groupSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadStudyGroups());
                groupSelectionComboBox.Font = new Font(fontCollection.Families[0], 12);
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
                listOfStudyingGroupsContentTitleLabel.Font = new Font(fontCollection.Families[0], 16);
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
                addStudyGroupButton.Font = new Font(fontCollection.Families[0], 12);
                addStudyGroupButton.ForeColor = SystemColors.WindowText;
                addStudyGroupButton.TextAlign = ContentAlignment.MiddleCenter;
                addStudyGroupButton.Dock = DockStyle.Fill;
                addStudyGroupButton.BackColor = Color.DeepSkyBlue;
                addStudyGroupButton.FlatStyle = FlatStyle.Standard;
                addStudyGroupButton.Margin = new Padding(20, 16, 4, 19);
                actionsWithGroupsTableLayoutPanel.Cursor = Cursors.Hand;
                addStudyGroupButton.Click += AddStudyGroupButtonClick;        
            }
            else
            {
                listOfGroupsLabel.ForeColor = SystemColors.WindowText;
            }
        }

        private void GroupComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var groupSelectionComboBox = sender as ComboBox;
            var listOfStudyingGroupsContentTableLayoutPanel = controlsInTableLayoutPanel[1] as TableLayoutPanel;
            var actionsWithGroupsTableLayoutPanel = controlsInTableLayoutPanel[2] as TableLayoutPanel;

            if ((groupSelectionComboBox != null) && (listOfStudyingGroupsContentTableLayoutPanel != null) &&
                (actionsWithGroupsTableLayoutPanel != null))
            {
                var studentsInGroup = DatabaseInteraction.LoadStudentsFromGroups(groupSelectionComboBox.SelectedIndex + 1, true);
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Clear();
                listOfStudyingGroupsContentTableLayoutPanel.RowCount = studentsInGroup.Length + 2;
                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

                if (actionsWithGroupsTableLayoutPanel.Controls.Count == 1)
                {
                    var addStudentToGroupButton = new Button();
                    actionsWithGroupsTableLayoutPanel.Controls.Add(addStudentToGroupButton, 0, 0);
                    addStudentToGroupButton.Text = "Добавить студента";
                    addStudentToGroupButton.Font = new Font(fontCollection.Families[0], 12);
                    addStudentToGroupButton.ForeColor = SystemColors.WindowText;
                    addStudentToGroupButton.TextAlign = ContentAlignment.MiddleCenter;
                    addStudentToGroupButton.Dock = DockStyle.Fill;
                    addStudentToGroupButton.BackColor = Color.DeepSkyBlue;
                    addStudentToGroupButton.FlatStyle = FlatStyle.Standard;
                    addStudentToGroupButton.Margin = new Padding(4, 16, 13, 19);
                    addStudentToGroupButton.Cursor = Cursors.Hand;
                    addStudentToGroupButton.Click += AddStudentToGroupButtonClick;

                    var addStudentMarkButton = new Button();
                    actionsWithGroupsTableLayoutPanel.Controls.Add(addStudentMarkButton, 1, 0);
                    addStudentMarkButton.Text = "Добавить оценку";
                    addStudentMarkButton.Font = new Font(fontCollection.Families[0], 12);
                    addStudentMarkButton.ForeColor = SystemColors.WindowText;
                    addStudentMarkButton.TextAlign = ContentAlignment.MiddleCenter;
                    addStudentMarkButton.Dock = DockStyle.Fill;
                    addStudentMarkButton.BackColor = Color.DeepSkyBlue;
                    addStudentMarkButton.FlatStyle = FlatStyle.Standard;
                    addStudentMarkButton.Margin = new Padding(13, 16, 13, 19);
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
                    studentFullNameLabel.Text = $"{studentsInGroup[i].StudentSurname} {studentsInGroup[i].StudentName} " +
                                                $"{studentsInGroup[i].StudentPatronymic}";
                    studentFullNameLabel.Font = new Font(fontCollection.Families[0], 12);
                    studentFullNameLabel.ForeColor = SystemColors.WindowText;
                    studentFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    studentFullNameLabel.Dock = DockStyle.Fill;
                    listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                }

                listOfStudyingGroupsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - (10 * studentsInGroup.Length)));
            }
        }

        private void AddStudyGroupButtonClick(object sender, EventArgs e)
        {
            var groupSelectionComboBox = controlsInTableLayoutPanel.FirstOrDefault() as ComboBox;

            if (groupSelectionComboBox != null)
            {
                var addNewStudyGroup = new AddNewStudyGroup(groupSelectionComboBox);
                addNewStudyGroup.Show();
            }
        }

        private void AddStudentMarkButtonClick(object sender, EventArgs e)
        {
            var groupSelectionComboBox = controlsInTableLayoutPanel.FirstOrDefault() as ComboBox;

            if (groupSelectionComboBox != null)
            {
                var addStudentMark = new AddStudentMark(groupSelectionComboBox.SelectedIndex + 1);
                addStudentMark.Show();
            }
        }

        private void AddStudentToGroupButtonClick(object sender, EventArgs e)
        {
            var groupSelectionComboBox = controlsInTableLayoutPanel.FirstOrDefault() as ComboBox;
            var listOfStudyingGroupsContentTableLayoutPanel = controlsInTableLayoutPanel[1] as TableLayoutPanel;

            if ((groupSelectionComboBox != null) && (listOfStudyingGroupsContentTableLayoutPanel != null))
            {
                var addStudentToGroup = new AddStudentToGroup(groupSelectionComboBox.SelectedIndex + 1, 
                                                                    listOfStudyingGroupsContentTableLayoutPanel);
                addStudentToGroup.Show();
            }
        }
        #endregion

        #region Раздел "Расписание"
        private void ScheduleLabelClick(object sender, EventArgs e)
        {
            CleanAdministratorFormTableLayoutPanel();

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
                scheduleTitleLabel.Font = new Font(fontCollection.Families[0], 30);
                scheduleTitleLabel.ForeColor = SystemColors.WindowText;
                scheduleTitleLabel.TextAlign = ContentAlignment.TopLeft;
                scheduleTitleLabel.Dock = DockStyle.Fill;
                scheduleTitleLabel.Margin = new Padding(9, 12, 0, 0);

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
                scheduleSelectionButton.Font = new Font(fontCollection.Families[0], 12);
                scheduleSelectionButton.ForeColor = SystemColors.WindowText;
                scheduleSelectionButton.TextAlign = ContentAlignment.MiddleCenter;
                scheduleSelectionButton.Dock = DockStyle.Fill;
                scheduleSelectionButton.BackColor = Color.DeepSkyBlue;
                scheduleSelectionButton.FlatStyle = FlatStyle.Standard;
                scheduleSelectionButton.Margin = new Padding(85, 7, 70, 13);
                scheduleSelectionButton.Cursor = Cursors.Hand;
                scheduleSelectionButton.Click += ScheduleSelectionButtonClick;

                var scheduleSaveButton = new Button();
                scheduleButtonsTableLayoutPanel.Controls.Add(scheduleSaveButton, 1, 0);
                scheduleSaveButton.Text = "Сохранить";
                scheduleSaveButton.Font = new Font(fontCollection.Families[0], 12);
                scheduleSaveButton.ForeColor = SystemColors.WindowText;
                scheduleSaveButton.TextAlign = ContentAlignment.MiddleCenter;
                scheduleSaveButton.Dock = DockStyle.Fill;
                scheduleSaveButton.BackColor = Color.DeepSkyBlue;
                scheduleSaveButton.FlatStyle = FlatStyle.Standard;
                scheduleSaveButton.Margin = new Padding(105, 7, 105, 13);
                scheduleSaveButton.Cursor = Cursors.Hand;
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

                var scheduleMondayTitleLabel = new Label();
                scheduleMondayTableLayoutPanel.Controls.Add(scheduleMondayTitleLabel, 0, 0);
                scheduleMondayTitleLabel.Text = "Понедельник";
                scheduleMondayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleMondayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleMondayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleMondayTitleLabel.Dock = DockStyle.Fill;

                var scheduleTuesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleTuesdayTableLayoutPanel, 3, 0);
                scheduleTuesdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleTuesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleTuesdayTableLayoutPanel.ColumnCount = 0;
                scheduleTuesdayTableLayoutPanel.RowCount = 2;
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleTuesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleTuesdayTableLayoutPanel);

                var scheduleTuesdayTitleLabel = new Label();
                scheduleTuesdayTableLayoutPanel.Controls.Add(scheduleTuesdayTitleLabel, 0, 0);
                scheduleTuesdayTitleLabel.Text = "Вторник";
                scheduleTuesdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleTuesdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleTuesdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleTuesdayTitleLabel.Dock = DockStyle.Fill;

                var scheduleWednesdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleWednesdayTableLayoutPanel, 5, 0);
                scheduleWednesdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleWednesdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleWednesdayTableLayoutPanel.ColumnCount = 0;
                scheduleWednesdayTableLayoutPanel.RowCount = 2;
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleWednesdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleWednesdayTableLayoutPanel);

                var scheduleWednesdayTitleLabel = new Label();
                scheduleWednesdayTableLayoutPanel.Controls.Add(scheduleWednesdayTitleLabel, 0, 0);
                scheduleWednesdayTitleLabel.Text = "Среда";
                scheduleWednesdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleWednesdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleWednesdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleWednesdayTitleLabel.Dock = DockStyle.Fill;

                var scheduleThursdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleThursdayTableLayoutPanel, 1, 2);
                scheduleThursdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleThursdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleThursdayTableLayoutPanel.ColumnCount = 0;
                scheduleThursdayTableLayoutPanel.RowCount = 2;
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleThursdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleThursdayTableLayoutPanel);

                var scheduleThursdayTitleLabel = new Label();
                scheduleThursdayTableLayoutPanel.Controls.Add(scheduleThursdayTitleLabel, 0, 0);
                scheduleThursdayTitleLabel.Text = "Четверг";
                scheduleThursdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleThursdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleThursdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleThursdayTitleLabel.Dock = DockStyle.Fill;

                var scheduleFridayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleFridayTableLayoutPanel, 3, 2);
                scheduleFridayTableLayoutPanel.BackColor = Color.Gray;
                scheduleFridayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleFridayTableLayoutPanel.ColumnCount = 0;
                scheduleFridayTableLayoutPanel.RowCount = 2;
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleFridayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleFridayTableLayoutPanel);

                var scheduleFridayTitleLabel = new Label();
                scheduleFridayTableLayoutPanel.Controls.Add(scheduleFridayTitleLabel, 0, 0);
                scheduleFridayTitleLabel.Text = "Пятница";
                scheduleFridayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleFridayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleFridayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleFridayTitleLabel.Dock = DockStyle.Fill;

                var scheduleSaturdayTableLayoutPanel = new TableLayoutPanel();
                scheduleContentTableLayoutPanel.Controls.Add(scheduleSaturdayTableLayoutPanel, 5, 2);
                scheduleSaturdayTableLayoutPanel.BackColor = Color.Gray;
                scheduleSaturdayTableLayoutPanel.Dock = DockStyle.Fill;
                scheduleSaturdayTableLayoutPanel.ColumnCount = 0;
                scheduleSaturdayTableLayoutPanel.RowCount = 2;
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                scheduleSaturdayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82));
                controlsInTableLayoutPanel.Add(scheduleSaturdayTableLayoutPanel);

                var scheduleSaturdayTitleLabel = new Label();
                scheduleSaturdayTableLayoutPanel.Controls.Add(scheduleSaturdayTitleLabel, 0, 0);
                scheduleSaturdayTitleLabel.Text = "Суббота";
                scheduleSaturdayTitleLabel.Font = new Font(fontCollection.Families[0], 12);
                scheduleSaturdayTitleLabel.ForeColor = Color.WhiteSmoke;
                scheduleSaturdayTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                scheduleSaturdayTitleLabel.Dock = DockStyle.Fill;
            }
            else
            {
                scheduleLabel.ForeColor = SystemColors.WindowText;
            }
        }

        private void ScheduleSelectionButtonClick(object sender, EventArgs e)
        {
            var scheduleSelectionForm = new ScheduleSelectionForm(controlsInTableLayoutPanel);
            scheduleSelectionForm.Owner = this;
            scheduleSelectionForm.Show();
        }

        private void ScheduleSaveButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < weeklySchedule.Count; i++)
            {
                for (int j = 0; j < weeklySchedule[i].Count; j++)
                {
                    var subjectComboBox = weeklySchedule[i][j];

                    DatabaseInteraction.SaveStudyGroupSchedule(groupId, 
                    subjectComboBox.SelectedIndex != subjectComboBox.Items.Count - 1 ? subjectComboBox.SelectedIndex + 1 : 0,
                    typeOfWeekId, i + 1, j + 1);

                }
            }

            MessageBox.Show("Расписание успешно сохранено", "Сохранение расписания", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Метод, который возвращает данные из формы ScheduleSelectionForm.
        /// </summary>
        /// <param name="typeOfWeekId"> Идентификатор типа недели. </param>
        /// <param name="groupId"> Идентификатор группы. </param>
        /// <param name="weeklySchedule"> Расписание группы. </param>
        public void DownloadScheduleData(int typeOfWeekId, int groupId, List<List<ComboBox>> weeklySchedule)
        {
            this.typeOfWeekId = typeOfWeekId;
            this.groupId = groupId;
            this.weeklySchedule = weeklySchedule;
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
        public AdministratorFormOfElectronicDiary()
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            listOfGroupsLabel.Font = new Font(fontCollection.Families[0], 12);
            scheduleLabel.Font = new Font(fontCollection.Families[0], 12);
            exitLabel.Font = new Font(fontCollection.Families[0], 14);
        }
        #endregion
    }
}