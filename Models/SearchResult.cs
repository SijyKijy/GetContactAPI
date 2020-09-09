using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SearchResult
    {
        /// <summary>
        /// Основной профиль пользователя
        /// </summary>
        [JsonProperty("profile")]
        public Profile Profile { get; protected set; }
        /// <summary>
        /// Информация о подписке
        /// </summary>
        [JsonProperty("subscriptionInfo")]
        public SubscriptionInfo SubscriptionInfo { get; protected set; }
        
        [JsonProperty("spamInfo")]
        public SpamInfo SpamInfo { get; protected set; }
        
        [JsonProperty("searchedHimself")]
        public bool SearchedHimself { get; protected set; }
    }
}