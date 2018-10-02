using System;
using System.Collections.Generic;
using System.Text;

namespace BASE.Core.Amadeus.Requests
{
    public class AuthenticationRequest
    {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string grant_type { get; set; }
    }
}
