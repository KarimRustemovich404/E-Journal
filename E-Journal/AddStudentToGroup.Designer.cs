namespace ElectronicDiary
{
    partial class AddStudentToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentToGroup));
            addStudentToGroupTableLayoutPanel = new TableLayoutPanel();
            addStudentToGroupDataTableLayoutPanel = new TableLayoutPanel();
            addStudentToGroupTitleLabel = new Label();
            addStudentToGroupComboBox = new ComboBox();
            addStudentToGroupButton = new Button();
            addStudentToGroupTableLayoutPanel.SuspendLayout();
            addStudentToGroupDataTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addStudentToGroupTableLayoutPanel
            // 
            addStudentToGroupTableLayoutPanel.ColumnCount = 1;
            addStudentToGroupTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            addStudentToGroupTableLayoutPanel.Controls.Add(addStudentToGroupDataTableLayoutPanel, 0, 0);
            addStudentToGroupTableLayoutPanel.Controls.Add(addStudentToGroupButton, 0, 1);
            addStudentToGroupTableLayoutPanel.Dock = DockStyle.Fill;
            addStudentToGroupTableLayoutPanel.Location = new Point(0, 0);
            addStudentToGroupTableLayoutPanel.Name = "addStudentToGroupTableLayoutPanel";
            addStudentToGroupTableLayoutPanel.RowCount = 2;
            addStudentToGroupTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            addStudentToGroupTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            addStudentToGroupTableLayoutPanel.Size = new Size(432, 203);
            addStudentToGroupTableLayoutPanel.TabIndex = 1;
            addStudentToGroupTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // addStudentToGroupDataTableLayoutPanel
            // 
            addStudentToGroupDataTableLayoutPanel.ColumnCount = 2;
            addStudentToGroupDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            addStudentToGroupDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            addStudentToGroupDataTableLayoutPanel.Controls.Add(addStudentToGroupTitleLabel, 0, 1);
            addStudentToGroupDataTableLayoutPanel.Controls.Add(addStudentToGroupComboBox, 1, 1);
            addStudentToGroupDataTableLayoutPanel.Dock = DockStyle.Fill;
            addStudentToGroupDataTableLayoutPanel.Location = new Point(3, 3);
            addStudentToGroupDataTableLayoutPanel.Name = "addStudentToGroupDataTableLayoutPanel";
            addStudentToGroupDataTableLayoutPanel.RowCount = 2;
            addStudentToGroupDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            addStudentToGroupDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            addStudentToGroupDataTableLayoutPanel.Size = new Size(426, 115);
            addStudentToGroupDataTableLayoutPanel.TabIndex = 0;
            addStudentToGroupDataTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // addStudentToGroupTitleLabel
            // 
            addStudentToGroupTitleLabel.AutoSize = true;
            addStudentToGroupTitleLabel.Dock = DockStyle.Top;
            addStudentToGroupTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStudentToGroupTitleLabel.Location = new Point(0, 48);
            addStudentToGroupTitleLabel.Margin = new Padding(0, 8, 0, 0);
            addStudentToGroupTitleLabel.Name = "addStudentToGroupTitleLabel";
            addStudentToGroupTitleLabel.Size = new Size(170, 44);
            addStudentToGroupTitleLabel.TabIndex = 0;
            addStudentToGroupTitleLabel.Text = "Выберите студента";
            addStudentToGroupTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            addStudentToGroupTitleLabel.Click += FormElementsOnClick;
            // 
            // addStudentToGroupComboBox
            // 
            addStudentToGroupComboBox.Cursor = Cursors.Hand;
            addStudentToGroupComboBox.Dock = DockStyle.Top;
            addStudentToGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addStudentToGroupComboBox.FlatStyle = FlatStyle.Popup;
            addStudentToGroupComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStudentToGroupComboBox.FormattingEnabled = true;
            addStudentToGroupComboBox.Location = new Point(173, 58);
            addStudentToGroupComboBox.Margin = new Padding(3, 18, 10, 0);
            addStudentToGroupComboBox.Name = "addStudentToGroupComboBox";
            addStudentToGroupComboBox.Size = new Size(243, 26);
            addStudentToGroupComboBox.TabIndex = 1;
            addStudentToGroupComboBox.TabStop = false;
            addStudentToGroupComboBox.Enter += AddStudentToGroupComboBoxEnter;
            // 
            // addStudentToGroupButton
            // 
            addStudentToGroupButton.BackColor = Color.DeepSkyBlue;
            addStudentToGroupButton.Cursor = Cursors.Hand;
            addStudentToGroupButton.Dock = DockStyle.Fill;
            addStudentToGroupButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            addStudentToGroupButton.FlatAppearance.BorderSize = 0;
            addStudentToGroupButton.FlatStyle = FlatStyle.Flat;
            addStudentToGroupButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStudentToGroupButton.Location = new Point(140, 136);
            addStudentToGroupButton.Margin = new Padding(140, 15, 140, 27);
            addStudentToGroupButton.Name = "addStudentToGroupButton";
            addStudentToGroupButton.Size = new Size(152, 40);
            addStudentToGroupButton.TabIndex = 1;
            addStudentToGroupButton.Text = "Сохранить";
            addStudentToGroupButton.UseVisualStyleBackColor = false;
            addStudentToGroupButton.Click += AddStudentToGroupButtonClick;
            // 
            // AddStudentToGroup
            // 
            AcceptButton = addStudentToGroupButton;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(432, 203);
            Controls.Add(addStudentToGroupTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AddStudentToGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление студента в группу ";
            addStudentToGroupTableLayoutPanel.ResumeLayout(false);
            addStudentToGroupDataTableLayoutPanel.ResumeLayout(false);
            addStudentToGroupDataTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel addStudentToGroupTableLayoutPanel;
        private TableLayoutPanel addStudentToGroupDataTableLayoutPanel;
        private Label addStudentToGroupTitleLabel;
        private Button addStudentToGroupButton;
        private ComboBox addStudentToGroupComboBox;
    }
}