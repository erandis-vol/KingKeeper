using KingKeeper.Core.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents the dialog state.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class Dialog
    {
        public IList<string> SelectedAnswers { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<string, SkillCheckResult> AnswerChecks { get; set; }

        public IList<string> ShownAnswerLists { get; set; }

        public IList<string> ShownCues { get; set; }

        public IList<string> ShownDialogs { get; set; }

        public ScheduledDialog Scheduled { get; set; }
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
