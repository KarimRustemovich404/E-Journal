using System.Windows.Forms;
using System;

namespace E_Journal
{
    internal static class Program
    {
        public static string informationAboutAccount = String.Empty;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ElectronicDiaryLoginForm());

            if (informationAboutAccount != String.Empty)
            {
                if (informationAboutAccount.Contains("Admin"))
                {
                    Application.Run(new AdministratorFormOfElectronicDiary());
                }

                else
                {
                    Application.Run(new StudentFormOfElectronicDiary());
                }
            }
        }
    }
}