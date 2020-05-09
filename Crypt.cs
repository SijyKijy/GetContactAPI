using System;
using System.Security.Cryptography;
using System.Text;

namespace GetContactAPI
{
    internal static class Crypt
    {
        /// <summary>
        /// Преобразование строки в шестнадцатеричную
        /// </summary>
        public static byte[] StringToByteArray(string hex)
        {
            if (hex.Length % 2 == 1) throw new ArgumentException("Шестнадцатеричная строка должна иметь четное количество цифр!");
            byte[] arr = new byte[hex.Length >> 1];
            for (int i = 0; i < hex.Length >> 1; ++i) arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            return arr;
        }

        private static int GetHexVal(char hex)
        {
            int val = (int)hex;
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

        /// <summary>
        /// Шифрование в SHA256
        /// </summary>
        public static string EncryptToSHA256(string str, string key)
        {
            byte[] bkey = Encoding.Default.GetBytes(key);
            using (var hmac = new HMACSHA256(bkey))
            {
                byte[] bstr = Encoding.Default.GetBytes(str);
                return Convert.ToBase64String(hmac.ComputeHash(bstr));
            }
        }

        /// <summary>
        /// Шифрование в AES-256-ECB
        /// </summary>
        public static string EncryptAes256ECB(string str, string aesKey)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = StringToByteArray(aesKey);
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.ECB;

                ICryptoTransform transform = aes.CreateEncryptor();
                return Convert.ToBase64String(transform.TransformFinalBlock(Encoding.UTF8.GetBytes(str), 0, str.Length));
            }
        }

        /// <summary>
        /// Дешифровка AES-256-ECB
        /// </summary>
        public static string DecryptAes256ECB(string str, string aesKey)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.ECB;
                aes.Key = StringToByteArray(aesKey);

                ICryptoTransform transform = aes.CreateDecryptor();
                byte[] encBytes = Convert.FromBase64String((string)str);
                return ASCIIEncoding.ASCII.GetString(transform.TransformFinalBlock(encBytes, 0, encBytes.Length));
            }
        }
    }
}
