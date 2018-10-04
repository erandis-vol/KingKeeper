using Newtonsoft.Json;
using System;

namespace Kingmaker
{
    /// <summary>
    /// Represents a reference to a unit.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class UnitReference
    {
        [JsonProperty("m_UniqueId")]
        public Guid UniqueID { get; set; } // string?
    }
}
