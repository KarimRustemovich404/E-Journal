﻿using System.Windows.Forms;
using System.Drawing;

namespace ElectronicDiary
{
    partial class StudentFormOfElectronicDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFormOfElectronicDiary));
            studentFormTableLayoutPanel = new TableLayoutPanel();
            studentMainMenuTableLayoutPanel = new TableLayoutPanel();
            myProfileLabel = new Label();
            academicPerformanceLabel = new Label();
            scheduleLabel = new Label();
            exitLabel = new Label();
            studentFormTableLayoutPanel.SuspendLayout();
            studentMainMenuTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // studentFormTableLayoutPanel
            // 
            studentFormTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            studentFormTableLayoutPanel.ColumnCount = 2;
            studentFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            studentFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            studentFormTableLayoutPanel.Controls.Add(studentMainMenuTableLayoutPanel, 0, 0);
            studentFormTableLayoutPanel.Dock = DockStyle.Fill;
            studentFormTableLayoutPanel.Location = new Point(0, 0);
            studentFormTableLayoutPanel.Name = "studentFormTableLayoutPanel";
            studentFormTableLayoutPanel.RowCount = 1;
            studentFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            studentFormTableLayoutPanel.Size = new Size(982, 653);
            studentFormTableLayoutPanel.TabIndex = 0;
            // 
            // studentMainMenuTableLayoutPanel
            // 
            studentMainMenuTableLayoutPanel.ColumnCount = 1;
            studentMainMenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            studentMainMenuTableLayoutPanel.Controls.Add(myProfileLabel, 0, 0);
            studentMainMenuTableLayoutPanel.Controls.Add(academicPerformanceLabel, 0, 1);
            studentMainMenuTableLayoutPanel.Controls.Add(scheduleLabel, 0, 2);
            studentMainMenuTableLayoutPanel.Controls.Add(exitLabel, 0, 3);
            studentMainMenuTableLayoutPanel.Dock = DockStyle.Fill;
            studentMainMenuTableLayoutPanel.Location = new Point(4, 4);
            studentMainMenuTableLayoutPanel.Name = "studentMainMenuTableLayoutPanel";
            studentMainMenuTableLayoutPanel.RowCount = 4;
            studentMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            studentMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            studentMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            studentMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            studentMainMenuTableLayoutPanel.Size = new Size(189, 645);
            studentMainMenuTableLayoutPanel.TabIndex = 1;
            // 
            // myProfileLabel
            // 
            myProfileLabel.AutoSize = true;
            myProfileLabel.Cursor = Cursors.Hand;
            myProfileLabel.Dock = DockStyle.Top;
            myProfileLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            myProfileLabel.ForeColor = SystemColors.WindowText;
            myProfileLabel.Location = new Point(25, 30);
            myProfileLabel.Margin = new Padding(25, 30, 3, 0);
            myProfileLabel.Name = "myProfileLabel";
            myProfileLabel.Size = new Size(161, 23);
            myProfileLabel.TabIndex = 0;
            myProfileLabel.Text = "Мой профиль";
            myProfileLabel.TextAlign = ContentAlignment.MiddleLeft;
            myProfileLabel.Click += MyProfileLabelClick;
            // 
            // academicPerformanceLabel
            // 
            academicPerformanceLabel.AutoSize = true;
            academicPerformanceLabel.Cursor = Cursors.Hand;
            academicPerformanceLabel.Dock = DockStyle.Top;
            academicPerformanceLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            academicPerformanceLabel.Location = new Point(25, 107);
            academicPerformanceLabel.Margin = new Padding(25, 30, 3, 0);
            academicPerformanceLabel.Name = "academicPerformanceLabel";
            academicPerformanceLabel.Size = new Size(161, 23);
            academicPerformanceLabel.TabIndex = 1;
            academicPerformanceLabel.Text = "Успеваемость";
            academicPerformanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            academicPerformanceLabel.Click += AcademicPerformanceLabelClick;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.BackColor = SystemColors.ControlLight;
            scheduleLabel.Cursor = Cursors.Hand;
            scheduleLabel.Dock = DockStyle.Top;
            scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            scheduleLabel.Location = new Point(25, 184);
            scheduleLabel.Margin = new Padding(25, 30, 3, 0);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(161, 23);
            scheduleLabel.TabIndex = 2;
            scheduleLabel.Text = "Расписание";
            scheduleLabel.TextAlign = ContentAlignment.MiddleLeft;
            scheduleLabel.Click += ScheduleLabelClick;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Dock = DockStyle.Bottom;
            exitLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitLabel.ForeColor = Color.Brown;
            exitLabel.Location = new Point(25, 589);
            exitLabel.Margin = new Padding(25, 0, 3, 30);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(161, 26);
            exitLabel.TabIndex = 3;
            exitLabel.Text = "Выйти";
            exitLabel.TextAlign = ContentAlignment.MiddleLeft;
            exitLabel.Click += ExitLabelClick;
            // 
            // StudentFormOfElectronicDiary
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(982, 653);
            Controls.Add(studentFormTableLayoutPanel);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentFormOfElectronicDiary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронный дневник студента";
            studentFormTableLayoutPanel.ResumeLayout(false);
            studentMainMenuTableLayoutPanel.ResumeLayout(false);
            studentMainMenuTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel studentFormTableLayoutPanel;
        private TableLayoutPanel studentMainMenuTableLayoutPanel;
        private Label myProfileLabel;
        private Label academicPerformanceLabel;
        private Label scheduleLabel;
        private Label exitLabel;
    }
}