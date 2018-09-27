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
    }

    public class TimeConverter : JsonConverter<Time>
    {
        public override Time ReadJson(JsonReader reader, Type objectType, Time existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Is it safe to assume the correct format?
            var value = ((string)reader.Value).Split(':');
            return new Time {
                Hours = double.Parse(value[0]),
                Minutes = double.Parse(value[1]),
                Seconds = double.Parse(value[2])
            };
        }

        public override void WriteJson(JsonWriter writer, Time value, JsonSerializer serializer)
        {
            writer.WriteValue($"{value.Hours}:{value.Minutes}:{value.Seconds}");
        }
    }
}
