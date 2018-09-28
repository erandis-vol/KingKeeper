using Newtonsoft.Json;
using System;

namespace KingKeeper.Objects
{
    [JsonConverter(typeof(TimeConverter))]
    public class Time
    {
        public double Hours { get; set; }

        public double Minutes { get; set; }

        public double Seconds { get; set; }

        public static Time Parse(string s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));

            var ss = s.Split(':');
            return new Time {
                Hours   = double.Parse(ss[0]),
                Minutes = double.Parse(ss[1]),
                Seconds = double.Parse(ss[2])
            };
        }

        public static bool TryParse(string s, out Time value)
        {
            try
            {
                value = Parse(s);
                return true;
            }
            catch
            {
                value = default(Time);
                return false;
            }
        }

        public override string ToString() => $"{Hours}:{Minutes}:{Seconds}";
    }

    public class TimeConverter : JsonConverter<Time>
    {
        public override Time ReadJson(JsonReader reader, Type objectType, Time existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return Time.Parse((string)reader.Value);
        }

        public override void WriteJson(JsonWriter writer, Time value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}
