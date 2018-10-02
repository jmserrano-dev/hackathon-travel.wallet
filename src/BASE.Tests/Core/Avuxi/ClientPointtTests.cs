using BASE.Core.Avuxi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BASE.Tests.Core.Avuxi
{
    [TestClass]
    public class ClientPointtTests
    {
        [TestMethod]
        public void Should_be_return_a_neraby_info()
        {
            var client = new AvuxiClient();
            var result = client.GetNearbyInfo(new BASE.Core.Avuxi.Requests.GetNearbyInfoRequest()
            {
                Language = "es",
                Latitude = "41.388722",
                Longitude = "2.168169",
                Type = BASE.Core.Avuxi.Requests.Type.Rank12
            });

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Should_be_return_a_metro_lines_by_city_center()
        {
            var client = new AvuxiClient();
            var result = client.GetMetroLinesByCityCenter(new BASE.Core.Avuxi.Requests.GetMetroLinesByCityCenterRequest()
            {
                Longitude = "2.168169",
                Latitude = "41.388722"
            });
            Assert.IsNotNull(result);
        }
    }
}
