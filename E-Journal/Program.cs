using System.Windows.Forms;
using System;

namespace ElectronicDiary
{
    internal static class Program
    {
        #region Поля
        static bool isEntryAllowed;
        static bool isAdmin;
        static int userId;
        #endregion

        #region Методы
        /// <summary>
        /// Метод, который передает данные о входе в аккаунт.
        /// </summary>
        /// <param name="isEntryAllowed"> Разрешен ли вход. </param>
        /// <param name="isAdmin"> Является ли пользователь администратором. </param>
        /// <param name="userId"> Идентификатор пользователя. </param>
        public static void SetLoginInformation(bool isEntryAllowed, bool isAdmin = false, int userId = -1)
        {
            Program.isEntryAllowed = isEntryAllowed;
            Program.isAdmin = isAdmin;
            Program.userId = userId;
        }

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            do
            {
                isEntryAllowed = false;
                Application.Run(new ElectronicDiaryLoginForm());

                if (isEntryAllowed)
                {
                    isEntryAllowed = false;

                    if (isAdmin)
                    {
                        Application.Run(new AdministratorFormOfElectronicDiary());
                    }
                    else
                    {
                        Application.Run(new StudentFormOfElectronicDiary(userId));
                    }
                }
            }
            while (isEntryAllowed);
        }
        #endregion
    }
}