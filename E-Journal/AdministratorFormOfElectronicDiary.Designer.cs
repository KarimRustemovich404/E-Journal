namespace E_Journal
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
            adminMainMenuTableLayoutPanel = new TableLayoutPanel();
            exitLabel = new Label();
            listOfGroupsLabel = new Label();
            scheduleLabel = new Label();
            adminFormTableLayoutPanel = new TableLayoutPanel();
            adminMainMenuTableLayoutPanel.SuspendLayout();
            adminFormTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // adminMainMenuTableLayoutPanel
            // 
            adminMainMenuTableLayoutPanel.ColumnCount = 1;
            adminMainMenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            adminMainMenuTableLayoutPanel.Controls.Add(exitLabel, 0, 2);
            adminMainMenuTableLayoutPanel.Controls.Add(listOfGroupsLabel, 0, 0);
            adminMainMenuTableLayoutPanel.Controls.Add(scheduleLabel, 0, 1);
            adminMainMenuTableLayoutPanel.Location = new Point(4, 4);
            adminMainMenuTableLayoutPanel.Name = "adminMainMenuTableLayoutPanel";
            adminMainMenuTableLayoutPanel.RowCount = 3;
            adminMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            adminMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            adminMainMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            adminMainMenuTableLayoutPanel.Size = new Size(189, 642);
            adminMainMenuTableLayoutPanel.TabIndex = 3;
            // 
            // exitLabel
            // 
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Dock = DockStyle.Bottom;
            exitLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitLabel.ForeColor = Color.Brown;
            exitLabel.Location = new Point(3, 624);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(183, 18);
            exitLabel.TabIndex = 2;
            exitLabel.Text = "Выйти";
            exitLabel.TextAlign = ContentAlignment.MiddleCenter;
            exitLabel.Click += ExitLabelClick;
            // 
            // listOfGroupsLabel
            // 
            listOfGroupsLabel.Cursor = Cursors.Hand;
            listOfGroupsLabel.Dock = DockStyle.Fill;
            listOfGroupsLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listOfGroupsLabel.ForeColor = SystemColors.WindowText;
            listOfGroupsLabel.Location = new Point(3, 0);
            listOfGroupsLabel.Name = "listOfGroupsLabel";
            listOfGroupsLabel.Size = new Size(183, 96);
            listOfGroupsLabel.TabIndex = 0;
            listOfGroupsLabel.Text = "Список групп";
            listOfGroupsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scheduleLabel
            // 
            scheduleLabel.Cursor = Cursors.Hand;
            scheduleLabel.Dock = DockStyle.Fill;
            scheduleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            scheduleLabel.ForeColor = SystemColors.WindowText;
            scheduleLabel.Location = new Point(3, 96);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(183, 96);
            scheduleLabel.TabIndex = 1;
            scheduleLabel.Text = "Расписание";
            scheduleLabel.TextAlign = ContentAlignment.MiddleCenter;
            scheduleLabel.Click += ScheduleLabelClick;
            // 
            // adminFormTableLayoutPanel
            // 
            adminFormTableLayoutPanel.BackColor = SystemColors.ControlLight;
            adminFormTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            adminFormTableLayoutPanel.ColumnCount = 2;
            adminFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            adminFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            adminFormTableLayoutPanel.Controls.Add(adminMainMenuTableLayoutPanel, 0, 0);
            adminFormTableLayoutPanel.Location = new Point(0, 1);
            adminFormTableLayoutPanel.Name = "adminFormTableLayoutPanel";
            adminFormTableLayoutPanel.RowCount = 1;
            adminFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            adminFormTableLayoutPanel.Size = new Size(983, 650);
            adminFormTableLayoutPanel.TabIndex = 4;
            // 
            // AdministratorFormOfElectronicDiary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 651);
            Controls.Add(adminFormTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdministratorFormOfElectronicDiary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронный дневник студента";
            adminMainMenuTableLayoutPanel.ResumeLayout(false);
            adminFormTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel adminMainMenuTableLayoutPanel;
        private Label scheduleLabel;
        private Label exitLabel;
        private Label listOfGroupsLabel;
        private TableLayoutPanel adminFormTableLayoutPanel;
    }
}