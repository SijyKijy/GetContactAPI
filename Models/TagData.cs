using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class TagData
    {
        /// <summary>
        /// Тег
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; protected set; }
    }
}