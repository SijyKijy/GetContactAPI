using Newtonsoft.Json;
using System;

namespace GetContactAPI.Models
{
    public class SubscriptionInfo
    {
        /// <summary>
        /// Лимиты
        /// </summary>
        [JsonProperty("usage")]
        public SubscriptionUsage Usage { get; protected set; }

        [JsonProperty("isPro")]
        public bool IsPro { get; protected set; }

        [JsonProperty("isTrialUsed")]
        public bool IsTrialUsed { get; protected set; }

        [JsonProperty("premiumType")]
        public string PremiumType { get; protected set; } // кому не впадлу, сделайте Enum'ом, только вытащите все типы

        [JsonProperty("premiumTypeName")]
        public string PremiumTypeName { get; protected set; }

        [JsonProperty("receiptEndDate")]
        public DateTime ReceiptEndDate { get; protected set; }

        [JsonProperty("receiptStartDate")]
        public DateTime ReceiptStartDate { get; protected set; }

        [JsonProperty("renewDate")]
        public DateTime RenewDate { get; protected set; }
    }
}