using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GetContactAPI.Models;

namespace GetContactAPI
{
    public class GetContact
    {
        private readonly Topic _topic;
        private readonly Regex _phoneRegex;

        public GetContact(Data data)
        {
            _topic = new Topic(data);
            _phoneRegex = new("\\+?\\d{10,11}", RegexOptions.Compiled);
        }

        /// <summary>
        /// Возвращает основную информацию по номеру телефону
        /// </summary>
        public Task<ApiResponse<SearchResult>> GetByPhoneAsync(string phone, CancellationToken cancellationToken, string countryCode = null)
        {
            if (string.IsNullOrEmpty(phone) || !_phoneRegex.IsMatch(phone)) throw new ArgumentException("Телефон заполнен неправильно");
            return _topic.CreateTopicAsync<SearchResult>("https://pbssrv-centralevents.com/v2.5/search", "search", phone, countryCode, cancellationToken);
        }

        /// <summary>
        /// Возвращает список тегов
        /// </summary>
        public Task<ApiResponse<DetailsResult>> GetTagsAsync(string phone, CancellationToken cancellationToken, string countryCode = null)
        {
            if (string.IsNullOrEmpty(phone) || !_phoneRegex.IsMatch(phone)) throw new ArgumentException("Телефон заполнен неправильно");
            return _topic.CreateTopicAsync<DetailsResult>("https://pbssrv-centralevents.com/v2.5/number-detail", "details", phone, countryCode, cancellationToken);
        }
    }
}
