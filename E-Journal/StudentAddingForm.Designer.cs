namespace E_Journal
{
    partial class StudentIDForm
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
            StudentIDPictureBox = new PictureBox();
            studentIDLabel = new Label();
            studentIDTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)StudentIDPictureBox).BeginInit();
            SuspendLayout();
            // 
            // StudentIDPictureBox
            // 
            StudentIDPictureBox.BackColor = Color.LightGray;
            StudentIDPictureBox.Location = new Point(-1, 0);
            StudentIDPictureBox.Name = "StudentIDPictureBox";
            StudentIDPictureBox.Size = new Size(490, 270);
            StudentIDPictureBox.TabIndex = 0;
            StudentIDPictureBox.TabStop = false;
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.BackColor = Color.LightGray;
            studentIDLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            studentIDLabel.Location = new Point(115, 115);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(94, 18);
            studentIDLabel.TabIndex = 1;
            studentIDLabel.Text = "ID студента:";
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            studentIDTextBox.Location = new Point(215, 112);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(160, 26);
            studentIDTextBox.TabIndex = 2;
            // 
            // StudentIDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(studentIDTextBox);
            Controls.Add(studentIDLabel);
            Controls.Add(StudentIDPictureBox);
            Name = "StudentIDForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление студента в группу ";
            ((System.ComponentModel.ISupportInitialize)StudentIDPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox StudentIDPictureBox;
        private Label studentIDLabel;
        private TextBox studentIDTextBox;
    }
}