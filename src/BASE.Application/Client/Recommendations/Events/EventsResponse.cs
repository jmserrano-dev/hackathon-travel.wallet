using System.Collections.Generic;

namespace BASE.Application.Client.Recommendations.Events
{
    public class EventsResponse
    {
        public IEnumerable<Event> Events { get; set; }
    }
}