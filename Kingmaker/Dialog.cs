using Kingmaker.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace Kingmaker
{
    /// <summary>
    /// Represents the dialog state.
    /// </summary>
    public class Dialog
    {
        public IList<Guid> SelectedAnswers { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<Guid, SkillCheckResult> AnswerChecks { get; set; }

        public IList<Guid> ShownAnswerLists { get; set; }

        public IList<Guid> ShownCues { get; set; }

        public IList<Guid> ShownDialogs { get; set; }

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
        public Guid Dialog { get; set; }

        public UnitReference Initiator { get; set; }

        public UnitReference Unit { get; set; }

        public Guid MapObject { get; set; } // Needs verification

        public string CustomSpeakerName { get; set; }

        public bool IsScheduled { get; set; }
    }
}
