using Newtonsoft.Json.Linq;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace GetContactAPI
{
    internal class Topic
    {
        private readonly Data aData;

        public Topic(Data data)
        {
            aData = data;
        }

        /// <summary>
        /// Формирование зашифрованного запроса
        /// </summary>
        /// <returns>Получение дешифрованного запроса в формате json</returns>
        public JObject CreateTopic(string url, string source, string phone)
        {
            string ts = ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString(); // timespan (Unix)
            string req = "{" + $"\"countryCode\":\"RU\",\"source\":\"{source}\",\"token\":\"{aData.Token}\",\"phoneNumber\":\"{phone}\"" + "}";
            string sig = Crypt.EncryptToSHA256(ts.Replace("\r\n", "") + "-" + req, aData.Key); // signature
            string crypt = Crypt.EncryptAes256ECB(req, aData.AesKey);

            return SendPost(url, "{\"data\":\"" + crypt + "\"}", ts, sig);
        }

        /// <summary>
        /// Отправка готового запроса на сервер, с последующей дешифровкой
        /// </summary>
        private JObject SendPost(string url, string data, string ts, string sig)
        {
            using (WebClient client = new WebClient { Encoding = Encoding.UTF8 })
            {
                client.Headers.Add(new NameValueCollection()
                {
                    {"X-App-Version", "4.9.1"},
                    {"X-Token", aData.Token},
                    {"X-Os", "android 5.0"},
                    {"X-Client-Device-Id", "14130e29cebe9c39"},
                    {"Content-Type", "application/json; charset=utf-8"},
                    {"Accept-Encoding", "deflate"},
                    {"X-Req-Timestamp", ts},
                    {"X-Req-Signature", sig},
                    {"X-Encrypted", "1"}
                });
                return JObject.Parse(
                    Crypt.DecryptAes256ECB( // Расшифровываем полученный запрос
                        JObject.Parse(
                            client.UploadString(url, data))["data"].ToString(), aData.AesKey)); // Отправляем запрос
            }
        }
    }
}
