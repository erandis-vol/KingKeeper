using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kingmaker
{
    [JsonObject(IsReference = true)]
    public class Player
    {
        public TimeSpan GameTime { get; set; }

        public TimeSpan RealTime { get; set; }

        //public CrossSceneState CrossSceneState { get; set; }

        [JsonProperty("m_QuestBook")]
        public QuestBook QuestBook { get; set; }

        [JsonProperty("m_UnlockableFlags")]
        public UnlockableFlags UnlockableFlags { get; set; }

        [JsonProperty("m_Dialog")]
        public Dialog Dialog { get; set; }

        [JsonProperty("m_GlobalMap")]
        public GlobalMap GlobalMap { get; set; }

        [JsonProperty("m_Camping")]
        public Camping Camping { get; set; }

        //public CompanionStories CompanionStories { get; set; }

        //[JsonProperty("m_AreaAmbienceData")]
        //public IList<AreaAmbienceData> AreaAmbienceData { get; set; }

        //public IList<VisitedArea> VisitedAreasData { get; set; }

        public string CurrentArea { get; set; }

        // [JsonProperty("m_CameraPos")]
        // public Vector3 Camera { get; set; }

        public IList<UnitReference> ExCompanions { get; set; }

        public int CurrentFormationIndex { get; set; }

        public UnitReference MainCharacter { get; set; }

        //public UISettings UISettings { get; set; }

        //public IList<Formation> CustomFormations { get; set; }

        //public Difficulty Difficulty { get; set; }

        public int Chapter { get; set; }

        //public Kingdom Kingdom { get; set; }

        //public SharedStash SharedStash { get; set; }

        //public REManager REManager { get; set; }

        //public SharedVendorTables SharedVendorTables { get; set; }

        //public AchievementsData Achievements { get; set; }

        //public InspectUnitsManager InspectUnitsManager { get; set; }

        //public IList<UpgradeAction> UpgradeActions { get; set; }

        //public Weather Weather { get; set; }

        public IList<UnitReference> PartyCharacters { get; set; }

        public IList<UnitReference> DetachedPartyCharacters { get; set; }

        public IList<UnitReference> RemoteCompanions { get; set; }

        public long Money { get; set; }

        public string SelectedFormation { get; set; }

        public UnitReference Stalker { get; set; } // Needs verification

        public Encumbrance Encumbrance { get; set; }
    }
}
