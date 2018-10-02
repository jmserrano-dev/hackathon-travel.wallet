using BASE.Cross;

namespace BASE.Core.BBVA
{
    public class BBVAClienInformation : ApiClient
    {
        private const string BaseAddress = "https://apis.bbva.com/customers-sbx/v1/me-basic";

        public BBVAClienInformation() : base(BaseAddress) { }
    }
}
