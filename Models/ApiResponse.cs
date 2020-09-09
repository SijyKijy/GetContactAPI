using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class ApiResponse<T>
    {
        /// <summary>
        /// Результат
        /// </summary>
        [JsonProperty("result")]
        public T Response { get; protected set; }
        
        /// <summary>
        /// Статус ответа
        /// </summary>
        [JsonProperty("meta")]
        public Meta Meta { get; protected set; }

        /// <summary>
        /// Информация о подписке (вот тут оно на сколько понимаю, бывает только когда ошибка)
        /// </summary>
        [JsonProperty("subscriptionInfo")]
        public SubscriptionInfo SubscriptionInfo { get; protected set; }
        
        /* При ошибке ещё бывает такое поле
         * adSettings - инфа по рекламе (не думаю что оно нужно)
         */
    }
}