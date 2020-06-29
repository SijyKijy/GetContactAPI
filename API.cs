using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GetContactAPI
{
    public class API
    {
        private readonly Topic topic;

        public API(Data data)
        {
            this.topic = new Topic(data);
        }

        /// <summary>
        /// Возвращает основную информацию по номеру телефону
        /// </summary>
        public MainProfile GetByPhone(string phone)
        {
            if (String.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, "\\+?\\d{11}")) throw new ArgumentException("Телефон заполнен неправильно");
            JObject data = topic.CreateTopic("https://pbssrv-centralevents.com/v2.5/search", "search", phone);

            return new MainProfile()
            {
                Name = data["result"]["profile"]["displayName"].ToString(),
                Country = data["result"]["profile"]["countryCode"].ToString(),
                TagCount = data["result"]["profile"]["tagCount"].ToString(),
                DefaultSearchCount = new string[2] { data["result"]["subscriptionInfo"]["usage"]["search"]["remainingCount"].ToString(), data["result"]["subscriptionInfo"]["usage"]["search"]["limit"].ToString() },
                TagSearchCount = new string[2] { data["result"]["subscriptionInfo"]["usage"]["numberDetail"]["remainingCount"].ToString(), data["result"]["subscriptionInfo"]["usage"]["numberDetail"]["limit"].ToString() }
            };
        }

        /// <summary>
        /// Возвращает список тегов
        /// </summary>
        public TagProfile GetTags(string phone)
        {
            if (String.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, "\\+?\\d{11}")) throw new ArgumentException("Телефон заполнен неправильно");
            JObject data = topic.CreateTopic("https://pbssrv-centralevents.com/v2.5/number-detail", "details", phone);

            List<string> tags = new List<string>();
            data["result"]["tags"].ToList().ForEach(a => tags.Add(a["tag"].ToString()));

            return new TagProfile()
            {
                Tags = tags,
                DeletedTags = data["result"]["deletedTags"].ToString()
            };
        }
    }
}
