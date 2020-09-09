using System.Collections.ObjectModel;
using Newtonsoft.Json;

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
        /// Количество удалённых тегов (доступно для премиума)
        /// </summary>
        [JsonProperty("deletedTags")]
        public string DeletedTags { get; protected set; }
    }
}