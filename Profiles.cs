using System.Collections.Generic;

namespace GetContactAPI
{
    /// <summary>
    /// Основной профиль пользователя
    /// </summary>
    public class MainProfile
    {
        /// <summary>
        /// Имена пользователя
        /// </summary>
        public string Name { get; internal set; }
        /// <summary>
        /// Страна пользователя
        /// </summary>
        public string Country { get; internal set; }
        /// <summary>
        /// Количество найденных тегов
        /// </summary>
        public string TagCount { get; internal set; }
        /// <summary>
        /// Количество оставшихся запросов / максимальных запросов
        /// </summary>
        public string[] DefaultSearchCount { get; internal set; }
        /// <summary>
        /// Количество оставшихся запросов для тегов / максимальных запросов
        /// </summary>
        public string[] TagSearchCount { get; internal set; }
    }

    /// <summary>
    /// Профиль для тегов
    /// </summary>
    public class TagProfile
    {
        /// <summary>
        /// Список тегов
        /// </summary>
        public List<string> Tags { get; internal set; }
        /// <summary>
        /// Количество удалённых тегов (доступно для премиума)
        /// </summary>
        public string DeletedTags { get; internal set; }
    }
}
