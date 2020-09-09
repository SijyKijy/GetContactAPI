using Newtonsoft.Json;

namespace GetContactAPI.Models
{
    public class ApiResponse<T>
    {
        /// <summary>
        /// Результат
        /// </summary>
        [JsonProperty("result")]
        public T Response { get; protected set; }
        
        // возможно что тут должно быть что-то ещё, но я не ковырял API
    }
}