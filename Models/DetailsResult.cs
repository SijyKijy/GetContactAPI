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
        
        /* Пока убрал т.к. там массив, а чё за тип данных в массиве я не знаю
         *
         * /// <summary>
        /// Удалённые теги (доступно для премиума)
        /// </summary>
        [JsonProperty("deletedTags")]
        public string DeletedTags { get; protected set; }*/
        
        /// <summary>
        /// Количество удалённых тегов (доступно для премиума)
        /// </summary>
        [JsonProperty("deletedTagCount")]
        public int DeletedTagCount { get; protected set; }
    }
}