using System;
using System.Collections.Generic;

namespace BASE.Application.Client
{
    public class CardsResponse
    {
        public IEnumerable<Card> Cards { get; set; }
    }

    public class Card
    {
        public string Bank { get; set; }
        public string Number { get; set; }
        public DateTime Expiry { get; set; }
        public Brand Brand { get; set; }
    }

    public enum Brand
    {
        Visa,
        MasterCard
    }
}