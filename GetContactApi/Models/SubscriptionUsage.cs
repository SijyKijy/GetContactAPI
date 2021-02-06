using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class SubscriptionUsage
    {
        /// <summary>
        /// Лимиты на поиск
        /// </summary>
        [JsonPropertyName("search")]
        public SubscriptionUsageInfo Search { get; protected set; }

        /// <summary>
        /// Лимиты на теги/детали о номере
        /// </summary>
        [JsonPropertyName("numberDetail")]
        public SubscriptionUsageInfo NumberDetail { get; protected set; }

        [JsonPropertyName("callBenefits")]
        public SubscriptionUsageInfo CallBenefits { get; protected set; }

        [JsonPropertyName("dailySearch")]
        public SubscriptionUsageInfo DailySearch { get; protected set; }

        [JsonPropertyName("share")]
        public SubscriptionUsageInfo Share { get; protected set; }

        [JsonPropertyName("trustScore")]
        public SubscriptionUsageInfo TrustScore { get; protected set; }
    }
}