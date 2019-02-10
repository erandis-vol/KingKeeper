using KingKeeper.Core.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KingKeeper.Core
{
    [JsonObject(IsReference = true)]
    public class UnlockableFlags
    {
        [JsonProperty("m_UnlockedFlags")]
        [JsonConverter(typeof(DictionaryConverter))]
        public Dictionary<string, int> UnlockedFlags { get; set; }

        public override string ToString()
        {
            return "(Collection)";
        }
    }
}
