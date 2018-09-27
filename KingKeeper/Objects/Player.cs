using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Player : BaseObject
    {
        public Time GameTime { get; set; }

        public Time RealTime { get; set; }

        public CrossSceneState CrossSceneState { get; set; }

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

        public CompanionStories CompanionStories { get; set; }

        [JsonProperty("m_AreaAmbienceData")]
        public IList<AreaAmbienceData> AreaAmbienceData { get; set; }

        public IList<VisitedArea> VisitedAreasData { get; set; }

        public Guid CurrentArea { get; set; }

        [JsonProperty("m_CameraPos")]
        public Camera Camera { get; set; }

        public IList<CharacterReference> ExCompanions { get; set; }

        [JsonProperty("m_CurrentFormationIndex")]
        public int CurrentFormationIndex { get; set; }

        [JsonProperty("m_MainCharacter")]
        public CharacterReference MainCharacter { get; set; }

        public UISettings UISettings { get; set; }

        public IList<Formation> CustomFormations { get; set; }

        public Difficulty Difficulty { get; set; }

        public int Chapter { get; set; }

        public Kingdom Kingdom { get; set; }

        public SharedStash SharedStash { get; set; }

        public REManager REManager { get; set; }

        public SharedVendorTables SharedVendorTables { get; set; }

        public AchievmentsData Achievments { get; set; }

        public InspectUnitsManager InspectUnitsManager { get; set; }

        public IList<UpgradeAction> UpgradeActions { get; set; }

        public Weather Weather { get; set; }

        public IList<CharacterReference> PartyCharacters { get; set; }

        public IList<CharacterReference> DetachedPartyCharacters { get; set; }

        public IList<CharacterReference> RemoteCompanions { get; set; }

        public int Money { get; set; }

        public Guid SelectedFormation { get; set; }

        public CharacterReference Stalker { get; set; } // TODO: verify

        public Encumbrance Encumbrance { get; set; }
    }
}
