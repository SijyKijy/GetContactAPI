using GetContactAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Specialized;
using System.IO;
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
        public ApiResponse<T> CreateTopic<T>(string url, string source, string phone, string countryCode)
        {
            string ts = ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString(); // timespan (Unix)
            var reqObj = new
            {
                countryCode = countryCode ?? "RU",
                source,
                token = aData.Token,
                phoneNumber = phone
            };
            string req = JsonConvert.SerializeObject(reqObj, Formatting.None);
            string sig = Crypt.EncryptToSHA256(ts.Replace("\r\n", "") + "-" + req, aData.Key); // signature
            string crypt = Crypt.EncryptAes256ECB(req, aData.AesKey);

            return SendPost<T>(url, "{\"data\":\"" + crypt + "\"}", ts, sig);
        }

        /// <summary>
        /// Отправка готового запроса на сервер, с последующей дешифровкой
        /// </summary>
        private ApiResponse<T> SendPost<T>(string url, string data, string ts, string sig)
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

                string rawJsonResponse;
                try
                {
                    rawJsonResponse = client.UploadString(url, data); // отправляем запрос
                }
                catch (WebException webEx)
                {
                    // вытаскиваем ответ при ошибке
                    using (var rs = webEx.Response.GetResponseStream())
                    {
                        if (rs == null)
                            throw;

                        using (var sr = new StreamReader(rs))
                            rawJsonResponse = sr.ReadToEnd();
                    }
                }

                var rawResponse = JObject.Parse(rawJsonResponse);
                if (!rawResponse.TryGetValue("data", StringComparison.Ordinal, out var rawData))
                    throw new ApplicationException("Failed to get \"data\" from response!");

                var decryptedResponse = Crypt.DecryptAes256ECB(rawData.ToString(), aData.AesKey); // расшифровывем
                return JsonConvert.DeserializeObject<ApiResponse<T>>(decryptedResponse);
            }
        }
    }
}
