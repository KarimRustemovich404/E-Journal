using System.Windows.Forms;
using System.Drawing;

namespace ElectronicDiary
{
    partial class AdministratorFormOfElectronicDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorFormOfElectronicDiary));
            administartorMainMenuTableLayoutPanel = new TableLayoutPanel();
            exitLabel = new Label();
            listOfGroupsLabel = new Label();
            scheduleLabel = new Label();
            administratorFormTableLayoutPanel = new TableLayoutPanel();
            administartorMainMenuTableLayoutPanel.SuspendLayout();
            administratorFormTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // administartorMainMenuTableLayoutPanel
            // 
            administartorMainMenuTableLayoutPanel.ColumnCount = 1;
            administartorMainMenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            administartorMainMenuTableLayoutPanel.Controls.Add(exitLabel, 0, 2);
            administartorMainMenuTableLayoutPanel.Controls.Add(listOfGroupsLabel, 0, 0);
            administartorMainMenuTableLayoutPanel.Controls.Add(scheduleLabel, 0, 1);
            administartorMainMenuTableLayoutPanel.Dock = DockStyle.Fill;
            administartorMainMenuTableLayoutPanel.Location = new Point(6, 6);
            administartorMainMenuTableLayoutPanel.Margin = new Padding(5);
            administartorMainMenuTableLayoutPanel.Name = "administartorMainMenuTableLayoutPanel";
            administartorMainMenuTableLayoutPanel.RowCount = 3;
            administartorMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            administartorMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            administartorMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            administartorMainMenuTableLayoutPanel.Size = new Size(185, 641);
            administartorMainMenuTableLayoutPanel.TabIndex = 3;
            // 
            // exitLabel
            // 
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Dock = DockStyle.Bottom;
            exitLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitLabel.ForeColor = Color.Brown;
            exitLabel.Location = new Point(3, 588);
            exitLabel.Margin = new Padding(3, 0, 3, 30);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(179, 23);
            exitLabel.TabIndex = 2;
            exitLabel.Text = "Выйти";
            exitLabel.TextAlign = ContentAlignment.MiddleCenter;
            exitLabel.Click += ExitLabelClick;
            // 
            // listOfGroupsLabel
            // 
            listOfGroupsLabel.Cursor = Cursors.Hand;
            listOfGroupsLabel.Dock = DockStyle.Top;
            listOfGroupsLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listOfGroupsLabel.ForeColor = SystemColors.WindowText;
            listOfGroupsLabel.Location = new Point(3, 30);
            listOfGroupsLabel.Margin = new Padding(3, 30, 3, 0);
            listOfGroupsLabel.Name = "listOfGroupsLabel";
            listOfGroupsLabel.Size = new Size(179, 23);
            listOfGroupsLabel.TabIndex = 0;
            listOfGroupsLabel.Text = "Список групп";
            listOfGroupsLabel.TextAlign = ContentAlignment.MiddleCenter;
            listOfGroupsLabel.Click += ListOfGroupsLabelClick;
            // 
            // scheduleLabel
            // 
            scheduleLabel.Cursor = Cursors.Hand;
            scheduleLabel.Dock = DockStyle.Top;
            scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            scheduleLabel.ForeColor = SystemColors.WindowText;
            scheduleLabel.Location = new Point(3, 106);
            scheduleLabel.Margin = new Padding(3, 30, 3, 0);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(179, 23);
            scheduleLabel.TabIndex = 1;
            scheduleLabel.Text = "Расписание";
            scheduleLabel.TextAlign = ContentAlignment.MiddleCenter;
            scheduleLabel.Click += ScheduleLabelClick;
            // 
            // administratorFormTableLayoutPanel
            // 
            administratorFormTableLayoutPanel.BackColor = SystemColors.ControlLight;
            administratorFormTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            administratorFormTableLayoutPanel.ColumnCount = 2;
            administratorFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            administratorFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            administratorFormTableLayoutPanel.Controls.Add(administartorMainMenuTableLayoutPanel, 0, 0);
            administratorFormTableLayoutPanel.Dock = DockStyle.Fill;
            administratorFormTableLayoutPanel.Location = new Point(0, 0);
            administratorFormTableLayoutPanel.Margin = new Padding(5);
            administratorFormTableLayoutPanel.Name = "administratorFormTableLayoutPanel";
            administratorFormTableLayoutPanel.RowCount = 1;
            administratorFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            administratorFormTableLayoutPanel.Size = new Size(982, 653);
            administratorFormTableLayoutPanel.TabIndex = 4;
            // 
            // AdministratorFormOfElectronicDiary
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(982, 653);
            Controls.Add(administratorFormTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdministratorFormOfElectronicDiary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронный дневник студента";
            administartorMainMenuTableLayoutPanel.ResumeLayout(false);
            administratorFormTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel administartorMainMenuTableLayoutPanel;
        private Label scheduleLabel;
        private Label exitLabel;
        private Label listOfGroupsLabel;
        private TableLayoutPanel administratorFormTableLayoutPanel;
    }
}