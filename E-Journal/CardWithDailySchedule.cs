using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ElectronicDiary.Database;

namespace ElectronicDiary
{
    public partial class CardWithDailySchedule : Form
    {
        #region Поля
        private int studentId;
        private List<string> studentDaySchedule = new List<string>();
        private Control[] controlsOfTableLayoutPanel;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает закрытие формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void CardWithDailyScheduleFormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < controlsOfTableLayoutPanel.Length; i++)
            {
                if (controlsOfTableLayoutPanel[i] != null)
                {
                    var studentSubjects = ClassForWorkWithDatabase.LoadStudentSubjects().ToList();
                    int subjectIndex = studentSubjects.IndexOf(studentDaySchedule[i]) + 1;
                    ClassForWorkWithDatabase.SaveStudentNote(studentId, subjectIndex, controlsOfTableLayoutPanel[i].Text);
                }
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на все элементы формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
        #endregion

        #region Конструкторы
        public CardWithDailySchedule(int studentGroupId, int studentId, int typeOfWeek, int dayIndex)
        {
            InitializeComponent();

            this.studentId = studentId;
            Text = "Расписание";
            controlsOfTableLayoutPanel = new Control[ClassForWorkWithDatabase.LoadingNumberOfPairs(studentGroupId, dayIndex, typeOfWeek)];

            var dayScheduleTitleLabel = new Label();
            dayScheduleTitleTableLayoutPanel.Controls.Add(dayScheduleTitleLabel, 0, 0);
            dayScheduleTitleLabel.Text = "Карточка учебного дня";
            dayScheduleTitleLabel.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dayScheduleTitleLabel.ForeColor = SystemColors.WindowText;
            dayScheduleTitleLabel.TextAlign = ContentAlignment.TopLeft;
            dayScheduleTitleLabel.Margin = new Padding(18, 20, 0, 0);
            dayScheduleTitleLabel.Dock = DockStyle.Fill;
            dayScheduleTitleLabel.Click += FormElementsOnClick;

            var dayScheduleTableLayoutPanel = new TableLayoutPanel();
            dayScheduleTitleTableLayoutPanel.Controls.Add(dayScheduleTableLayoutPanel, 0, 1);
            dayScheduleTableLayoutPanel.Dock = DockStyle.Fill;
            dayScheduleTableLayoutPanel.ColumnCount = 3;
            dayScheduleTableLayoutPanel.RowCount = controlsOfTableLayoutPanel.Length + 1;
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36));
            dayScheduleTableLayoutPanel.Click += FormElementsOnClick;

            for (int i = 0; i < controlsOfTableLayoutPanel.Length; i++)
            {
                string scheduleName = ClassForWorkWithDatabase.LoadingScheduleData(studentGroupId, dayIndex, typeOfWeek, i + 1);

                if (scheduleName != null)
                {
                    dayScheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13));
                    studentDaySchedule.Add(scheduleName);

                    var lessonTimeLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(lessonTimeLabel, 0, i);
                    lessonTimeLabel.Text = $"{i + 1}. {ClassForWorkWithDatabase.LoadLessonsTime(i + 1)}";
                    lessonTimeLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                    lessonTimeLabel.Dock = DockStyle.Fill;
                    lessonTimeLabel.Margin = new Padding(12, 0, 0, 0);
                    lessonTimeLabel.Click += FormElementsOnClick;

                    var subjectNameLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(subjectNameLabel, 1, i);
                    subjectNameLabel.Text = scheduleName;
                    subjectNameLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                    subjectNameLabel.Dock = DockStyle.Fill;
                    subjectNameLabel.TextAlign = ContentAlignment.TopCenter;
                    subjectNameLabel.Click += FormElementsOnClick;

                    if (scheduleName != String.Empty)
                    {
                        var studentSubjects = ClassForWorkWithDatabase.LoadStudentSubjects().ToList();

                        var studentNote = new TextBox();
                        dayScheduleTableLayoutPanel.Controls.Add(studentNote, 2, i);
                        studentNote.Text = ClassForWorkWithDatabase.LoadStudentNote(studentId, studentSubjects.IndexOf(scheduleName) + 1);
                        studentNote.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        studentNote.TabStop = false;
                        studentNote.Dock = DockStyle.Fill;
                        studentNote.PlaceholderText = "Добавить заметку";
                        studentNote.Margin = new Padding(0, 0, 15, 0);
                        controlsOfTableLayoutPanel[i] = studentNote;
                    }
                }
                else
                {
                    break;
                }
            }

            dayScheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 - 13 * (dayScheduleTableLayoutPanel.RowCount - 1))));
        }
        #endregion
    }
}