using System.Collections.Generic;
using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class ScheduleSelectionForm : Form
    {
        #region Поля
        int groupId;
        int typeOfWeekId;
        List<Control> tablesWithSchedulesOfDays;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region События
        private void ScheduleLoadButtonClick(object sender, EventArgs e)
        {
            if ((weekTypeSelectionComboBox.SelectedItem != null) && (groupSelectionComboBox.SelectedItem != null))
            {
                var weeklySchedule = new List<List<ComboBox>>();

                for (int i = 0; i < tablesWithSchedulesOfDays.Count; i++)
                {
                    var scheduleTableLayoutPanel = tablesWithSchedulesOfDays[i] as TableLayoutPanel;

                    if (scheduleTableLayoutPanel != null)
                    {
                        var daySchedule = new List<ComboBox>();
                        scheduleTableLayoutPanel.RowCount = 7;
                        scheduleTableLayoutPanel.RowStyles.Clear();
                        scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));

                        for (int j = scheduleTableLayoutPanel.Controls.Count - 1; j > 0; j--)
                        {
                            scheduleTableLayoutPanel.Controls[j].Dispose();
                        }

                        for (int j = 0; j < 5; j++)
                        {
                            var scheduleName = DatabaseInteraction.LoadScheduleData(groupSelectionComboBox.SelectedIndex + 1,
                                                                    weekTypeSelectionComboBox.SelectedIndex + 1, i + 1, j + 1);

                                var scheduleNameComboBox = new ComboBox();
                                scheduleTableLayoutPanel.Controls.Add(scheduleNameComboBox, 0, j + 1);
                                scheduleNameComboBox.Items.AddRange(DatabaseInteraction.LoadSubjects());
                                scheduleNameComboBox.Items.Add(String.Empty);
                                scheduleNameComboBox.FlatStyle = FlatStyle.Popup;
                                scheduleNameComboBox.BackColor = SystemColors.ControlLight;
                                scheduleNameComboBox.TabStop = false;
                                scheduleNameComboBox.SelectedItem = scheduleName != null ? scheduleName : String.Empty;
                                scheduleNameComboBox.Font = new Font(fontCollection.Families[0], 10);
                                scheduleNameComboBox.ForeColor = SystemColors.WindowText;
                                scheduleNameComboBox.Dock = DockStyle.Fill;
                                scheduleNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                                scheduleNameComboBox.Margin = new Padding(10, 11, 10, 11);
                                scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14));
                                daySchedule.Add(scheduleNameComboBox);
                        }

                        weeklySchedule.Add(daySchedule);
                        scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12));
                    }
                }

                typeOfWeekId = weekTypeSelectionComboBox.SelectedIndex + 1;
                groupId = groupSelectionComboBox.SelectedIndex + 1;
                var mainForm = Owner as AdministratorFormOfElectronicDiary;
                mainForm.DownloadScheduleData(typeOfWeekId, groupId, weeklySchedule);
                Close();
            }
            else
            {
                groupSelectionComboBox.BackColor = Color.LightCoral;
                weekTypeSelectionComboBox.BackColor = Color.LightCoral;
            }
        }

        private void ControlsWithDataEnter(object sender, EventArgs e)
        {
            groupSelectionComboBox.BackColor = SystemColors.Window;
            weekTypeSelectionComboBox.BackColor = SystemColors.Window;
        }

        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            groupSelectionComboBox.BackColor = SystemColors.Window;
            weekTypeSelectionComboBox.BackColor = SystemColors.Window;
        }
        #endregion

        #region Конструкторы
        public ScheduleSelectionForm(List<Control> tablesWithSchedulesOfDays)
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            this.tablesWithSchedulesOfDays = tablesWithSchedulesOfDays;
            groupSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadStudyGroups());
            weekTypeSelectionComboBox.Items.AddRange(DatabaseInteraction.LoadWeeksTypes());

            groupNameTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            weekTypeTitleLabel.Font = new Font(fontCollection.Families[0], 14);
            groupSelectionComboBox.Font = new Font(fontCollection.Families[0], 14);
            weekTypeSelectionComboBox.Font = new Font(fontCollection.Families[0], 14);
            scheduleLoadButton.Font = new Font(fontCollection.Families[0], 14);
        }
        #endregion
    }
}
