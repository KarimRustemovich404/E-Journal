using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ElectronicDiary.Database;

namespace ElectronicDiary
{
    public partial class ScheduleSelectionForm : Form
    {
        #region Поля
        private int typeOfWeekId;
        private int groupId;
        private List<Control> tablesWithSchedulesOfDays;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает нажатие кнопку "Загрузить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ScheduleLoadButtonClick(object sender, EventArgs e)
        {
            if ((weekTypeSelectionComboBox.SelectedItem != null) && (groupSelectionComboBox.SelectedItem != null))
            {
                List<List<ComboBox>> weeklySchedule = new List<List<ComboBox>>();

                for (int i = 0; i < tablesWithSchedulesOfDays.Count; i++)
                {
                    var scheduleTableLayoutPanel = tablesWithSchedulesOfDays[i] as TableLayoutPanel;
                    scheduleTableLayoutPanel.RowCount = 7;
                    scheduleTableLayoutPanel.RowStyles.Clear();
                    int controlsCount = scheduleTableLayoutPanel.Controls.Count - 1;
                    scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
                    List<ComboBox> daySchedule = new List<ComboBox>();

                    for (int j = controlsCount; j > 0; j--)
                    {
                        scheduleTableLayoutPanel.Controls[j].Dispose();
                    }

                    for (int j = 0; j < 5; j++)
                    {
                        string scheduleName = ClassForWorkWithDatabase.LoadingScheduleData(groupSelectionComboBox.SelectedIndex + 1, i + 1, weekTypeSelectionComboBox.SelectedIndex + 1, j + 1);

                        var sheduleNameComboBox = new ComboBox();
                        scheduleTableLayoutPanel.Controls.Add(sheduleNameComboBox, 0, j + 1);
                        sheduleNameComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadStudentSubjects());
                        sheduleNameComboBox.Items.Add(String.Empty);
                        sheduleNameComboBox.FlatStyle = FlatStyle.Popup;
                        sheduleNameComboBox.BackColor = SystemColors.ControlLight;
                        sheduleNameComboBox.TabStop = false;
                        sheduleNameComboBox.SelectedItem = scheduleName != null ? scheduleName : String.Empty;
                        sheduleNameComboBox.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        sheduleNameComboBox.ForeColor = SystemColors.WindowText;
                        sheduleNameComboBox.Dock = DockStyle.Fill;
                        sheduleNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        sheduleNameComboBox.Margin = new Padding(10, 11, 10, 11);
                        scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14));
                        daySchedule.Add(sheduleNameComboBox);
                    }

                    weeklySchedule.Add(daySchedule);
                    scheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12));
                }

                typeOfWeekId = weekTypeSelectionComboBox.SelectedIndex + 1;
                groupId = groupSelectionComboBox.SelectedIndex + 1;
                AdministratorFormOfElectronicDiary mainForm = Owner as AdministratorFormOfElectronicDiary;
                mainForm.DownloadScheduleData(typeOfWeekId, groupId, weeklySchedule);
                Close();
            }
            else
            {
                groupSelectionComboBox.BackColor = Color.LightCoral;
                weekTypeSelectionComboBox.BackColor = Color.LightCoral;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает вход в элементы управления с данными.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ControlsWithDataEnter(object sender, EventArgs e)
        {
            groupSelectionComboBox.BackColor = SystemColors.Window;
            weekTypeSelectionComboBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на все элементы формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
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
            InitializeComponent();

            this.tablesWithSchedulesOfDays = tablesWithSchedulesOfDays;
            groupSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingStudyGroups().ToArray());
            weekTypeSelectionComboBox.Items.AddRange(ClassForWorkWithDatabase.LoadingTypesOfWeek());
        }
        #endregion
    }
}
