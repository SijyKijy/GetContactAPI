using System.Text.Json.Serialization;

namespace GetContactAPI.Models
{
    public class SpamInfo
    {
        [JsonPropertyName("type")]
        public string Type { get; protected set; }

        [JsonPropertyName("degree")]
        public string Degree { get; protected set; }
    }
}