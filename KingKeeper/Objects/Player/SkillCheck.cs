using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace KingKeeper.Objects
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkillCheckResult
    {
        Passed, Failed
    }

    public class SkillCheck
    {
        public Guid Key { get; set; }

        public SkillCheckResult Value { get; set; }
    }
}
