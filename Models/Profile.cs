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
        public string DisplayName { get; protected set; }

        /// <summary>
        /// Имя
        /// <para/>Лучше брать значение из <see cref="DisplayName"/>, если там ничего не будет, то смотреть тут и в <seealso cref="Surname"/>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Фамилия
        /// <para/>Лучше брать значение из <see cref="DisplayName"/>, если там ничего не будет, то смотреть тут и в <seealso cref="Name"/>
        /// </summary>
        [JsonProperty("surname")]
        public string Surname { get; protected set; }

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

        /// <summary>
        /// Номер телефона
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; protected set; }

        /// <summary>
        /// Картинка профиля, не уверен что бывает
        /// </summary>
        [JsonProperty("profileImage")]
        public string ProfileImage { get; protected set; }
    }
}