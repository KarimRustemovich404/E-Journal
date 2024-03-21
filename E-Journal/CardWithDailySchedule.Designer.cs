namespace E_Journal
{
    partial class CardWithDailySchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardWithDailySchedule));
            dayScheduleTitleTableLayoutPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // dayScheduleTitleTableLayoutPanel
            // 
            dayScheduleTitleTableLayoutPanel.ColumnCount = 1;
            dayScheduleTitleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dayScheduleTitleTableLayoutPanel.Dock = DockStyle.Fill;
            dayScheduleTitleTableLayoutPanel.Location = new Point(0, 0);
            dayScheduleTitleTableLayoutPanel.Name = "dayScheduleTitleTableLayoutPanel";
            dayScheduleTitleTableLayoutPanel.RowCount = 2;
            dayScheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            dayScheduleTitleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            dayScheduleTitleTableLayoutPanel.Size = new Size(682, 453);
            dayScheduleTitleTableLayoutPanel.TabIndex = 0;
            // 
            // CardWithDailySchedule
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(682, 453);
            Controls.Add(dayScheduleTitleTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CardWithDailySchedule";
            FormClosing += CardWithDailySchedule_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel dayScheduleTitleTableLayoutPanel;
    }
}