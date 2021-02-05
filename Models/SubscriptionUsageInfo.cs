using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class SubscriptionUsageInfo
    {
        /// <summary>
        /// Количество оставшихся запросов
        /// </summary>
        [JsonPropertyName("remainingCount")]
        public int RemainingCount { get; protected set; }

        /// <summary>
        /// Максимум запросов
        /// </summary>
        [JsonPropertyName("limit")]
        public int Limit { get; protected set; }

        [JsonPropertyName("isColorRed")]
        public bool IsColorRed { get; protected set; }

        [JsonPropertyName("showOffer")]
        public bool ShowOffer { get; protected set; }

        [JsonPropertyName("showPackages")]
        public bool ShowPackages { get; protected set; }
    }
}