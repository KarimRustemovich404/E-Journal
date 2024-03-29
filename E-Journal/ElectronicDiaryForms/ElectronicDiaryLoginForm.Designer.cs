using System.Windows.Forms;
using System.Drawing;

namespace ElectronicDiary
{
    partial class ElectronicDiaryLoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectronicDiaryLoginForm));
            entryFormPictureBox = new PictureBox();
            loginFieldTextBox = new TextBox();
            passwordFieldTextBox = new TextBox();
            entryFormTableLayoutPanel = new TableLayoutPanel();
            errorMessageLabel = new Label();
            entryFormButton = new Button();
            ((System.ComponentModel.ISupportInitialize)entryFormPictureBox).BeginInit();
            entryFormTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // entryFormPictureBox
            // 
            entryFormPictureBox.Dock = DockStyle.Fill;
            entryFormPictureBox.Image = (Image)resources.GetObject("entryFormPictureBox.Image");
            entryFormPictureBox.Location = new Point(160, 4);
            entryFormPictureBox.Margin = new Padding(4);
            entryFormPictureBox.Name = "entryFormPictureBox";
            entryFormPictureBox.Size = new Size(461, 296);
            entryFormPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            entryFormPictureBox.TabIndex = 0;
            entryFormPictureBox.TabStop = false;
            entryFormPictureBox.Click += EntryFormElementsOnClick;
            // 
            // loginFieldTextBox
            // 
            loginFieldTextBox.BackColor = SystemColors.ControlLightLight;
            loginFieldTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginFieldTextBox.Cursor = Cursors.IBeam;
            loginFieldTextBox.Dock = DockStyle.Fill;
            loginFieldTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginFieldTextBox.ForeColor = SystemColors.WindowText;
            loginFieldTextBox.Location = new Point(211, 374);
            loginFieldTextBox.Margin = new Padding(55, 15, 55, 8);
            loginFieldTextBox.MaxLength = 50;
            loginFieldTextBox.Name = "loginFieldTextBox";
            loginFieldTextBox.PlaceholderText = "Введите логин";
            loginFieldTextBox.Size = new Size(359, 34);
            loginFieldTextBox.TabIndex = 1;
            loginFieldTextBox.TabStop = false;
            loginFieldTextBox.Enter += DataFieldsTextBoxEnter;
            // 
            // passwordFieldTextBox
            // 
            passwordFieldTextBox.BackColor = SystemColors.ControlLightLight;
            passwordFieldTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordFieldTextBox.Cursor = Cursors.IBeam;
            passwordFieldTextBox.Dock = DockStyle.Fill;
            passwordFieldTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordFieldTextBox.ForeColor = SystemColors.WindowText;
            passwordFieldTextBox.Location = new Point(211, 429);
            passwordFieldTextBox.Margin = new Padding(55, 10, 55, 5);
            passwordFieldTextBox.MaxLength = 20;
            passwordFieldTextBox.Name = "passwordFieldTextBox";
            passwordFieldTextBox.PasswordChar = '*';
            passwordFieldTextBox.PlaceholderText = "Введите пароль";
            passwordFieldTextBox.Size = new Size(359, 34);
            passwordFieldTextBox.TabIndex = 1;
            passwordFieldTextBox.TabStop = false;
            passwordFieldTextBox.Enter += DataFieldsTextBoxEnter;
            // 
            // entryFormTableLayoutPanel
            // 
            entryFormTableLayoutPanel.ColumnCount = 3;
            entryFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            entryFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            entryFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            entryFormTableLayoutPanel.Controls.Add(entryFormPictureBox, 1, 0);
            entryFormTableLayoutPanel.Controls.Add(loginFieldTextBox, 1, 2);
            entryFormTableLayoutPanel.Controls.Add(passwordFieldTextBox, 1, 3);
            entryFormTableLayoutPanel.Controls.Add(errorMessageLabel, 1, 1);
            entryFormTableLayoutPanel.Controls.Add(entryFormButton, 1, 4);
            entryFormTableLayoutPanel.Dock = DockStyle.Fill;
            entryFormTableLayoutPanel.Location = new Point(0, 0);
            entryFormTableLayoutPanel.Name = "entryFormTableLayoutPanel";
            entryFormTableLayoutPanel.RowCount = 5;
            entryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55.0002937F));
            entryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000525F));
            entryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9997931F));
            entryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9997931F));
            entryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0000677F));
            entryFormTableLayoutPanel.Size = new Size(782, 553);
            entryFormTableLayoutPanel.TabIndex = 4;
            entryFormTableLayoutPanel.Click += EntryFormElementsOnClick;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.Dock = DockStyle.Fill;
            errorMessageLabel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            errorMessageLabel.Location = new Point(171, 312);
            errorMessageLabel.Margin = new Padding(15, 8, 15, 8);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(439, 39);
            errorMessageLabel.TabIndex = 3;
            errorMessageLabel.Text = "Вход в систему";
            errorMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorMessageLabel.Click += EntryFormElementsOnClick;
            // 
            // entryFormButton
            // 
            entryFormButton.BackColor = Color.DeepSkyBlue;
            entryFormButton.Cursor = Cursors.Hand;
            entryFormButton.Dock = DockStyle.Fill;
            entryFormButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            entryFormButton.FlatAppearance.BorderSize = 0;
            entryFormButton.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryFormButton.ForeColor = SystemColors.Window;
            entryFormButton.Location = new Point(288, 489);
            entryFormButton.Margin = new Padding(132, 10, 132, 14);
            entryFormButton.Name = "entryFormButton";
            entryFormButton.Size = new Size(205, 50);
            entryFormButton.TabIndex = 4;
            entryFormButton.Text = "Вход";
            entryFormButton.UseVisualStyleBackColor = false;
            entryFormButton.Click += EntryButtonClick;
            // 
            // ElectronicDiaryLoginForm
            // 
            AcceptButton = entryFormButton;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 553);
            Controls.Add(entryFormTableLayoutPanel);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ElectronicDiaryLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронный дневник студента";
            Click += EntryFormElementsOnClick;
            KeyDown += FormKeyDown;
            ((System.ComponentModel.ISupportInitialize)entryFormPictureBox).EndInit();
            entryFormTableLayoutPanel.ResumeLayout(false);
            entryFormTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private PictureBox entryFormPictureBox;
        private TextBox loginFieldTextBox;
        private TextBox passwordFieldTextBox;
        private TableLayoutPanel entryFormTableLayoutPanel;
        private Label errorMessageLabel;
        private Button entryFormButton;
    }
}