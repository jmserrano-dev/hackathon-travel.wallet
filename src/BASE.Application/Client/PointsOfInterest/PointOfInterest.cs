namespace BASE.Application.Client.PointsOfInterest
{
    public class PointOfInterest
    {
        public string Name { get; set; }
        public int DistanceInMinutes { get; set; }
        public double DistanceInKilometers { get; set; }
        public PointOfInterestCategoryEnum Category { get; set; }
        public double Rating { get; set; }
    }
}