using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Achievment : BaseObject
    {
        // TODO
    }

    public class AchievmentsData : BaseObject
    {
        [JsonProperty("m_Achievements")]
        public IList<Achievment> Achievments { get; set; }
    }
}
