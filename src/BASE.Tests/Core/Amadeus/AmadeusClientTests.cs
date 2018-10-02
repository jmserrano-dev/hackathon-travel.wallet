using BASE.Core.Amadeus;
using BASE.Core.Amadeus.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BASE.Tests.Core.Amadeus
{
    [TestClass]
    public class AmadeusClientTests
    {
        private readonly AmadeusClient _client;

        public AmadeusClientTests()
        {
            _client = new AmadeusClient();
        }

        [TestMethod]
        public void Should_be_return_a_valid_access_token()
        {
            var accessToken = _client.GetAuthentication().Result;

            Assert.IsNotNull(accessToken);
        }

        [TestMethod]
        public void Should_be_return_hotels_by_location()
        {
            var accessToken = _client.GetAuthentication().Result;
            var request = new HotelsRequest { cityCode = "MUC" };

            var hotels = _client.GetHotels(accessToken, request).Result;

            Assert.IsNotNull(hotels.data);
        }
    }
}
