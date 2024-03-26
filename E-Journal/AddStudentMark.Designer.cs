namespace ElectronicDiary
{
    partial class AddStudentMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentMark));
            addStudentMarkTableLayoutPanel = new TableLayoutPanel();
            addStudentMarkDataTableLayoutPanel = new TableLayoutPanel();
            markTypeSelectionComboBox = new ComboBox();
            subjectSelectionComboBox = new ComboBox();
            semesterSelectionComboBox = new ComboBox();
            markTitleLabel = new Label();
            markTypeTitleLabel = new Label();
            subjectTitleLabel = new Label();
            academicSemesterTitleLabel = new Label();
            studentFullNameTitleLabel = new Label();
            studentFullNameComboBox = new ComboBox();
            markTextBox = new TextBox();
            addStudentMarkButton = new Button();
            addStudentMarkTableLayoutPanel.SuspendLayout();
            addStudentMarkDataTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addStudentMarkTableLayoutPanel
            // 
            addStudentMarkTableLayoutPanel.ColumnCount = 1;
            addStudentMarkTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            addStudentMarkTableLayoutPanel.Controls.Add(addStudentMarkDataTableLayoutPanel, 0, 1);
            addStudentMarkTableLayoutPanel.Controls.Add(addStudentMarkButton, 0, 2);
            addStudentMarkTableLayoutPanel.Dock = DockStyle.Fill;
            addStudentMarkTableLayoutPanel.Location = new Point(0, 0);
            addStudentMarkTableLayoutPanel.Name = "addStudentMarkTableLayoutPanel";
            addStudentMarkTableLayoutPanel.RowCount = 3;
            addStudentMarkTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            addStudentMarkTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            addStudentMarkTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            addStudentMarkTableLayoutPanel.Size = new Size(482, 403);
            addStudentMarkTableLayoutPanel.TabIndex = 0;
            addStudentMarkTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // addStudentMarkDataTableLayoutPanel
            // 
            addStudentMarkDataTableLayoutPanel.ColumnCount = 2;
            addStudentMarkDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            addStudentMarkDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            addStudentMarkDataTableLayoutPanel.Controls.Add(markTypeSelectionComboBox, 1, 3);
            addStudentMarkDataTableLayoutPanel.Controls.Add(subjectSelectionComboBox, 1, 2);
            addStudentMarkDataTableLayoutPanel.Controls.Add(semesterSelectionComboBox, 1, 1);
            addStudentMarkDataTableLayoutPanel.Controls.Add(markTitleLabel, 0, 4);
            addStudentMarkDataTableLayoutPanel.Controls.Add(markTypeTitleLabel, 0, 3);
            addStudentMarkDataTableLayoutPanel.Controls.Add(subjectTitleLabel, 0, 2);
            addStudentMarkDataTableLayoutPanel.Controls.Add(academicSemesterTitleLabel, 0, 1);
            addStudentMarkDataTableLayoutPanel.Controls.Add(studentFullNameTitleLabel, 0, 0);
            addStudentMarkDataTableLayoutPanel.Controls.Add(studentFullNameComboBox, 1, 0);
            addStudentMarkDataTableLayoutPanel.Controls.Add(markTextBox, 1, 4);
            addStudentMarkDataTableLayoutPanel.Dock = DockStyle.Fill;
            addStudentMarkDataTableLayoutPanel.Location = new Point(3, 31);
            addStudentMarkDataTableLayoutPanel.Name = "addStudentMarkDataTableLayoutPanel";
            addStudentMarkDataTableLayoutPanel.RowCount = 5;
            addStudentMarkDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addStudentMarkDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addStudentMarkDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addStudentMarkDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addStudentMarkDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            addStudentMarkDataTableLayoutPanel.Size = new Size(476, 276);
            addStudentMarkDataTableLayoutPanel.TabIndex = 0;
            addStudentMarkDataTableLayoutPanel.Click += FormElementsOnClick;
            // 
            // markTypeSelectionComboBox
            // 
            markTypeSelectionComboBox.Cursor = Cursors.Hand;
            markTypeSelectionComboBox.Dock = DockStyle.Top;
            markTypeSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            markTypeSelectionComboBox.FlatStyle = FlatStyle.Popup;
            markTypeSelectionComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            markTypeSelectionComboBox.FormattingEnabled = true;
            markTypeSelectionComboBox.Location = new Point(196, 178);
            markTypeSelectionComboBox.Margin = new Padding(6, 13, 20, 3);
            markTypeSelectionComboBox.Name = "markTypeSelectionComboBox";
            markTypeSelectionComboBox.Size = new Size(260, 26);
            markTypeSelectionComboBox.TabIndex = 16;
            markTypeSelectionComboBox.TabStop = false;
            markTypeSelectionComboBox.Enter += ControlsWithDataEnter;
            // 
            // subjectSelectionComboBox
            // 
            subjectSelectionComboBox.Cursor = Cursors.Hand;
            subjectSelectionComboBox.Dock = DockStyle.Top;
            subjectSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectSelectionComboBox.FlatStyle = FlatStyle.Popup;
            subjectSelectionComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            subjectSelectionComboBox.FormattingEnabled = true;
            subjectSelectionComboBox.Location = new Point(196, 123);
            subjectSelectionComboBox.Margin = new Padding(6, 13, 20, 3);
            subjectSelectionComboBox.Name = "subjectSelectionComboBox";
            subjectSelectionComboBox.Size = new Size(260, 26);
            subjectSelectionComboBox.TabIndex = 15;
            subjectSelectionComboBox.TabStop = false;
            subjectSelectionComboBox.Enter += ControlsWithDataEnter;
            // 
            // semesterSelectionComboBox
            // 
            semesterSelectionComboBox.Cursor = Cursors.Hand;
            semesterSelectionComboBox.Dock = DockStyle.Top;
            semesterSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterSelectionComboBox.FlatStyle = FlatStyle.Popup;
            semesterSelectionComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            semesterSelectionComboBox.FormattingEnabled = true;
            semesterSelectionComboBox.Location = new Point(196, 68);
            semesterSelectionComboBox.Margin = new Padding(6, 13, 20, 3);
            semesterSelectionComboBox.Name = "semesterSelectionComboBox";
            semesterSelectionComboBox.Size = new Size(260, 26);
            semesterSelectionComboBox.TabIndex = 14;
            semesterSelectionComboBox.TabStop = false;
            semesterSelectionComboBox.Enter += ControlsWithDataEnter;
            // 
            // markTitleLabel
            // 
            markTitleLabel.AutoSize = true;
            markTitleLabel.Dock = DockStyle.Top;
            markTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            markTitleLabel.Location = new Point(3, 235);
            markTitleLabel.Margin = new Padding(3, 15, 3, 0);
            markTitleLabel.Name = "markTitleLabel";
            markTitleLabel.Size = new Size(184, 22);
            markTitleLabel.TabIndex = 13;
            markTitleLabel.Text = "Балл";
            markTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            markTitleLabel.Click += FormElementsOnClick;
            // 
            // markTypeTitleLabel
            // 
            markTypeTitleLabel.AutoSize = true;
            markTypeTitleLabel.Dock = DockStyle.Top;
            markTypeTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            markTypeTitleLabel.Location = new Point(3, 180);
            markTypeTitleLabel.Margin = new Padding(3, 15, 3, 0);
            markTypeTitleLabel.Name = "markTypeTitleLabel";
            markTypeTitleLabel.Size = new Size(184, 22);
            markTypeTitleLabel.TabIndex = 12;
            markTypeTitleLabel.Text = "Тип оценки";
            markTypeTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            markTypeTitleLabel.Click += FormElementsOnClick;
            // 
            // subjectTitleLabel
            // 
            subjectTitleLabel.AutoSize = true;
            subjectTitleLabel.Dock = DockStyle.Top;
            subjectTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            subjectTitleLabel.Location = new Point(3, 125);
            subjectTitleLabel.Margin = new Padding(3, 15, 3, 0);
            subjectTitleLabel.Name = "subjectTitleLabel";
            subjectTitleLabel.Size = new Size(184, 22);
            subjectTitleLabel.TabIndex = 11;
            subjectTitleLabel.Text = "Дисциплина";
            subjectTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subjectTitleLabel.Click += FormElementsOnClick;
            // 
            // academicSemesterTitleLabel
            // 
            academicSemesterTitleLabel.AutoSize = true;
            academicSemesterTitleLabel.Dock = DockStyle.Top;
            academicSemesterTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            academicSemesterTitleLabel.Location = new Point(3, 70);
            academicSemesterTitleLabel.Margin = new Padding(3, 15, 3, 0);
            academicSemesterTitleLabel.Name = "academicSemesterTitleLabel";
            academicSemesterTitleLabel.Size = new Size(184, 22);
            academicSemesterTitleLabel.TabIndex = 10;
            academicSemesterTitleLabel.Text = "Семестр";
            academicSemesterTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            academicSemesterTitleLabel.Click += FormElementsOnClick;
            // 
            // studentFullNameTitleLabel
            // 
            studentFullNameTitleLabel.AutoSize = true;
            studentFullNameTitleLabel.Dock = DockStyle.Top;
            studentFullNameTitleLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            studentFullNameTitleLabel.Location = new Point(3, 15);
            studentFullNameTitleLabel.Margin = new Padding(3, 15, 3, 0);
            studentFullNameTitleLabel.Name = "studentFullNameTitleLabel";
            studentFullNameTitleLabel.Size = new Size(184, 22);
            studentFullNameTitleLabel.TabIndex = 0;
            studentFullNameTitleLabel.Text = "ФИО студента";
            studentFullNameTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            studentFullNameTitleLabel.Click += FormElementsOnClick;
            // 
            // studentFullNameComboBox
            // 
            studentFullNameComboBox.Cursor = Cursors.Hand;
            studentFullNameComboBox.Dock = DockStyle.Top;
            studentFullNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            studentFullNameComboBox.FlatStyle = FlatStyle.Popup;
            studentFullNameComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            studentFullNameComboBox.FormattingEnabled = true;
            studentFullNameComboBox.Location = new Point(196, 13);
            studentFullNameComboBox.Margin = new Padding(6, 13, 20, 3);
            studentFullNameComboBox.Name = "studentFullNameComboBox";
            studentFullNameComboBox.Size = new Size(260, 26);
            studentFullNameComboBox.TabIndex = 5;
            studentFullNameComboBox.TabStop = false;
            studentFullNameComboBox.Enter += ControlsWithDataEnter;
            // 
            // markTextBox
            // 
            markTextBox.BorderStyle = BorderStyle.FixedSingle;
            markTextBox.Cursor = Cursors.IBeam;
            markTextBox.Dock = DockStyle.Top;
            markTextBox.Location = new Point(196, 233);
            markTextBox.Margin = new Padding(6, 13, 20, 3);
            markTextBox.MaxLength = 2;
            markTextBox.Name = "markTextBox";
            markTextBox.Size = new Size(260, 26);
            markTextBox.TabIndex = 17;
            markTextBox.TabStop = false;
            markTextBox.TextAlign = HorizontalAlignment.Center;
            markTextBox.Enter += ControlsWithDataEnter;
            markTextBox.KeyPress += MarkTextBoxKeyPress;
            // 
            // addStudentMarkButton
            // 
            addStudentMarkButton.BackColor = Color.DeepSkyBlue;
            addStudentMarkButton.Cursor = Cursors.Hand;
            addStudentMarkButton.Dock = DockStyle.Fill;
            addStudentMarkButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            addStudentMarkButton.FlatAppearance.BorderSize = 0;
            addStudentMarkButton.FlatStyle = FlatStyle.Flat;
            addStudentMarkButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStudentMarkButton.Location = new Point(152, 335);
            addStudentMarkButton.Margin = new Padding(152, 25, 152, 27);
            addStudentMarkButton.Name = "addStudentMarkButton";
            addStudentMarkButton.Size = new Size(178, 41);
            addStudentMarkButton.TabIndex = 1;
            addStudentMarkButton.Text = "Сохранить";
            addStudentMarkButton.UseVisualStyleBackColor = false;
            addStudentMarkButton.Click += AddStudentMarkButtonClick;
            // 
            // AddStudentMark
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(482, 403);
            Controls.Add(addStudentMarkTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AddStudentMark";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление оценки";
            addStudentMarkTableLayoutPanel.ResumeLayout(false);
            addStudentMarkDataTableLayoutPanel.ResumeLayout(false);
            addStudentMarkDataTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel addStudentMarkTableLayoutPanel;
        private TableLayoutPanel addStudentMarkDataTableLayoutPanel;
        private Label studentFullNameTitleLabel;
        private ComboBox studentFullNameComboBox;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label markTitleLabel;
        private Label markTypeTitleLabel;
        private Label subjectTitleLabel;
        private Label academicSemesterTitleLabel;
        private ComboBox markTypeSelectionComboBox;
        private ComboBox subjectSelectionComboBox;
        private ComboBox semesterSelectionComboBox;
        private Button addStudentMarkButton;
        private TextBox markTextBox;
    }
}