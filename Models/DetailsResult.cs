using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace GetContactAPI.Models
{
    public class DetailsResult
    {
        /// <summary>
        /// Список тегов
        /// </summary>
        [JsonProperty("tags")]
        public ReadOnlyCollection<TagData> Tags { get; protected set; }

        /// <summary>
        /// Удалённые теги (доступно для премиума)
        /// </summary>
        [JsonProperty("deletedTags")]
        public ReadOnlyCollection<string> DeletedTags { get; protected set; }

        /// <summary>
        /// Количество удалённых тегов (доступно для премиума)
        /// </summary>
        [JsonProperty("deletedTagCount")]
        public int DeletedTagCount { get; protected set; }
    }
}