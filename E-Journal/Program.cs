using System.Windows.Forms;
using System;

namespace ElectronicDiary
{
    internal static class Program
    {
        #region ����
        static bool isEntryAllowed;
        static bool isAdmin;
        static int userId;
        #endregion

        #region ������
        /// <summary>
        /// �����, ������� �������� ������ � ����� � �������.
        /// </summary>
        /// <param name="isEntryAllowed"> �������� �� ����. </param>
        /// <param name="isAdmin"> �������� �� ������������ ���������������. </param>
        /// <param name="userId"> ������������� ������������. </param>
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