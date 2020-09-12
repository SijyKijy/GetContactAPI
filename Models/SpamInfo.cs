using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class SpamInfo
    {
        // тут можно тоже всё на enum'ы переделать, но мне лень узнавать значения

        [JsonProperty("type")]
        public string Type { get; protected set; }

        [JsonProperty("degree")]
        public string Degree { get; protected set; }
    }
}