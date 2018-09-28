using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Flag
    {
        public Guid Key { get; set; }

        public int Value { get; set; }
    }

    public class UnlockableFlags
    {
        [JsonProperty("m_UnlockedFlags")]
        public IList<Flag> UnlockedFlags { get; set; }
    }
}
