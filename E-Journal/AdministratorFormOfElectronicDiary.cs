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
    public partial class AdministratorFormOfElectronicDiary : Form
    {
        public AdministratorFormOfElectronicDiary()
        {
            InitializeComponent();

            MaximizeBox = false;
        }

        #region Поля
        private TabControl tabControl;
        private Button btnSave;
        private string studentId;
        private string[] adminSubjects;
        private List<List<string>> adminSchedule;
        private List<Control> controlsInTableLayoutPanel = new List<Control>();
        #endregion

        #region Раздел "Список групп"

        private void ListOfGroupsLabelClick(object sender, EventArgs e)
        {
            if (listOfGroupsLabel.ForeColor == SystemColors.WindowText)
            {
                listOfGroupsLabel.ForeColor = Color.DeepSkyBlue;
                listOfGroupsLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);

                if (adminFormTableLayoutPanel.Controls.Count > 1)
                {
                    adminFormTableLayoutPanel.Controls[1].Dispose();
                }

                controlsInTableLayoutPanel.Clear();

                var listOfStudyingGroupsLabel = new Label();
                adminFormTableLayoutPanel.Controls.Add(listOfStudyingGroupsLabel, 0, 0);
                listOfStudyingGroupsLabel.Text = "Список учебных групп";
                listOfStudyingGroupsLabel.Font = new Font("Arial", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
                listOfStudyingGroupsLabel.ForeColor = SystemColors.WindowText;
                listOfStudyingGroupsLabel.TextAlign = ContentAlignment.TopLeft;
                listOfStudyingGroupsLabel.Dock = DockStyle.Fill;
                listOfStudyingGroupsLabel.Margin = new Padding(20, 18, 0, 0);
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

        #region Раздел "Расписание"
        private void ScheduleLabelClick(object sender, EventArgs e)
        {
            if (scheduleLabel.ForeColor == SystemColors.WindowText)
            {
                scheduleLabel.ForeColor = Color.DeepSkyBlue;
                scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);

                if (adminFormTableLayoutPanel.Controls.Count > 1)
                {
                    adminFormTableLayoutPanel.Controls[1].Dispose();
                }

                controlsInTableLayoutPanel.Clear();

                var scheduleTitleTableLayoutPanel = new TableLayoutPanel();
                adminFormTableLayoutPanel.Controls.Add(scheduleTitleTableLayoutPanel, 1, 0);
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

            //var cardWithDailySchedule = new CardWithDailySchedule(dateOfDay, studentId, adminSchedule[dayIndex]);
            //cardWithDailySchedule.Show();
        }

        private void SaveSchedule(object sender, EventArgs e)
        {
            tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Click += SaveButtonClick;

            this.Controls.Add(tabControl);
            this.Controls.Add(btnSave);
        }

        private void SaveButtonClick (object sender, EventArgs e)
        {
            MessageBox.Show("Расписание сохранено успешно.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

    }
}
