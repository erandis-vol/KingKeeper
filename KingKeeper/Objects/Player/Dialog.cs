using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Dialog
    {
        public IList<Guid> SelectedAnswers { get; set; }

        public IList<SkillCheck> AnswerChecks { get; set; }

        public IList<Guid> ShownAnswerLists { get; set; }

        public IList<Guid> ShownCues { get; set; }

        public IList<Guid> ShownDialogs { get; set; }

        public IList<Guid> Scheduled { get; set; }
    }
}
