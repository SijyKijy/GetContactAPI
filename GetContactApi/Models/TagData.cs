using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class TagData
    {
        /// <summary>
        /// Тег
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; protected set; }

        [JsonPropertyName("count")]
        public int Count { get; protected set; }

        [JsonPropertyName("isNew")]
        public bool IsNew { get; protected set; }

        [JsonPropertyName("removable")]
        public bool Removable { get; protected set; }

        [JsonPropertyName("askReason")]
        public bool AskReason { get; protected set; }
    }
}