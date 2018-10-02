using System;
using System.Collections.Generic;
using System.Text;

namespace BASE.Core.Amadeus.Responses
{

    public class Hotel
    {
        public string type { get; set; }
        public string hotelId { get; set; }
        public string chainCode { get; set; }
        public string dupeId { get; set; }
        public string name { get; set; }
        public string cityCode { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class RateFamilyEstimated
    {
        public string code { get; set; }
        public string type { get; set; }
    }

    public class Commission
    {
        public string percentage { get; set; }
    }

    public class TypeEstimated
    {
        public int beds { get; set; }
        public string bedType { get; set; }
        public string category { get; set; }
    }

    public class Description
    {
        public string lang { get; set; }
        public string text { get; set; }
    }

    public class Room
    {
        public string type { get; set; }
        public TypeEstimated typeEstimated { get; set; }
        public Description description { get; set; }
    }

    public class Guests
    {
        public int adults { get; set; }
    }

    public class Average
    {
        public string total { get; set; }
        public string @base { get; set; }
    }

    public class Change
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string total { get; set; }
    }

    public class Variations
    {
        public Average average { get; set; }
        public List<Change> changes { get; set; }
    }

    public class Tax
    {
        public string code { get; set; }
        public string percentage { get; set; }
        public bool included { get; set; }
    }

    public class Price
    {
        public string currency { get; set; }
        public string total { get; set; }
        public Variations variations { get; set; }
        public List<Tax> taxes { get; set; }
        public string @base { get; set; }
    }

    public class Cancellation
    {
        public DateTime deadline { get; set; }
        public int? numberOfNights { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
    }

    public class AcceptedPayments
    {
        public List<string> creditCards { get; set; }
        public List<string> methods { get; set; }
    }

    public class Guarantee
    {
        public AcceptedPayments acceptedPayments { get; set; }
    }

    public class AcceptedPayments2
    {
        public List<string> creditCards { get; set; }
        public List<string> methods { get; set; }
    }

    public class Deposit
    {
        public string amount { get; set; }
        public AcceptedPayments2 acceptedPayments { get; set; }
    }

    public class HoldTime
    {
        public DateTime deadline { get; set; }
    }

    public class Policies
    {
        public Cancellation cancellation { get; set; }
        public Guarantee guarantee { get; set; }
        public Deposit deposit { get; set; }
        public HoldTime holdTime { get; set; }
    }

    public class Offer
    {
        public string id { get; set; }
        public string rateCode { get; set; }
        public RateFamilyEstimated rateFamilyEstimated { get; set; }
        public Commission commission { get; set; }
        public Room room { get; set; }
        public Guests guests { get; set; }
        public Price price { get; set; }
        public string category { get; set; }
        public Policies policies { get; set; }
        public string boardType { get; set; }
    }

    public class Datum
    {
        public string type { get; set; }
        public Hotel hotel { get; set; }
        public bool available { get; set; }
        public List<Offer> offers { get; set; }
        public string self { get; set; }
    }

    public class Links
    {
        public string next { get; set; }
    }

    public class Meta
    {
        public Links links { get; set; }
    }

    public class HotelsResponse
    {
        public List<Datum> data { get; set; }
        public Meta meta { get; set; }
    }
}
