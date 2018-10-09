using BASE.Core.Avuxi.Requests;
using BASE.Core.Avuxi.Respones;
using BASE.Cross;
using Newtonsoft.Json;

namespace BASE.Core.Avuxi
{
    public class AvuxiClient : ApiClient
    {
        private string AppKey = "APP_KEY";

        private const string BaseAddress = "https://data.avuxiapis.com";

        public AvuxiClient() : base(BaseAddress) { }

        public GetNearbyInfoResponse GetNearbyInfo(GetNearbyInfoRequest request)
        {
            string uri = $"v1/GetNearbyInfo?key={AppKey}&latitude={request.Latitude}&longitude={request.Longitude}&Type={request.Type.Name}&language={request.Language}";

            var data = GetAsync<object>(uri).Result;
            var dic = JsonConvert.DeserializeObject<GetNearbyInfoResponse>(data.ToString());

            return dic;
        }

        public GetMetroLinesByCityCenterResponse GetMetroLinesByCityCenter(GetMetroLinesByCityCenterRequest request)
        {
            string uri = $"v1/GetMetroLinesByCityCenter?key={AppKey}&latitude={request.Latitude}&longitude={request.Longitude}";

            var data = GetAsync<object>(uri).Result;
            var result = JsonConvert.DeserializeObject<GetMetroLinesByCityCenterResponse>(data.ToString());

            return result;
        }
    }
}
