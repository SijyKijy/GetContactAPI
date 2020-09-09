using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SubscriptionUsage
    {
        /// <summary>
        /// Лимиты на поиск
        /// </summary>
        [JsonProperty("search")]
        public SubscriptionUsageInfo Search { get; protected set; }
        /// <summary>
        /// Лимиты на теги/детали о номере
        /// </summary>
        [JsonProperty("numberDetail")]
        public SubscriptionUsageInfo NumberDetail { get; protected set; }
    }
}