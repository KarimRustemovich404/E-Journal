namespace E_Journal
{
    partial class Entry_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry_Form));
            Entry_Picture = new PictureBox();
            Login_Field = new TextBox();
            Password_Field = new TextBox();
            Entry_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Entry_Picture).BeginInit();
            SuspendLayout();
            // 
            // Entry_Picture
            // 
            Entry_Picture.Image = (Image)resources.GetObject("Entry_Picture.Image");
            Entry_Picture.Location = new Point(239, 99);
            Entry_Picture.Name = "Entry_Picture";
            Entry_Picture.Size = new Size(200, 200);
            Entry_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Entry_Picture.TabIndex = 0;
            Entry_Picture.TabStop = false;
            // 
            // Login_Field
            // 
            Login_Field.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Field.Location = new Point(239, 334);
            Login_Field.Name = "Login_Field";
            Login_Field.Size = new Size(200, 39);
            Login_Field.TabIndex = 1;
            // 
            // Password_Field
            // 
            Password_Field.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_Field.Location = new Point(239, 396);
            Password_Field.Name = "Password_Field";
            Password_Field.Size = new Size(200, 39);
            Password_Field.TabIndex = 2;
            // 
            // Entry_Btn
            // 
            Entry_Btn.Location = new Point(272, 473);
            Entry_Btn.Name = "Entry_Btn";
            Entry_Btn.Size = new Size(134, 39);
            Entry_Btn.TabIndex = 3;
            Entry_Btn.Text = "Войти";
            Entry_Btn.UseVisualStyleBackColor = true;
            // 
            // Entry_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 561);
            Controls.Add(Entry_Btn);
            Controls.Add(Password_Field);
            Controls.Add(Login_Field);
            Controls.Add(Entry_Picture);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Entry_Form";
            Text = "Электронный дневник студента";
            ((System.ComponentModel.ISupportInitialize)Entry_Picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Entry_Picture;
        private TextBox Login_Field;
        private TextBox Password_Field;
        private Button Entry_Btn;
    }
}