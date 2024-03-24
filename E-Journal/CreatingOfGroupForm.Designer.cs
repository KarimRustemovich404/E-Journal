namespace ElectronicDiary
{
    partial class CreatingOfGroupForm
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
            newGroupPictureBox = new PictureBox();
            groupNumberLabel = new Label();
            groupNumberTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)newGroupPictureBox).BeginInit();
            SuspendLayout();
            // 
            // newGroupPictureBox
            // 
            newGroupPictureBox.BackColor = Color.LightGray;
            newGroupPictureBox.Location = new Point(-2, -2);
            newGroupPictureBox.Name = "newGroupPictureBox";
            newGroupPictureBox.Size = new Size(490, 270);
            newGroupPictureBox.TabIndex = 1;
            newGroupPictureBox.TabStop = false;
            // 
            // groupNumberLabel
            // 
            groupNumberLabel.AutoSize = true;
            groupNumberLabel.BackColor = Color.LightGray;
            groupNumberLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupNumberLabel.Location = new Point(95, 115);
            groupNumberLabel.Name = "groupNumberLabel";
            groupNumberLabel.Size = new Size(115, 18);
            groupNumberLabel.TabIndex = 3;
            groupNumberLabel.Text = "Номер группы:";
            // 
            // groupNumberTextBox
            // 
            groupNumberTextBox.Cursor = Cursors.IBeam;
            groupNumberTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupNumberTextBox.Location = new Point(215, 112);
            groupNumberTextBox.Name = "groupNumberTextBox";
            groupNumberTextBox.Size = new Size(160, 26);
            groupNumberTextBox.TabIndex = 4;
            // 
            // CreatingOfGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(groupNumberTextBox);
            Controls.Add(groupNumberLabel);
            Controls.Add(newGroupPictureBox);
            Name = "CreatingOfGroupForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание новой группы";
            ((System.ComponentModel.ISupportInitialize)newGroupPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox newGroupPictureBox;
        private Label groupNumberLabel;
        private TextBox groupNumberTextBox;
    }
}