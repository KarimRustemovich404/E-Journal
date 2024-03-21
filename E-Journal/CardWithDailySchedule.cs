using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithDatabase;

namespace E_Journal
{
    public partial class CardWithDailySchedule : Form
    {
        #region Поля
        private int studentId;
        private List<string> studentDaySchedule;
        private List<string> studentSubjects;
        private Control[] controlsOfTableLayoutPanel;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает закрытие формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void CardWithDailySchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < studentDaySchedule.Count; i++)
            {
                if (studentDaySchedule[i] != String.Empty)
                {
                    int subjectIndex = studentSubjects.IndexOf(studentDaySchedule[i]) + 1;
                    ClassForWorkWithDatabase.SaveStudentNote(studentId, subjectIndex, controlsOfTableLayoutPanel[i].Text);
                }
            }
        }
        #endregion

        #region Конструкторы
        public CardWithDailySchedule(string dateOfDay, string studentId, List<string> daySchedule)
        {
            InitializeComponent();

            this.studentId = int.Parse(studentId);
            studentDaySchedule = daySchedule;
            studentSubjects = ClassForWorkWithDatabase.LoadStudentSubjects().ToList();
            Text = $"Расписание {CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.ParseExact(dateOfDay, "dd.MM.yyyy", null).DayOfWeek)}";
            controlsOfTableLayoutPanel = new Control[daySchedule.Count];

            var dailyScheduleTitleLabel = new Label();
            dayScheduleTitleTableLayoutPanel.Controls.Add(dailyScheduleTitleLabel, 0, 0);
            dailyScheduleTitleLabel.Text = $"Карточка дня {dateOfDay}";
            dailyScheduleTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dailyScheduleTitleLabel.ForeColor = SystemColors.WindowText;
            dailyScheduleTitleLabel.TextAlign = ContentAlignment.TopLeft;
            dailyScheduleTitleLabel.Margin = new Padding(18, 15, 0, 0);
            dailyScheduleTitleLabel.Dock = DockStyle.Fill;

            var dayScheduleTableLayoutPanel = new TableLayoutPanel();
            dayScheduleTitleTableLayoutPanel.Controls.Add(dayScheduleTableLayoutPanel, 0, 1);
            dayScheduleTableLayoutPanel.Dock = DockStyle.Fill;
            dayScheduleTableLayoutPanel.ColumnCount = 3;
            dayScheduleTableLayoutPanel.RowCount = daySchedule.Count + 1;
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34));

            for (int i = 0; i < daySchedule.Count; i++)
            {
                if ((daySchedule.Count != 1) || (daySchedule[i] != String.Empty))
                {
                    dayScheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));

                    var lessonTimeLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(lessonTimeLabel, 0, i);
                    lessonTimeLabel.Dock = DockStyle.Fill;
                    lessonTimeLabel.Text = $"{i + 1}. {ClassForWorkWithDatabase.LoadLessonsTime(i + 1)}";
                    lessonTimeLabel.Margin = new Padding(8, 0, 0, 0);

                    var subjectNameLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(subjectNameLabel, 1, i);
                    subjectNameLabel.Dock = DockStyle.Fill;
                    subjectNameLabel.Text = daySchedule[i];
                    subjectNameLabel.TextAlign = ContentAlignment.TopCenter;

                    if (daySchedule[i] != String.Empty)
                    {
                        var studentNote = new TextBox();
                        dayScheduleTableLayoutPanel.Controls.Add(studentNote, 2, i);
                        studentNote.Text = ClassForWorkWithDatabase.LoadStudentNote(this.studentId, studentSubjects.IndexOf(daySchedule[i]) + 1);
                        studentNote.TabStop = false;
                        studentNote.Dock = DockStyle.Fill;
                        studentNote.PlaceholderText = "Добавить заметку";
                        studentNote.Margin = new Padding(0, 0, 15, 0);
                        controlsOfTableLayoutPanel[i] = studentNote;
                    }
                }
            }

            dayScheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 - 18 * (dayScheduleTableLayoutPanel.RowCount - 1))));
        }
        #endregion
    }
}