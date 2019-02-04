using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace KingKeeper.Core
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Encumbrance
    {
        Light, Medium, Heavy, Overload
    }
}
