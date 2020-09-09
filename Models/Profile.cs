using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    /// <summary>
    /// Основной профиль пользователя
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Имена пользователя
        /// </summary>
        [JsonProperty("displayName")]
        public string Name { get; protected set; }
        /// <summary>
        /// Страна пользователя
        /// </summary>
        [JsonProperty("countryCode")]
        public string Country { get; protected set; }
        /// <summary>
        /// Количество найденных тегов
        /// </summary>
        [JsonProperty("tagCount")]
        public int? TagCount { get; protected set; }
    }
}