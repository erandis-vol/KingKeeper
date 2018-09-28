using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Story
    {
        // TODO
    }

    public class CompanionStories : BaseObject
    {
        [JsonProperty("m_Stories")]
        public IList<Story> Stories { get; set; }
    }
}
