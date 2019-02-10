using KingKeeper.Core.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents the dialog state.
    /// </summary>
    [JsonObject(IsReference = true)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Dialog
    {
        public List<string> SelectedAnswers { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public Dictionary<string, SkillCheckResult> AnswerChecks { get; set; }

        public List<string> ShownAnswerLists { get; set; }

        public List<string> ShownCues { get; set; }

        public List<string> ShownDialogs { get; set; }

        public ScheduledDialog Scheduled { get; set; }

        public override string ToString()
        {
            return "(...)";
        }
    }

    /// <summary>
    /// Represents the result of a skill check.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkillCheckResult
    {
        Passed, Failed
    }

    /// <summary>
    /// Represents a scheduled dialog instance.
    /// </summary>
    public class ScheduledDialog
    {
        public string Dialog { get; set; }

        public UnitReference Initiator { get; set; }

        public UnitReference Unit { get; set; }

        public string MapObject { get; set; } // Needs verification

        public string CustomSpeakerName { get; set; }

        public bool IsScheduled { get; set; }
    }
}
