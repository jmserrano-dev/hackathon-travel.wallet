using System;
using System.Collections.Generic;

namespace BASE.Application.Client.Flights
{
    public class FlightsResponse
    {
        public IEnumerable<Flight> Flights { get; set; }
    }

    public class Departure
    {
        public string IataCode { get; set; }
        public string Terminal { get; set; }
        public DateTime At { get; set; }
    }

    public class Arrival
    {
        public string IataCode { get; set; }
        public string Terminal { get; set; }
        public DateTime At { get; set; }
    }

    public class Aircraft
    {
        public string Code { get; set; }
    }

    public class Operating
    {
        public string CarrierCode { get; set; }
        public string Number { get; set; }
    }

    public class FlightSegment
    {
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
        public string CarrierCode { get; set; }
        public string Number { get; set; }
        public Aircraft Aircraft { get; set; }
        public Operating Operating { get; set; }
        public string Duration { get; set; }
    }

    public class PricingDetailPerAdult
    {
        public string TravelClass { get; set; }
        public string FareClass { get; set; }
        public int Availability { get; set; }
        public string FareBasis { get; set; }
    }

    public class Flight
    {
        public FlightSegment FlightSegment { get; set; }
        public PricingDetailPerAdult PricingDetailPerAdult { get; set; }
    }
}