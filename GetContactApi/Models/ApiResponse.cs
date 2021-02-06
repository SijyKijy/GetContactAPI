using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class ApiResponse<T>
    {
        /// <summary>
        /// Результат
        /// </summary>
        [JsonPropertyName("result")]
        public T Response { get; protected set; }

        /// <summary>
        /// Статус ответа
        /// </summary>
        [JsonPropertyName("meta")]
        public Meta Meta { get; protected set; }

        /// <summary>
        /// Информация о подписке (вот тут оно на сколько понимаю, бывает только когда ошибка)
        /// </summary>
        [JsonPropertyName("subscriptionInfo")]
        public SubscriptionInfo SubscriptionInfo { get; protected set; }
    }
}