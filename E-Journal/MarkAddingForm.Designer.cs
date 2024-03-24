namespace ElectronicDiary
{
    partial class MarkAddingForm
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
            MarkAddingPictureBox = new PictureBox();
            nameOfStudentLabel = new Label();
            subjectLabel = new Label();
            typeLabel = new Label();
            markLabel = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)MarkAddingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MarkAddingPictureBox
            // 
            MarkAddingPictureBox.BackColor = Color.LightGray;
            MarkAddingPictureBox.Location = new Point(-1, 0);
            MarkAddingPictureBox.Name = "MarkAddingPictureBox";
            MarkAddingPictureBox.Size = new Size(490, 409);
            MarkAddingPictureBox.TabIndex = 0;
            MarkAddingPictureBox.TabStop = false;
            // 
            // nameOfStudentLabel
            // 
            nameOfStudentLabel.AutoSize = true;
            nameOfStudentLabel.BackColor = Color.LightGray;
            nameOfStudentLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameOfStudentLabel.Location = new Point(100, 88);
            nameOfStudentLabel.Name = "nameOfStudentLabel";
            nameOfStudentLabel.Size = new Size(114, 18);
            nameOfStudentLabel.TabIndex = 1;
            nameOfStudentLabel.Text = "ФИО студента:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = Color.LightGray;
            subjectLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            subjectLabel.Location = new Point(117, 153);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(97, 18);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "Дисциплина:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = Color.LightGray;
            typeLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typeLabel.Location = new Point(178, 218);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(36, 18);
            typeLabel.TabIndex = 3;
            typeLabel.Text = "Тип:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.BackColor = Color.LightGray;
            markLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            markLabel.Location = new Point(166, 283);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(48, 18);
            markLabel.TabIndex = 4;
            markLabel.Text = "Балл:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox1.Location = new Point(215, 85);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 26);
            maskedTextBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(215, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 26);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(215, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(215, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 26);
            textBox3.TabIndex = 8;
            // 
            // MarkAddingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 407);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(markLabel);
            Controls.Add(typeLabel);
            Controls.Add(subjectLabel);
            Controls.Add(nameOfStudentLabel);
            Controls.Add(MarkAddingPictureBox);
            Name = "MarkAddingForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление оценки";
            ((System.ComponentModel.ISupportInitialize)MarkAddingPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MarkAddingPictureBox;
        private Label nameOfStudentLabel;
        private Label subjectLabel;
        private Label typeLabel;
        private Label markLabel;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}