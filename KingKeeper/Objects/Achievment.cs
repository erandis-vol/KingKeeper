using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Achievment : BaseObject
    {
        public Guid Data { get; set; }

        public bool IsUnlocked { get; set; }

        public bool NeedCommit { get; set; }

        public int Counter { get; set; }
    }

    public class AchievmentsData : BaseObject
    {
        [JsonProperty("m_Achievements")]
        public IList<Achievment> Achievments { get; set; }
    }
}
