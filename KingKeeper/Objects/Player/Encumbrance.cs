using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace KingKeeper.Objects
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Encumbrance
    {
        // TODO
        Light, Medium,
    }
}
