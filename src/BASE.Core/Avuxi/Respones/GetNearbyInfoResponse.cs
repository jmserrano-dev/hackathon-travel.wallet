using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BASE.Core.Avuxi.Respones
{
    public class Rank
    {
        public int sights { get; set; }
        public int beachpark { get; set; }
        public int historical { get; set; }
        public int eating { get; set; }
        public int eating_vegetarian { get; set; }
        public int shopping { get; set; }
        public int shopping_luxury { get; set; }
        public int nightlife { get; set; }
    }

    public class Venue
    {
        public string name { get; set; }
        public int dis_min { get; set; }
        public double dis_km { get; set; }
        public string category { get; set; }
        public int rank { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public Rank rank { get; set; }
        public int signals { get; set; }
        public List<Venue> venues { get; set; }
    }

    public class GetNearbyInfoResponse
    {
        public List<Value> values { get; set; }
        public int state { get; set; }
        public object note { get; set; }
    }
}
