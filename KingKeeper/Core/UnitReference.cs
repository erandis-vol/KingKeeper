using KingKeeper.Editors;
using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents a reference to a unit.
    /// </summary>
    [JsonObject(IsReference = true)]
    [TypeConverter(typeof(UnitReferenceTypeConverter))]
    public class UnitReference
    {
        [JsonProperty("m_UniqueId")]
        public string UniqueID { get; set; } // string?
    }
}
