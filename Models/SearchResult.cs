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
        /// Информация о подписке (пока что только лимиты)
        /// </summary>
        [JsonProperty("subscriptionInfo")]
        public SubscriptionInfo SubscriptionInfo { get; protected set; }
    }
}