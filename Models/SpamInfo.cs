using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SpamInfo
    {
        [JsonProperty("type")]
        public string Type { get; protected set; }

        [JsonProperty("degree")]
        public string Degree { get; protected set; }
    }
}