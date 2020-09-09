using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SubscriptionInfo
    {
        /// <summary>
        /// Лимиты
        /// </summary>
        [JsonProperty("usage")]
        public SubscriptionUsage Usage { get; protected set; }
    }
}