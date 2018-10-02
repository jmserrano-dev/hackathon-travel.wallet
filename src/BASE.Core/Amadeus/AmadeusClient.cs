using System.Threading.Tasks;
using BASE.Core.Amadeus.Requests;
using BASE.Core.Amadeus.Responses;
using BASE.Cross;

namespace BASE.Core.Amadeus
{
    public class AmadeusClient : ApiClient
    {
        private const string BaseAddress = "";
        private string AccessToken;

        public AmadeusClient() : base(BaseAddress) { }

        public async Task<string> GetAccessTokenAuthentication()
        {
            const string uri = "security/oauth2/token";

            var request = new AuthenticationRequest
            {
                client_id = "qGXAuT2GmMXfJQbBCMCiUhN1df86z6pK",
                client_secret = "nexTXAUHxABQWvm6",
                grant_type = "client_credentials"
            };

            var response = await PostAsync<AuthenticationResponse>(uri, request);
            AccessToken = response.access_token;

            return AccessToken;
        }
    }
}
