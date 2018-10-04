using Kingmaker.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kingmaker
{
    [JsonObject(IsReference = true)]
    public class UnlockableFlags
    {
        [JsonProperty("m_UnlockedFlags")]
        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<Guid, int> UnlockedFlags { get; set; }
    }
}
