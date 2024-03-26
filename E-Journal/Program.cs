using System.Windows.Forms;
using System;

namespace ElectronicDiary
{
    internal static class Program
    {
        #region Поля
        private static string accountInformation = String.Empty;
        #endregion

        #region Методы
        /// <summary>
        /// Метод, который передает данные из формы ElectronicDiaryLoginForm.
        /// </summary>
        /// <param name="accountInformation"></param>
        public static void SettingAccountInformationValue(string accountInformation)
        {
            Program.accountInformation = accountInformation;
        }

        /// <summary>
        /// Метод, который является точкой входа в программу.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new ElectronicDiaryLoginForm());

            if (accountInformation != String.Empty)
            {
                if (accountInformation.Contains("Admin"))
                {
                    Application.Run(new AdministratorFormOfElectronicDiary());
                }
                else
                {
                    Application.Run(new StudentFormOfElectronicDiary(accountInformation));
                }
            }

        }
        #endregion
    }
}