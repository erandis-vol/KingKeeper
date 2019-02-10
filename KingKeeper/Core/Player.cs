using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KingKeeper.Core
{
    [JsonObject(IsReference = true)]
    public class Player
    {
        [Category("Time")]
        [Description("The amount of in-game time spent playing.")]
        public TimeSpan GameTime { get; set; }

        [Category("Time")]
        [Description("The amount of real time spent playing.")]
        public TimeSpan RealTime { get; set; }

        //public CrossSceneState CrossSceneState { get; set; }

        [JsonProperty("m_QuestBook")]
        [DisplayName("Quest Book")]
        [Category("Progress")]
        [Description("The collection of quests in the journal.")]
        public QuestBook QuestBook { get; set; }

        [JsonProperty("m_UnlockableFlags")]
        [DisplayName("Unlocked Flags")]
        [Category("Progress")]
        public UnlockableFlags UnlockableFlags { get; set; }

        [JsonProperty("m_Dialog")]
        [Category("Progress")]
        public Dialog Dialog { get; set; }

        [JsonProperty("m_GlobalMap")]
        [DisplayName("Global Map")]
        [Category("Exploration")]
        public GlobalMap GlobalMap { get; set; }

        [JsonProperty("m_Camping")]
        [Category("Exploration")]
        public Camping Camping { get; set; }

        //public CompanionStories CompanionStories { get; set; }

        //[JsonProperty("m_AreaAmbienceData")]
        //public IList<AreaAmbienceData> AreaAmbienceData { get; set; }

        //public IList<VisitedArea> VisitedAreasData { get; set; }

        [DisplayName("Current Area")]
        [Category("Exploration")]
        [Description("The current area of the party.")]
        public string CurrentArea { get; set; }

        // [JsonProperty("m_CameraPos")]
        // public Vector3 Camera { get; set; }

        [Category("Party")]
        [Description("The units that have left the party.")]
        public List<UnitReference> ExCompanions { get; set; }

        public int CurrentFormationIndex { get; set; }

        [Category("Party")]
        [Description("The unit assigned to the main character.")]
        public UnitReference MainCharacter { get; set; }

        //public UISettings UISettings { get; set; }

        //public IList<Formation> CustomFormations { get; set; }

        //public Difficulty Difficulty { get; set; }

        [Category("Progress")]
        [Description("The current story chapter.")]
        public int Chapter { get; set; }

        //public Kingdom Kingdom { get; set; }

        //public SharedStash SharedStash { get; set; }

        //public REManager REManager { get; set; }

        //public SharedVendorTables SharedVendorTables { get; set; }

        //public AchievementsData Achievements { get; set; }

        //public InspectUnitsManager InspectUnitsManager { get; set; }

        //public IList<UpgradeAction> UpgradeActions { get; set; }

        //public Weather Weather { get; set; }

        [Category("Party")]
        public List<UnitReference> PartyCharacters { get; set; }

        [Category("Party")]
        public List<UnitReference> DetachedPartyCharacters { get; set; }

        [Category("Party")]
        public List<UnitReference> RemoteCompanions { get; set; }

        [Description("The total amount of gold carried by the player."), DefaultValue(0)]
        public long Money { get; set; }

        public string SelectedFormation { get; set; }

        public UnitReference Stalker { get; set; } // Needs verification

        [Description("The encumbrance level of the player.")]
        public Encumbrance Encumbrance { get; set; }
    }
}
