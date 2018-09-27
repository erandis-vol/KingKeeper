using Newtonsoft.Json;

namespace KingKeeper.Objects
{
    public class BaseObject
    {
        [JsonProperty("$id")]
        public int ID { get; set; }
    }
}
