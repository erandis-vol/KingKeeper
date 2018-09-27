using Newtonsoft.Json;
using System;

namespace KingKeeper.Objects
{
    public class CharacterReference
    {
        [JsonProperty("m_UniqueId")]
        public Guid UniqueID { get; set; }
    }
}
