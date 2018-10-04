using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace Kingmaker
{
    [JsonObject(IsReference = true)]
    public class QuestBook
    {
        public IList<Quest> PersistentQuests { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuestState
    {
        None, Started, Completed, Failed
    }

    [JsonObject(IsReference = true)]
    public class Quest
    {
        [JsonProperty("m_NextObjectiveOrder")]
        public int NextObjectiveOrder { get; set; }

        public QuestState State { get; set; }

        [JsonProperty("m_IsInUiSelected")]
        public bool IsInUISelected { get; set; }

        public Guid Blueprint { get; set; }

        public bool Initialized { get; set; }

        public bool Active { get; set; }

        public QuestSourceItem SourceItem { get; set; }

        public QuestSourceCutscene SourceCutscene { get; set; }
    }

    [JsonObject(IsReference = true)]
    public class QuestSourceItem
    {
        // TODO
    }

    [JsonObject(IsReference = true)]
    public class QuestSourceCutscene
    {
        [JsonProperty("EntityId")]
        public Guid EntityID { get; set; }

        public string Name { get; set; }

        public string State { get; set; }
    }
}
