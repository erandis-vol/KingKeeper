using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Achievement : BaseObject
    {
        public Guid Data { get; set; }

        public bool IsUnlocked { get; set; }

        public bool NeedCommit { get; set; }

        public int Counter { get; set; }
    }

    public class AchievmentsData : BaseObject
    {
        [JsonProperty("m_Achievements")]
        public IList<Achievement> Achievments { get; set; }
    }
}
