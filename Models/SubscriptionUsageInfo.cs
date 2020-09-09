using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SubscriptionUsageInfo
    {
        /// <summary>
        /// Количество оставшихся запросов
        /// </summary>
        [JsonProperty("remainingCount")]
        public int? RemainingCount { get; protected set; }
        
        /// <summary>
        /// Максимум запросов
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; protected set; }
    }
}