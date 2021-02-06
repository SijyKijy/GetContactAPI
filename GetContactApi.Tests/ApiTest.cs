using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GetContactAPI;
using Xunit;

namespace GetContactApi.Tests
{
    public class ApiTest
    {
        private readonly GetContact _api = new(new("token", "superrandomaeskeyfortestplsineed64symbolok?1010101010101010done!"));

        public static IEnumerable<object[]> Phone()
        {
            yield return new object[] { "+01234567890" };
        }

        [Theory]
        [MemberData(nameof(Phone))]
        public async Task GetByPhone(string phone)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            var result = await _api.GetByPhoneAsync(phone, source.Token);

            Assert.NotNull(result);
        }

        [Theory]
        [MemberData(nameof(Phone))]
        public async Task GetTags(string phone)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            var result = await _api.GetTagsAsync(phone, source.Token);

            Assert.NotNull(result);
        }
    }
}
