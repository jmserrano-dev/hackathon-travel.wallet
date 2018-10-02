using System.Collections.Generic;

namespace BASE.Application.Client.Recommendations.Hotels
{
    public class HotelsResponse
    {
        public IEnumerable<Hotel> Hotels { get; set; }
    }
}