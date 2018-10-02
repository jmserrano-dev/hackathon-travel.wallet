namespace BASE.Core.Amadeus.Responses
{
    public class AuthenticationResponse
    {
        public string type { get; set; }
        public string username { get; set; }
        public string application_name { get; set; }
        public string client_id { get; set; }
        public string token_type { get; set; }
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string state { get; set; }
        public string scope { get; set; }
    }
}
