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

        [JsonProperty("callBenefits")]
        public SubscriptionUsageInfo CallBenefits { get; protected set; }

        [JsonProperty("dailySearch")]
        public SubscriptionUsageInfo DailySearch { get; protected set; }

        [JsonProperty("share")]
        public SubscriptionUsageInfo Share { get; protected set; }

        [JsonProperty("trustScore")]
        public SubscriptionUsageInfo TrustScore { get; protected set; }
    }
}