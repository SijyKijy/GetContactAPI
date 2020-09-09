using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SubscriptionUsageInfo
    {
        /// <summary>
        /// Количество оставшихся запросов
        /// </summary>
        [JsonProperty("remainingCount")]
        public int RemainingCount { get; protected set; }
        
        /// <summary>
        /// Максимум запросов
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; protected set; }
        
        [JsonProperty("isColorRed")]
        public bool IsColorRed { get; protected set; }
        
        [JsonProperty("showOffer")]
        public bool ShowOffer { get; protected set; }
        
        [JsonProperty("showPackages")]
        public bool ShowPackages { get; protected set; }
    }
}