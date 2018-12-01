using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeperCore
{
    public struct Vector2
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }
    }

    public struct Vector3
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("z")]
        public float Z { get; set; }
    }
}
