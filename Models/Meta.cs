using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class Meta
    {
        /// <summary>
        /// Код ошибки, если всё ок, должно быть null
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; protected set; }

        /// <summary>
        /// Сообщение об ошибке, если всё ок, должно быть null
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; protected set; }

        /// <summary>
        /// Хранит в себе тоже самое что и HTTP код ответа
        /// </summary>
        [JsonProperty("httpStatusCode")]
        public int HttpStatusCode { get; protected set; }

        /// <summary>
        /// ID запроса
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; protected set; }

        /// <summary>
        /// Произошла ошибка или нет
        /// </summary>
        [JsonIgnore]
        public bool IsRequestError => HttpStatusCode != 200 || !string.IsNullOrEmpty(ErrorCode) || !string.IsNullOrEmpty(ErrorMessage);
    }
}