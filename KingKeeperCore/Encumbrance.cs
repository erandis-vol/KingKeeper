using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace KingKeeperCore
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Encumbrance
    {
        Light, Medium, Heavy, Overload
    }
}
