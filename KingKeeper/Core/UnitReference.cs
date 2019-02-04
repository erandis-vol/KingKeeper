using Newtonsoft.Json;
using System;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents a reference to a unit.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class UnitReference
    {
        [JsonProperty("m_UniqueId")]
        public string UniqueID { get; set; } // string?
    }
}
