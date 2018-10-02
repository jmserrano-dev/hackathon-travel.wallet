using System.Collections.Generic;
using BASE.Application.Client.Shared;

namespace BASE.Application.Client.Recommendations.Airports
{
    public class Airport
    {
        public IEnumerable<Establishment> Establishments { get; set; }
        public IEnumerable<Offer> Offers { get; set; }
    }

    public class Establishment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Offer> Offers { get; set; }
    }

    public class Offer
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PromotionalCode { get; set; }
    }
}