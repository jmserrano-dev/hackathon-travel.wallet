using System.Net.Sockets;
using System.Threading.Tasks;
using BASE.Core.BBVA.Responses;
using BASE.Cross;

namespace BASE.Core.BBVA
{
    public class BBVAuthClient : ApiClient
    {
        private const string Adress = "https://connect.bbva.com/token?grant_type=client_credentials";

        public BBVAuthClient(string token) : base(Adress, null, token)
        {
        }

        public async Task<AuthorizationResponse> GetCredentials()
        {
            var result = await this.AuthenticationPostAsync<AuthorizationResponse>(Adress);
            return result;
        }
    }
}