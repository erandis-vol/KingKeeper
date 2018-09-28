using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KingKeeper.Objects
{
    public class Achievement : BaseObject
    {
        public Achievement(JObject obj)
            : base(obj)
        { }

        /// <summary>
        /// Gets or sets the achievement reference identifier.
        /// </summary>
        public Guid Data
        {
            get => GetValue<Guid>("Data");
            set => SetValue("Data", value);
        }

        /// <summary>
        /// Gets or sets whether the achievement is unlocked.
        /// </summary>
        public bool IsUnlocked
        {
            get => GetValue<bool>("IsUnlocked");
            set => SetValue("IsUnlocked", value);
        }

        /// <summary>
        /// Gets or sets whether the achievement needs a commit.
        /// </summary>
        public bool NeedCommit
        {
            get => GetValue<bool>("NeedCommit");
            set => SetValue("NeedCommit", value);
        }

        /// <summary>
        /// Gets or sets the achievement counter.
        /// </summary>
        public int Counter
        {
            get => GetValue<int>("Counter");
            set => SetValue("Counter", value);
        }
    }

    public class AchievementsData : BaseObject
    {
        public AchievementsData(JObject obj)
            : base(obj)
        { }

        /// <summary>
        /// Gets the list of achievements.
        /// </summary>
        public IList<Achievement> Achievements
        {
            get => GetArray("m_Achievements").Select(x => new Achievement((JObject)x)).ToList();
        }
    }
}
