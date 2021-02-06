using System.Text.Json.Serialization;

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
        [JsonPropertyName("displayName")]
        public string DisplayName { get; protected set; }

        /// <summary>
        /// Имя
        /// <para/>Лучше брать значение из <see cref="DisplayName"/>, если там ничего не будет, то смотреть тут и в <seealso cref="Surname"/>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Фамилия
        /// <para/>Лучше брать значение из <see cref="DisplayName"/>, если там ничего не будет, то смотреть тут и в <seealso cref="Name"/>
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; protected set; }

        /// <summary>
        /// Страна пользователя
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string Country { get; protected set; }

        /// <summary>
        /// Количество найденных тегов
        /// </summary>
        [JsonPropertyName("tagCount")]
        public int? TagCount { get; protected set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; protected set; }

        /// <summary>
        /// Картинка профиля, не уверен что бывает
        /// </summary>
        [JsonPropertyName("profileImage")]
        public string ProfileImage { get; protected set; }
    }
}