using System;

namespace GetContactAPI
{
    /// <summary>
    /// Главные данные для работы API
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Токен из конфиг-файла
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Зашифрованный ключ из конфиг-файла
        /// </summary>
        /// <remarks>
        /// Длина - 64 символа
        /// </remarks>
        public string AesKey { get; }

        /// <summary>
        /// Ключ шифрования
        /// </summary>
        public string Key { get; } = "2Wq7)qkX~cp7)H|n_tc&o+:G_USN3/-uIi~>M+c ;Oq]E{t9)RC_5|lhAA_Qq%_4";

        public Data(string token, string aesKey)
        {
            Token = token;
            AesKey = aesKey;
            Validate();
        }

        public Data(string token, string aesKey, string key)
        {
            Token = token;
            AesKey = aesKey;
            Key = key;
            Validate();
        }

        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(Token))
                throw new ArgumentNullException("Token is empty or invalid");

            if (string.IsNullOrWhiteSpace(AesKey) || AesKey.Length != 64)
                throw new ArgumentNullException("AES key is empty or invalid");
        }
    }
}
