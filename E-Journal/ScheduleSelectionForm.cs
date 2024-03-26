using ElectronicDiary;
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
    public partial class ScheduleSelectionForm : Form
    {
        private int typeOfWeekId;
        private int groupId;
        private List<Control> tablesWithSchedulesOfDays;

        public ScheduleSelectionForm(List<Control> tablesWithSchedulesOfDays)
        {
            InitializeComponent();

            this.tablesWithSchedulesOfDays = tablesWithSchedulesOfDays;
            groupSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingStudyGroups().ToArray());
            weekTypeSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingTypesOfWeek().ToArray());
        }

        private void ScheduleLoadButtonClick(object sender, EventArgs e)
        {
            List<List<ComboBox>> weeklySchedule = new List<List<ComboBox>>();

            for (int i = 0; i < tablesWithSchedulesOfDays.Count; i++)
            {
                int numberOfLessons = ClassForWorkWithDatabase.LoadingNumberOfPairs(groupSelectionComboBox.SelectedIndex + 1, i + 1, weekTypeSelectionComboBox.SelectedIndex + 1);
                var scheduleTableLayoutPanel = tablesWithSchedulesOfDays[i] as TableLayoutPanel;
                scheduleTableLayoutPanel.RowCount = numberOfLessons + 2;
                scheduleTableLayoutPanel.RowStyles.Clear();
                int controlsCount = scheduleTableLayoutPanel.Controls.Count - 1;
                scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23));
                List<ComboBox> daySchedule = new List<ComboBox>();

                for (int j = controlsCount; j > 0; j--)
                {
                    scheduleTableLayoutPanel.Controls[j].Dispose();
                }

                for (int j = 0; j < 5; j++)
                {
                    string scheduleName = ClassForWorkWithDatabase.LoadingScheduleData(groupSelectionComboBox.SelectedIndex + 1, i + 1, weekTypeSelectionComboBox.SelectedIndex + 1, j + 1);

                    var sheduleNameCombBox = new ComboBox();
                    scheduleTableLayoutPanel.Controls.Add(sheduleNameCombBox, 0, j + 1);
                    sheduleNameCombBox.Items.AddRange(ClassForWorkWithDatabase.LoadStudentSubjects());
                    sheduleNameCombBox.SelectedItem = scheduleName != null ? scheduleName : String.Empty;
                    sheduleNameCombBox.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
                    sheduleNameCombBox.ForeColor = SystemColors.WindowText;
                    sheduleNameCombBox.Dock = DockStyle.Fill;
                    sheduleNameCombBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    sheduleNameCombBox.Margin = new Padding(0, 8, 0, 0);
                    scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11));
                    daySchedule.Add(sheduleNameCombBox);
                }

                weeklySchedule.Add(daySchedule);
                scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (77 - (11 * numberOfLessons))));
            }

            typeOfWeekId = weekTypeSelectionComboBox.SelectedIndex + 1;
            groupId = groupSelectionComboBox.SelectedIndex + 1;
            AdministratorFormOfElectronicDiary mainForm = Owner as AdministratorFormOfElectronicDiary;
            mainForm.DownloadScheduleData(typeOfWeekId, groupId, weeklySchedule);
        }
    }
}
