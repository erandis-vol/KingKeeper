using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Kingmaker
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Encumbrance
    {
        Light, Medium, Heavy, Overload
    }
}
