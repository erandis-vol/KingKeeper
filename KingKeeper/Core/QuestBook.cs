using KingKeeper.Editors;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents the quest book state.
    /// </summary>
    [JsonObject(IsReference = true)]
    [Editor(typeof(QuestBookEditor), typeof(UITypeEditor))]
    public class QuestBook
    {
        public List<Quest> PersistentQuests { get; set; }

        public override string ToString()
        {
            return "(Collection)";
        }
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

        public string Blueprint { get; set; }

        public bool Initialized { get; set; }

        public bool Active { get; set; }

        public QuestSourceItem SourceItem { get; set; }

        public QuestSourceCutscene SourceCutscene { get; set; }

        public override string ToString()
        {
            return Blueprint ?? string.Empty;
        }
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
        public string EntityID { get; set; }

        public string Name { get; set; }

        public string State { get; set; }
    }
}
