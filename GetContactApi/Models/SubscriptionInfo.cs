using System;
using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class SubscriptionInfo
    {
        /// <summary>
        /// Лимиты
        /// </summary>
        [JsonPropertyName("usage")]
        public SubscriptionUsage Usage { get; protected set; }

        [JsonPropertyName("isPro")]
        public bool IsPro { get; protected set; }

        [JsonPropertyName("isTrialUsed")]
        public bool IsTrialUsed { get; protected set; }

        [JsonPropertyName("premiumType")]
        public string PremiumType { get; protected set; }

        [JsonPropertyName("premiumTypeName")]
        public string PremiumTypeName { get; protected set; }

        [JsonPropertyName("receiptEndDate")]
        public DateTime ReceiptEndDate { get; protected set; }

        [JsonPropertyName("receiptStartDate")]
        public DateTime ReceiptStartDate { get; protected set; }

        [JsonPropertyName("renewDate")]
        public DateTime RenewDate { get; protected set; }
    }
}