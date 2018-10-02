using System.Collections.Generic;
using BASE.Application.Client.Shared;

namespace BASE.Application.Client.Recommendations.Hotels
{
    public class Hotel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public double Prize { get; set; }
        public HotelCategory Category { get; set; }
        public bool HasCancellationWithoutCost { get; set; }
        public string Description { get; set; }
    }

    public class Room
    {
        public int Capacity { get; set; }
        public string Description { get; set; }
    }

    public enum HotelCategory
    {
        One,
        Two,
        Three,
        Four,
        Five
    }
}