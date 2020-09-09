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
        
        [JsonProperty("count")]
        public int Count { get; protected set; }
        
        [JsonProperty("isNew")]
        public bool IsNew { get; protected set; }
        
        [JsonProperty("removable")]
        public bool Removable { get; protected set; }
        
        [JsonProperty("askReason")]
        public bool AskReason { get; protected set; }
    }
}