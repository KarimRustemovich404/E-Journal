using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace ElectronicDiary
{
    internal static class Program
    {
        private static string accountInformation = String.Empty;

        public static void SettingAccountInformationValue(string accountInformation)
        {
            Program.accountInformation = accountInformation;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new AdministratorFormOfElectronicDiary());

            //Application.Run(new ElectronicDiaryLoginForm());

            //if (accountInformation != String.Empty)
            //{
            //    if (accountInformation.Contains("Admin"))
            //    {
            //        Application.Run(new AdministratorFormOfElectronicDiary());
            //    }

            //    else
            //    {
            //        Application.Run(new StudentFormOfElectronicDiary(accountInformation));
            //    }
            //}

        }
    }
}