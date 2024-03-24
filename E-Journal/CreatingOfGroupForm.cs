using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithDatabase;

namespace E_Journal
{
    public partial class CreatingOfGroupForm : Form
    {
        private List<Control> controlsInTableLayoutPanel = new List<Control>();

        public CreatingOfGroupForm()
        {
            InitializeComponent();
        }

        public static bool AddingNewStudyGroup(string groupName)
        {
            var addGroupButton = new Button();
            addGroupButton.Text = "Создать";
            addGroupButton.Font = new Font("Arial", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addGroupButton.ForeColor = SystemColors.WindowText;
            addGroupButton.TextAlign = ContentAlignment.TopLeft;
            addGroupButton.Dock = DockStyle.Fill;
            addGroupButton.Margin = new Padding(0, 33, 0, 0);


            using (var database = new DatabaseForElectronicDiaryContext())
            {
                bool isGroupExist = (from studyGroup in database.Groups where studyGroup.GroupName == groupName select studyGroup).ToList().Count == 0;

                if (isGroupExist)
                {
                    var newStudyGroup = new Group(groupName);
                    database.Groups.Add(newStudyGroup);

                    database.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
