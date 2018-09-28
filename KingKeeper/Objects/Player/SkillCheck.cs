using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;

namespace KingKeeper.Objects
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkillCheckResult
    {
        Passed, Failed
    }

    public class SkillCheck : BaseObject
    {
        public SkillCheck(JObject obj)
            : base(obj)
        { }

        public Guid Key { get; set; }

        public SkillCheckResult Value { get; set; }
    }
}
