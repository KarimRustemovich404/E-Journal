using System.Security.Cryptography;
using System.Text;
using System;

namespace ElectronicDiary.Database
{
    internal static class DataEncryption
    {
        public static string HashingData(string dataString)
        {
            MD5 mD5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(dataString);
            byte[] nash = mD5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (var a in nash)
            {
                sb.Append(a.ToString("X2"));
            }

            return Convert.ToString(sb);
        }
    }
}
