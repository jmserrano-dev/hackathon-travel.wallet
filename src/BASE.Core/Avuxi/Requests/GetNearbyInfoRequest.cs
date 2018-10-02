using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BASE.Core.Avuxi.Requests
{
    public class GetNearbyInfoRequest
    {
        public string Language { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Type Type { get; set; }
    }

    public class Type
    {
        public static Type Rank { get; } = new Type(0, "rank");
        public static Type Rank3 { get; } = new Type(0, "ranktop3");
        public static Type Rank6 { get; } = new Type(1, "ranktop6");
        public static Type Rank12 { get; } = new Type(2, "ranktop12");
        public static Type RankTop1ByCat { get; } = new Type(2, "ranktop1bycat");
        public static Type Transport { get; } = new Type(2, "transport");

        public string Name { get; private set; }
        public int Value { get; private set; }

        private Type(int val, string name)
        {
            Value = val;
            Name = name;
        }

        public static IEnumerable<Type> List()
        {
            // alternately, use a dictionary keyed by value
            return new[] { Rank, Rank6, Rank12, RankTop1ByCat, Transport };
        }

        public static Type FromString(string typeString)
        {
            return List().Single(r => String.Equals(r.Name, typeString, StringComparison.OrdinalIgnoreCase));
        }

        public static Type FromValue(int value)
        {
            return List().Single(r => r.Value == value);
        }

        public static string FromType(Type type)
        {
            return type.Name;
        }
    }
}
