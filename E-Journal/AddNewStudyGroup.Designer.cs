namespace ElectronicDiary
{
    partial class AddNewStudyGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudyGroup));
            addNewStudyGroupTableLayoutPanel = new TableLayoutPanel();
            addNewStudyGroupDataTableLayoutPanel = new TableLayoutPanel();
            addNewStudyGroupTitleLabel = new Label();
            addNewStudyGroupTextBox = new TextBox();
            addNewStudyGroupButton = new Button();
            addNewStudyGroupTableLayoutPanel.SuspendLayout();
            addNewStudyGroupDataTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addNewStudyGroupTableLayoutPanel
            // 
            addNewStudyGroupTableLayoutPanel.ColumnCount = 1;
            addNewStudyGroupTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            addNewStudyGroupTableLayoutPanel.Controls.Add(addNewStudyGroupDataTableLayoutPanel, 0, 0);
            addNewStudyGroupTableLayoutPanel.Controls.Add(addNewStudyGroupButton, 0, 1);
            addNewStudyGroupTableLayoutPanel.Dock = DockStyle.Fill;
            addNewStudyGroupTableLayoutPanel.Location = new Point(0, 0);
            addNewStudyGroupTableLayoutPanel.Name = "addNewStudyGroupTableLayoutPanel";
            addNewStudyGroupTableLayoutPanel.RowCount = 2;
            addNewStudyGroupTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            addNewStudyGroupTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            addNewStudyGroupTableLayoutPanel.Size = new Size(382, 203);
            addNewStudyGroupTableLayoutPanel.TabIndex = 0;
            addNewStudyGroupTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // addNewStudyGroupDataTableLayoutPanel
            // 
            addNewStudyGroupDataTableLayoutPanel.ColumnCount = 2;
            addNewStudyGroupDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            addNewStudyGroupDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53F));
            addNewStudyGroupDataTableLayoutPanel.Controls.Add(addNewStudyGroupTitleLabel, 0, 1);
            addNewStudyGroupDataTableLayoutPanel.Controls.Add(addNewStudyGroupTextBox, 1, 1);
            addNewStudyGroupDataTableLayoutPanel.Dock = DockStyle.Fill;
            addNewStudyGroupDataTableLayoutPanel.Location = new Point(3, 3);
            addNewStudyGroupDataTableLayoutPanel.Name = "addNewStudyGroupDataTableLayoutPanel";
            addNewStudyGroupDataTableLayoutPanel.RowCount = 2;
            addNewStudyGroupDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            addNewStudyGroupDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            addNewStudyGroupDataTableLayoutPanel.Size = new Size(376, 115);
            addNewStudyGroupDataTableLayoutPanel.TabIndex = 0;
            addNewStudyGroupDataTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // addNewStudyGroupTitleLabel
            // 
            addNewStudyGroupTitleLabel.AutoSize = true;
            addNewStudyGroupTitleLabel.Dock = DockStyle.Top;
            addNewStudyGroupTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addNewStudyGroupTitleLabel.Location = new Point(0, 57);
            addNewStudyGroupTitleLabel.Margin = new Padding(0, 6, 0, 0);
            addNewStudyGroupTitleLabel.Name = "addNewStudyGroupTitleLabel";
            addNewStudyGroupTitleLabel.Size = new Size(176, 26);
            addNewStudyGroupTitleLabel.TabIndex = 0;
            addNewStudyGroupTitleLabel.Text = "Номер группы";
            addNewStudyGroupTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            addNewStudyGroupTitleLabel.Click += FormElementsOnClick;
            // 
            // addNewStudyGroupTextBox
            // 
            addNewStudyGroupTextBox.BorderStyle = BorderStyle.FixedSingle;
            addNewStudyGroupTextBox.Dock = DockStyle.Top;
            addNewStudyGroupTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addNewStudyGroupTextBox.ImeMode = ImeMode.NoControl;
            addNewStudyGroupTextBox.Location = new Point(179, 54);
            addNewStudyGroupTextBox.Margin = new Padding(3, 3, 15, 3);
            addNewStudyGroupTextBox.MaxLength = 6;
            addNewStudyGroupTextBox.Name = "addNewStudyGroupTextBox";
            addNewStudyGroupTextBox.PlaceholderText = "00-000";
            addNewStudyGroupTextBox.Size = new Size(182, 34);
            addNewStudyGroupTextBox.TabIndex = 1;
            addNewStudyGroupTextBox.TabStop = false;
            addNewStudyGroupTextBox.TextAlign = HorizontalAlignment.Center;
            addNewStudyGroupTextBox.Enter += AddNewStudyGroupTextBoxEnter;
            addNewStudyGroupTextBox.KeyPress += AddNewStudyGroupTextBoxKeyPress;
            // 
            // addNewStudyGroupButton
            // 
            addNewStudyGroupButton.BackColor = Color.DeepSkyBlue;
            addNewStudyGroupButton.Cursor = Cursors.Hand;
            addNewStudyGroupButton.Dock = DockStyle.Fill;
            addNewStudyGroupButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            addNewStudyGroupButton.FlatAppearance.BorderSize = 0;
            addNewStudyGroupButton.FlatStyle = FlatStyle.Flat;
            addNewStudyGroupButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addNewStudyGroupButton.Location = new Point(115, 136);
            addNewStudyGroupButton.Margin = new Padding(115, 15, 115, 27);
            addNewStudyGroupButton.Name = "addNewStudyGroupButton";
            addNewStudyGroupButton.Size = new Size(152, 40);
            addNewStudyGroupButton.TabIndex = 1;
            addNewStudyGroupButton.Text = "Сохранить";
            addNewStudyGroupButton.UseVisualStyleBackColor = false;
            addNewStudyGroupButton.Click += AddNewStudyGroupButtonClick;
            // 
            // AddNewStudyGroup
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(382, 203);
            Controls.Add(addNewStudyGroupTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AddNewStudyGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание новой группы";
            addNewStudyGroupTableLayoutPanel.ResumeLayout(false);
            addNewStudyGroupDataTableLayoutPanel.ResumeLayout(false);
            addNewStudyGroupDataTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel addNewStudyGroupTableLayoutPanel;
        private TableLayoutPanel addNewStudyGroupDataTableLayoutPanel;
        private Label addNewStudyGroupTitleLabel;
        private TextBox addNewStudyGroupTextBox;
        private Button addNewStudyGroupButton;
        private Label groupNumberLabel;
        private TextBox groupNumberTextBox;
    }
}