using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class SearchResult
    {
        /// <summary>
        /// Основной профиль пользователя
        /// </summary>
        [JsonPropertyName("profile")]
        public Profile Profile { get; protected set; }
        /// <summary>
        /// Информация о подписке
        /// </summary>
        [JsonPropertyName("subscriptionInfo")]
        public SubscriptionInfo SubscriptionInfo { get; protected set; }

        [JsonPropertyName("spamInfo")]
        public SpamInfo SpamInfo { get; protected set; }

        [JsonPropertyName("searchedHimself")]
        public bool SearchedHimself { get; protected set; }
    }
}