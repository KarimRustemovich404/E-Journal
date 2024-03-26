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
            enteryFormTableLayoutPanel = new TableLayoutPanel();
            errorMessagesLabel = new Label();
            enteryFormButton = new Button();
            ((System.ComponentModel.ISupportInitialize)entryFormPictureBox).BeginInit();
            enteryFormTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // entryFormPictureBox
            // 
            entryFormPictureBox.Dock = DockStyle.Fill;
            entryFormPictureBox.Image = (Image)resources.GetObject("entryFormPictureBox.Image");
            entryFormPictureBox.Location = new Point(199, 4);
            entryFormPictureBox.Margin = new Padding(4);
            entryFormPictureBox.Name = "entryFormPictureBox";
            entryFormPictureBox.Size = new Size(383, 296);
            entryFormPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            entryFormPictureBox.TabIndex = 0;
            entryFormPictureBox.TabStop = false;
            entryFormPictureBox.Click += EnteryFormElementsOnClick;
            // 
            // loginFieldTextBox
            // 
            loginFieldTextBox.BackColor = SystemColors.ControlLightLight;
            loginFieldTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginFieldTextBox.Cursor = Cursors.IBeam;
            loginFieldTextBox.Dock = DockStyle.Fill;
            loginFieldTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginFieldTextBox.ForeColor = SystemColors.WindowText;
            loginFieldTextBox.Location = new Point(210, 374);
            loginFieldTextBox.Margin = new Padding(15, 15, 15, 8);
            loginFieldTextBox.MaxLength = 50;
            loginFieldTextBox.Name = "loginFieldTextBox";
            loginFieldTextBox.PlaceholderText = "Введите логин";
            loginFieldTextBox.Size = new Size(361, 34);
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
            passwordFieldTextBox.Location = new Point(210, 429);
            passwordFieldTextBox.Margin = new Padding(15, 10, 15, 5);
            passwordFieldTextBox.MaxLength = 20;
            passwordFieldTextBox.Name = "passwordFieldTextBox";
            passwordFieldTextBox.PlaceholderText = "Введите пароль";
            passwordFieldTextBox.Size = new Size(361, 34);
            passwordFieldTextBox.TabIndex = 1;
            passwordFieldTextBox.TabStop = false;
            passwordFieldTextBox.UseSystemPasswordChar = true;
            passwordFieldTextBox.Enter += DataFieldsTextBoxEnter;
            // 
            // enteryFormTableLayoutPanel
            // 
            enteryFormTableLayoutPanel.ColumnCount = 3;
            enteryFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            enteryFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            enteryFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            enteryFormTableLayoutPanel.Controls.Add(entryFormPictureBox, 1, 0);
            enteryFormTableLayoutPanel.Controls.Add(loginFieldTextBox, 1, 2);
            enteryFormTableLayoutPanel.Controls.Add(passwordFieldTextBox, 1, 3);
            enteryFormTableLayoutPanel.Controls.Add(errorMessagesLabel, 1, 1);
            enteryFormTableLayoutPanel.Controls.Add(enteryFormButton, 1, 4);
            enteryFormTableLayoutPanel.Dock = DockStyle.Fill;
            enteryFormTableLayoutPanel.Location = new Point(0, 0);
            enteryFormTableLayoutPanel.Name = "enteryFormTableLayoutPanel";
            enteryFormTableLayoutPanel.RowCount = 5;
            enteryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55.0002861F));
            enteryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000515F));
            enteryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9997931F));
            enteryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9997931F));
            enteryFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0000677F));
            enteryFormTableLayoutPanel.Size = new Size(782, 553);
            enteryFormTableLayoutPanel.TabIndex = 4;
            enteryFormTableLayoutPanel.Click += EnteryFormElementsOnClick;
            // 
            // errorMessagesLabel
            // 
            errorMessagesLabel.AutoSize = true;
            errorMessagesLabel.Dock = DockStyle.Fill;
            errorMessagesLabel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            errorMessagesLabel.Location = new Point(210, 312);
            errorMessagesLabel.Margin = new Padding(15, 8, 15, 8);
            errorMessagesLabel.Name = "errorMessagesLabel";
            errorMessagesLabel.Size = new Size(361, 39);
            errorMessagesLabel.TabIndex = 3;
            errorMessagesLabel.Text = "Вход в систему";
            errorMessagesLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorMessagesLabel.Click += EnteryFormElementsOnClick;
            // 
            // enteryFormButton
            // 
            enteryFormButton.BackColor = Color.DeepSkyBlue;
            enteryFormButton.Dock = DockStyle.Fill;
            enteryFormButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            enteryFormButton.FlatAppearance.BorderSize = 0;
            enteryFormButton.FlatStyle = FlatStyle.Flat;
            enteryFormButton.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enteryFormButton.ForeColor = SystemColors.Window;
            enteryFormButton.Location = new Point(295, 494);
            enteryFormButton.Margin = new Padding(100, 15, 100, 15);
            enteryFormButton.Name = "enteryFormButton";
            enteryFormButton.Size = new Size(191, 44);
            enteryFormButton.TabIndex = 4;
            enteryFormButton.Text = "Вход";
            enteryFormButton.UseVisualStyleBackColor = false;
            enteryFormButton.Click += EnteryButtonClick;
            // 
            // ElectronicDiaryLoginForm
            // 
            AcceptButton = enteryFormButton;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 553);
            Controls.Add(enteryFormTableLayoutPanel);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ElectronicDiaryLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронный дневник студента";
            Click += EnteryFormElementsOnClick;
            KeyDown += FormKeyDown;
            ((System.ComponentModel.ISupportInitialize)entryFormPictureBox).EndInit();
            enteryFormTableLayoutPanel.ResumeLayout(false);
            enteryFormTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox entryFormPictureBox;
        private TextBox loginFieldTextBox;
        private TextBox passwordFieldTextBox;
        private TableLayoutPanel enteryFormTableLayoutPanel;
        private Label errorMessagesLabel;
        private Button enteryFormButton;
    }
}