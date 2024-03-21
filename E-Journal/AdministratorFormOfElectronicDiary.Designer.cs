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
            listOfGroupsButton = new Button();
            scheduleButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // listOfGroupsButton
            // 
            listOfGroupsButton.BackColor = Color.LightGray;
            listOfGroupsButton.Cursor = Cursors.Hand;
            listOfGroupsButton.FlatStyle = FlatStyle.Flat;
            listOfGroupsButton.ForeColor = SystemColors.ControlText;
            listOfGroupsButton.Location = new Point(12, 12);
            listOfGroupsButton.Name = "listOfGroupsButton";
            listOfGroupsButton.Size = new Size(120, 45);
            listOfGroupsButton.TabIndex = 0;
            listOfGroupsButton.Text = "Список групп";
            listOfGroupsButton.UseVisualStyleBackColor = false;
            // 
            // scheduleButton
            // 
            scheduleButton.Location = new Point(12, 64);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(120, 45);
            scheduleButton.TabIndex = 1;
            scheduleButton.Text = "Расписание";
            scheduleButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.ForeColor = Color.Red;
            exitButton.Location = new Point(12, 518);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(80, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // AdministratorFormOfElectronicDiary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(exitButton);
            Controls.Add(scheduleButton);
            Controls.Add(listOfGroupsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdministratorFormOfElectronicDiary";
            Text = "AdministratorFormOfElectronicDiary";
            ResumeLayout(false);
        }

        #endregion

        private Button listOfGroupsButton;
        private Button scheduleButton;
        private Button exitButton;
    }
}