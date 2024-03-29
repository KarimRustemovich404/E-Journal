using ElectronicDiary.Database;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System;

namespace ElectronicDiary
{
    public partial class CardWithDailySchedule : Form
    {
        #region Поля
        int studentId;
        bool isNotesUpdate = false;
        string[] studentDaySchedule = null!;
        Control[] controlsOfTableLayoutPanel = null!;
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        #endregion

        #region События
        private void CardWithDailyScheduleFormClosing(object sender, FormClosingEventArgs e)
        {
            if (isNotesUpdate)
            {
                if (MessageBox.Show("Вы хотите сохранить изменения?", "Выход из карточки дня", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveNoteButtonClick(sender, e);
                }
            }

            e.Cancel = false;
        }

        private void SaveNoteButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < controlsOfTableLayoutPanel.Length; i++)
            {
                if (controlsOfTableLayoutPanel[i] != null)
                {
                    var studentSubjects = DatabaseInteraction.LoadSubjects();
                    var subjectIndex = Array.IndexOf(studentSubjects, studentDaySchedule[i]) + 1;
                    DatabaseInteraction.SaveStudentNote(studentId, subjectIndex, controlsOfTableLayoutPanel[i].Text);
                }
            }

            isNotesUpdate = false;
        }

        private void TextBoxesTextChanged(object sender, EventArgs e)
        {
            isNotesUpdate = true;
        }

        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
        #endregion

        #region Конструкторы
        public CardWithDailySchedule(int studentGroupId, int studentId, int typeOfWeek, int dayIndex)
        {
            fontCollection.AddFontFile("../../../Font/SFProDisplayRegular.otf");

            InitializeComponent();

            this.studentId = studentId;
            saveNoteButton.Font = new Font(fontCollection.Families[0], 14);
            dayScheduleTitleLabel.Font = new Font(fontCollection.Families[0], 20);
            controlsOfTableLayoutPanel = new Control[DatabaseInteraction
                                        .LoadNumberOfSubjects(studentGroupId, typeOfWeek, dayIndex)];
            studentDaySchedule = new string[controlsOfTableLayoutPanel.Length];

            var dayScheduleTableLayoutPanel = new TableLayoutPanel();
            dayScheduleTitleTableLayoutPanel.Controls.Add(dayScheduleTableLayoutPanel, 0, 1);
            dayScheduleTableLayoutPanel.Dock = DockStyle.Fill;
            dayScheduleTableLayoutPanel.ColumnCount = 4;
            dayScheduleTableLayoutPanel.RowCount = controlsOfTableLayoutPanel.Length + 1;
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37));
            dayScheduleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36));
            dayScheduleTableLayoutPanel.Click += FormElementsOnClick;

            for (int i = 0; i < controlsOfTableLayoutPanel.Length; i++)
            {
                var scheduleName = DatabaseInteraction.LoadScheduleData(studentGroupId, typeOfWeek, dayIndex, i + 1);

                if (scheduleName != null)
                {
                    dayScheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14));
                    studentDaySchedule[i] = scheduleName;

                    var lessonNumberLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(lessonNumberLabel, 0, i);
                    lessonNumberLabel.Text = $"{i + 1}.";
                    lessonNumberLabel.Font = new Font(fontCollection.Families[0], 12);
                    lessonNumberLabel.Dock = DockStyle.Fill;
                    lessonNumberLabel.Margin = new Padding(12, 0, 0, 0);
                    lessonNumberLabel.Click += FormElementsOnClick;

                    var lessonTimeLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(lessonTimeLabel, 1, i);
                    lessonTimeLabel.Text = $"{DatabaseInteraction.LoadLessonsTime(i + 1)}";
                    lessonTimeLabel.Font = new Font(fontCollection.Families[0], 12);
                    lessonTimeLabel.Dock = DockStyle.Fill;
                    lessonTimeLabel.TextAlign = ContentAlignment.TopLeft;
                    lessonTimeLabel.Click += FormElementsOnClick;

                    var subjectNameLabel = new Label();
                    dayScheduleTableLayoutPanel.Controls.Add(subjectNameLabel, 2, i);
                    subjectNameLabel.Text = scheduleName;
                    subjectNameLabel.Font = new Font(fontCollection.Families[0], 12);
                    subjectNameLabel.Dock = DockStyle.Fill;
                    subjectNameLabel.TextAlign = ContentAlignment.TopCenter;
                    subjectNameLabel.Click += FormElementsOnClick;

                    if (scheduleName != String.Empty)
                    {
                        var studentSubjects = DatabaseInteraction.LoadSubjects();

                        var studentNote = new TextBox();
                        dayScheduleTableLayoutPanel.Controls.Add(studentNote, 3, i);
                        studentNote.Text = DatabaseInteraction.LoadStudentNote(studentId,
                                            Array.IndexOf(studentSubjects, scheduleName) + 1);
                        studentNote.Font = new Font(fontCollection.Families[0], 12);
                        studentNote.TabStop = false;
                        studentNote.Dock = DockStyle.Fill;
                        studentNote.PlaceholderText = "Добавить заметку";
                        studentNote.Margin = new Padding(0, 0, 15, 0);
                        studentNote.TextChanged += TextBoxesTextChanged;
                        controlsOfTableLayoutPanel[i] = studentNote;
                    }
                }
                else
                {
                    break;
                }
            }

            dayScheduleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 
                                (100 - 14 * (dayScheduleTableLayoutPanel.RowCount - 1))));
        }
        #endregion
    }
}