using KingKeeper.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KingKeeper.Objects
{
    public class Dialog : BaseObject
    {
        public Dialog(JObject obj)
            : base(obj)
        { }

        public IList<Guid> SelectedAnswers => GetArray("SelectedAnswers").ToList<Guid>();

        public IList<SkillCheck> AnswerChecks => GetArray("AnswerChecks").Select(x => new SkillCheck((JObject)x)).ToList();

        public IList<Guid> ShownAnswerLists => GetArray("ShownAnswerLists").ToList<Guid>();

        public IList<Guid> ShownCues => GetArray("ShownCues").ToList<Guid>();

        public IList<Guid> ShownDialogs => GetArray("ShownDialogs").ToList<Guid>();

        public IList<Guid> Scheduled => GetArray("Scheduled").ToList<Guid>();
    }
}
