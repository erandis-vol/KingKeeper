using Newtonsoft.Json;

namespace KingKeeper.Objects
{
    // NOTE: The Camera is represented by a UnityEngine.Vector3 internally.
    public class Camera
    {
        [JsonProperty("$type")]
        private string Type { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }
    }
}
