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

            byte[] dataInBytesArray = Encoding.ASCII.GetBytes(dataString);
            byte[] hashedDataArray = mD5.ComputeHash(dataInBytesArray);
            StringBuilder hashedDataString = new StringBuilder();

            foreach (var element in hashedDataArray)
            {
                hashedDataString.Append(element.ToString("X2"));
            }

            return Convert.ToString(hashedDataString) ?? String.Empty;
        }
    }
}