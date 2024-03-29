using System.Windows.Forms;
using System.Drawing;

namespace ElectronicDiary
{
    partial class CardWithDailySchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardWithDailySchedule));
            dayScheduleTitleTableLayoutPanel = new TableLayoutPanel();
            saveNoteButton = new Button();
            dayScheduleTitleLabel = new Label();
            dayScheduleTitleTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dayScheduleTitleTableLayoutPanel
            // 
            dayScheduleTitleTableLayoutPanel.ColumnCount = 1;
            dayScheduleTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dayScheduleTitleTableLayoutPanel.Controls.Add(saveNoteButton, 0, 2);
            dayScheduleTitleTableLayoutPanel.Controls.Add(dayScheduleTitleLabel, 0, 0);
            dayScheduleTitleTableLayoutPanel.Dock = DockStyle.Fill;
            dayScheduleTitleTableLayoutPanel.Location = new Point(0, 0);
            dayScheduleTitleTableLayoutPanel.Name = "dayScheduleTitleTableLayoutPanel";
            dayScheduleTitleTableLayoutPanel.RowCount = 3;
            dayScheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            dayScheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            dayScheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            dayScheduleTitleTableLayoutPanel.Size = new Size(682, 453);
            dayScheduleTitleTableLayoutPanel.TabIndex = 0;
            // 
            // saveNoteButton
            // 
            saveNoteButton.BackColor = Color.DeepSkyBlue;
            saveNoteButton.Cursor = Cursors.Hand;
            saveNoteButton.Dock = DockStyle.Right;
            saveNoteButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveNoteButton.Location = new Point(472, 378);
            saveNoteButton.Margin = new Padding(14, 8, 30, 20);
            saveNoteButton.Name = "saveNoteButton";
            saveNoteButton.Size = new Size(180, 55);
            saveNoteButton.TabIndex = 0;
            saveNoteButton.Text = "Сохранить";
            saveNoteButton.UseVisualStyleBackColor = false;
            saveNoteButton.Click += SaveNoteButtonClick;
            // 
            // dayScheduleTitleLabel
            // 
            dayScheduleTitleLabel.AutoSize = true;
            dayScheduleTitleLabel.Dock = DockStyle.Fill;
            dayScheduleTitleLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dayScheduleTitleLabel.Location = new Point(18, 15);
            dayScheduleTitleLabel.Margin = new Padding(18, 15, 0, 0);
            dayScheduleTitleLabel.Name = "dayScheduleTitleLabel";
            dayScheduleTitleLabel.Size = new Size(664, 60);
            dayScheduleTitleLabel.TabIndex = 1;
            dayScheduleTitleLabel.Text = "Карточка учебного дня";
            dayScheduleTitleLabel.Click += FormElementsOnClick;
            // 
            // CardWithDailySchedule
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(682, 453);
            Controls.Add(dayScheduleTitleTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CardWithDailySchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расписание";
            FormClosing += CardWithDailyScheduleFormClosing;
            dayScheduleTitleTableLayoutPanel.ResumeLayout(false);
            dayScheduleTitleTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel dayScheduleTitleTableLayoutPanel;
        private Button saveNoteButton;
        private Label dayScheduleTitleLabel;
    }
}