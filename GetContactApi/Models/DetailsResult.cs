using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class DetailsResult
    {
        /// <summary>
        /// Список тегов
        /// </summary>
        [JsonPropertyName("tags")]
        public ReadOnlyCollection<TagData> Tags { get; protected set; }

        /// <summary>
        /// Удалённые теги (доступно для премиума)
        /// </summary>
        [JsonPropertyName("deletedTags")]
        public ReadOnlyCollection<string> DeletedTags { get; protected set; }

        /// <summary>
        /// Количество удалённых тегов (доступно для премиума)
        /// </summary>
        [JsonPropertyName("deletedTagCount")]
        public int DeletedTagCount { get; protected set; }
    }
}