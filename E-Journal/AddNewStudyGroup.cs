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

namespace ElectronicDiary
{
    public partial class AddNewStudyGroup : Form
    {
        #region Поля
        private ComboBox groupSelectionComboBox;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает нажатие кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddNewStudyGroupButtonClick(object sender, EventArgs e)
        {
            if (addNewStudyGroupTextBox.Text.Length != 0)
            {
                if (ClassForWorkWithDatabase.AddingNewStudyGroup(addNewStudyGroupTextBox.Text))
                {
                    groupSelectionComboBox.Items.Add(addNewStudyGroupTextBox.Text);
                    Close();
                }
                else
                {
                    addNewStudyGroupTextBox.BackColor = Color.LightCoral;
                }
            }
            else
            {
                addNewStudyGroupTextBox.BackColor = Color.LightCoral;
            }
        }

        /// <summary>
        /// Метод, который обрабатывает вход в addNewStudyGroupTextBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddNewStudyGroupTextBoxEnter(object sender, EventArgs e)
        {
            addNewStudyGroupTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на все элементы формы.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FormElementsOnClick(object sender, EventArgs e)
        {
            ActiveControl = null;
            addNewStudyGroupTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Метод, который обрабатывает ввод символов в addNewStudyGroupTextBox.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AddNewStudyGroupTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '\b'))
            {
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Конструкторы
        public AddNewStudyGroup(ComboBox groupSelectionComboBox)
        {
            InitializeComponent();

            ActiveControl = null;
            this.groupSelectionComboBox = groupSelectionComboBox;
        }
        #endregion
    }
}