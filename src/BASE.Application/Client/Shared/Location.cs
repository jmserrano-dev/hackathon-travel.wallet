namespace BASE.Application.Client.Shared
{
    public class Location
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public Location(string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
