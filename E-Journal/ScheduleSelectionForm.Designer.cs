using System.Windows.Forms;
using System.Drawing;

namespace ElectronicDiary
{
    partial class ScheduleSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleSelectionForm));
            scheduleSelectionTableLayoutPanel = new TableLayoutPanel();
            scheduleSelectionDataTableLayoutPanel = new TableLayoutPanel();
            weekTypeSelectionComboBox = new ComboBox();
            weekTypeTitleLabel = new Label();
            groupNameTitleLabel = new Label();
            groupSelectionComboBox = new ComboBox();
            scheduleLoadButton = new Button();
            scheduleSelectionTableLayoutPanel.SuspendLayout();
            scheduleSelectionDataTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // scheduleSelectionTableLayoutPanel
            // 
            scheduleSelectionTableLayoutPanel.ColumnCount = 1;
            scheduleSelectionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            scheduleSelectionTableLayoutPanel.Controls.Add(scheduleSelectionDataTableLayoutPanel, 0, 1);
            scheduleSelectionTableLayoutPanel.Controls.Add(scheduleLoadButton, 0, 2);
            scheduleSelectionTableLayoutPanel.Dock = DockStyle.Fill;
            scheduleSelectionTableLayoutPanel.Location = new Point(0, 0);
            scheduleSelectionTableLayoutPanel.Name = "scheduleSelectionTableLayoutPanel";
            scheduleSelectionTableLayoutPanel.RowCount = 3;
            scheduleSelectionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            scheduleSelectionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            scheduleSelectionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            scheduleSelectionTableLayoutPanel.Size = new Size(482, 303);
            scheduleSelectionTableLayoutPanel.TabIndex = 1;
            scheduleSelectionTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // scheduleSelectionDataTableLayoutPanel
            // 
            scheduleSelectionDataTableLayoutPanel.ColumnCount = 2;
            scheduleSelectionDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            scheduleSelectionDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            scheduleSelectionDataTableLayoutPanel.Controls.Add(weekTypeSelectionComboBox, 1, 1);
            scheduleSelectionDataTableLayoutPanel.Controls.Add(weekTypeTitleLabel, 0, 1);
            scheduleSelectionDataTableLayoutPanel.Controls.Add(groupNameTitleLabel, 0, 0);
            scheduleSelectionDataTableLayoutPanel.Controls.Add(groupSelectionComboBox, 1, 0);
            scheduleSelectionDataTableLayoutPanel.Dock = DockStyle.Fill;
            scheduleSelectionDataTableLayoutPanel.Location = new Point(3, 33);
            scheduleSelectionDataTableLayoutPanel.Name = "scheduleSelectionDataTableLayoutPanel";
            scheduleSelectionDataTableLayoutPanel.RowCount = 2;
            scheduleSelectionDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            scheduleSelectionDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            scheduleSelectionDataTableLayoutPanel.Size = new Size(476, 181);
            scheduleSelectionDataTableLayoutPanel.TabIndex = 0;
            scheduleSelectionDataTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // weekTypeSelectionComboBox
            // 
            weekTypeSelectionComboBox.Cursor = Cursors.Hand;
            weekTypeSelectionComboBox.Dock = DockStyle.Top;
            weekTypeSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            weekTypeSelectionComboBox.FlatStyle = FlatStyle.Popup;
            weekTypeSelectionComboBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            weekTypeSelectionComboBox.FormattingEnabled = true;
            weekTypeSelectionComboBox.Location = new Point(253, 116);
            weekTypeSelectionComboBox.Margin = new Padding(15, 26, 15, 3);
            weekTypeSelectionComboBox.Name = "weekTypeSelectionComboBox";
            weekTypeSelectionComboBox.Size = new Size(208, 34);
            weekTypeSelectionComboBox.TabIndex = 14;
            weekTypeSelectionComboBox.TabStop = false;
            weekTypeSelectionComboBox.Enter += ControlsWithDataEnter;
            // 
            // weekTypeTitleLabel
            // 
            weekTypeTitleLabel.AutoSize = true;
            weekTypeTitleLabel.Dock = DockStyle.Top;
            weekTypeTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            weekTypeTitleLabel.Location = new Point(3, 121);
            weekTypeTitleLabel.Margin = new Padding(3, 31, 3, 0);
            weekTypeTitleLabel.Name = "weekTypeTitleLabel";
            weekTypeTitleLabel.Size = new Size(232, 26);
            weekTypeTitleLabel.TabIndex = 10;
            weekTypeTitleLabel.Text = "Тип недели";
            weekTypeTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            weekTypeTitleLabel.Click += FormElementsOnClick;
            // 
            // groupNameTitleLabel
            // 
            groupNameTitleLabel.AutoSize = true;
            groupNameTitleLabel.Dock = DockStyle.Top;
            groupNameTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupNameTitleLabel.Location = new Point(3, 31);
            groupNameTitleLabel.Margin = new Padding(3, 31, 3, 0);
            groupNameTitleLabel.Name = "groupNameTitleLabel";
            groupNameTitleLabel.Size = new Size(232, 26);
            groupNameTitleLabel.TabIndex = 0;
            groupNameTitleLabel.Text = "Название группы";
            groupNameTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            groupNameTitleLabel.Click += FormElementsOnClick;
            // 
            // groupSelectionComboBox
            // 
            groupSelectionComboBox.Cursor = Cursors.Hand;
            groupSelectionComboBox.Dock = DockStyle.Top;
            groupSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            groupSelectionComboBox.FlatStyle = FlatStyle.Popup;
            groupSelectionComboBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupSelectionComboBox.FormattingEnabled = true;
            groupSelectionComboBox.Location = new Point(253, 26);
            groupSelectionComboBox.Margin = new Padding(15, 26, 15, 3);
            groupSelectionComboBox.Name = "groupSelectionComboBox";
            groupSelectionComboBox.Size = new Size(208, 34);
            groupSelectionComboBox.TabIndex = 5;
            groupSelectionComboBox.TabStop = false;
            groupSelectionComboBox.Enter += ControlsWithDataEnter;
            // 
            // scheduleLoadButton
            // 
            scheduleLoadButton.BackColor = Color.DeepSkyBlue;
            scheduleLoadButton.Cursor = Cursors.Hand;
            scheduleLoadButton.Dock = DockStyle.Fill;
            scheduleLoadButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            scheduleLoadButton.FlatAppearance.BorderSize = 0;
            scheduleLoadButton.FlatStyle = FlatStyle.Flat;
            scheduleLoadButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            scheduleLoadButton.Location = new Point(150, 231);
            scheduleLoadButton.Margin = new Padding(150, 14, 150, 20);
            scheduleLoadButton.Name = "scheduleLoadButton";
            scheduleLoadButton.Size = new Size(182, 52);
            scheduleLoadButton.TabIndex = 1;
            scheduleLoadButton.Text = "Загрузить";
            scheduleLoadButton.UseVisualStyleBackColor = false;
            scheduleLoadButton.Click += ScheduleLoadButtonClick;
            // 
            // ScheduleSelectionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(482, 303);
            Controls.Add(scheduleSelectionTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ScheduleSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбор расписания";
            scheduleSelectionTableLayoutPanel.ResumeLayout(false);
            scheduleSelectionDataTableLayoutPanel.ResumeLayout(false);
            scheduleSelectionDataTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel scheduleSelectionTableLayoutPanel;
        private TableLayoutPanel scheduleSelectionDataTableLayoutPanel;
        private ComboBox weekTypeSelectionComboBox;
        private Label weekTypeTitleLabel;
        private Label groupNameTitleLabel;
        private ComboBox groupSelectionComboBox;
        private Button scheduleLoadButton;
    }
}