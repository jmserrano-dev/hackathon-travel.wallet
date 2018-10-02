using System.Threading.Tasks;
using BASE.Core.Amadeus.Requests;
using BASE.Core.Amadeus.Responses;
using BASE.Cross;

namespace BASE.Core.Amadeus
{
    public class AmadeusClient : ApiClient
    {
        private const string BaseAddress = "https://test.api.amadeus.com/v1/";

        public AmadeusClient() : base(BaseAddress) { }

        public async Task<string> GetAuthentication()
        {
            const string uri = "security/oauth2/token";

            var request = new AuthenticationRequest
            {
                client_id = "TBdD2XwOaUqSBDrWlVDN8DnoPpkVT4BL",
                client_secret = "3DWtRAnlHGsZ3joE",
                grant_type = "client_credentials"
            };

            var response = await AuthenticationPostAsync<AuthenticationResponse>(uri, request);
            return response.access_token;
        }

        public async Task<HotelsResponse> GetHotels(string accessToken, HotelsRequest request)
        {
            AddBearerAuthorization(accessToken);

            const string uri = "shopping/hotel-offers?cityCode=MUC";
            var response = await GetAsync<HotelsResponse>(uri);
            return response;
        }
    }
}
