using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Player : BaseObject
    {
        public Player(string json)
            : base(json)
        { }

        /// <summary>
        /// Gets or sets the game time.
        /// </summary>
        public Time GameTime
        {
            get => GetValue<Time>("GameTime");
            set => SetValue("GameTime", value);
        }

        /// <summary>
        /// Gets or sets the real time.
        /// </summary>
        public Time RealTime
        {
            get => GetValue<Time>("RealTime");
            set => SetValue("RealTime", value);
        }

        //public CrossSceneState CrossSceneState { get; set; }

        //[JsonProperty("m_QuestBook")]
        //public QuestBook QuestBook { get; set; }

        //[JsonProperty("m_UnlockableFlags")]
        //public UnlockableFlags UnlockableFlags { get; set; }

        private Dialog dialog = null;

        /// <summary>
        /// Gets the dialog progress.
        /// </summary>
        public Dialog Dialog
        {
            get => dialog ?? (dialog = new Dialog(GetObject("m_Dialog")));
        }

        //[JsonProperty("m_GlobalMap")]
        //public GlobalMap GlobalMap { get; set; }

        //[JsonProperty("m_Camping")]
        //public Camping Camping { get; set; }

        //public CompanionStories CompanionStories { get; set; }

        //[JsonProperty("m_AreaAmbienceData")]
        //public IList<AreaAmbienceData> AreaAmbienceData { get; set; }

        //public IList<VisitedArea> VisitedAreasData { get; set; }

        /// <summary>
        /// Gets or sets the current area.
        /// </summary>
        public Guid CurrentArea
        {
            get => GetValue<Guid>("CurrentArea");
            set => SetValue("CurrentArea", value);
        }

        private Camera camera = null;

        /// <summary>
        /// Gets the current camera position.
        /// </summary>
        public Camera Camera
        {
            get => camera ?? (camera = new Camera(GetObject("m_CameraPos")));
        }

        //public IList<CharacterReference> ExCompanions { get; set; }

        /// <summary>
        /// Gets or sets the current formation index.
        /// </summary>
        public int CurrentFormationIndex
        {
            get => GetValue<int>("m_CurrentFormationIndex");
            set => SetValue("m_CurrentFormationIndex", value);
        }

        private CharacterReference mainCharacter = null;

        /// <summary>
        /// Gets the player's main character.
        /// </summary>
        public CharacterReference MainCharacter
        {
            get => mainCharacter ?? (mainCharacter = new CharacterReference(GetObject("m_MainCharacter")));
        }

        //public UISettings UISettings { get; set; }

        //public IList<Formation> CustomFormations { get; set; }

        //public Difficulty Difficulty { get; set; }

        public int Chapter
        {
            get => GetValue<int>("Chapter");
            set => SetValue("Chapter", value);
        }

        //public Kingdom Kingdom { get; set; }

        //public SharedStash SharedStash { get; set; }

        //public REManager REManager { get; set; }

        //public SharedVendorTables SharedVendorTables { get; set; }

        private AchievementsData achievements = null;

        /// <summary>
        /// The player's achievement progress.
        /// </summary>
        public AchievementsData Achievements
        {
            get => achievements ?? (achievements = new AchievementsData(GetObject("Achievements")));
        }

        //public InspectUnitsManager InspectUnitsManager { get; set; }

        //public IList<UpgradeAction> UpgradeActions { get; set; }

        //public Weather Weather { get; set; }

        //public IList<CharacterReference> PartyCharacters { get; set; }

        //public IList<CharacterReference> DetachedPartyCharacters { get; set; }

        //public IList<CharacterReference> RemoteCompanions { get; set; }

        /// <summary>
        /// Gets or sets the player's gold.
        /// </summary>
        public int Money
        {
            get => GetValue<int>("Money");
            set => SetValue("Money", value);
        }

        /// <summary>
        /// Gets or sets the selected formation.
        /// </summary>
        public Guid SelectedFormation
        {
            get => GetValue<Guid>("SelectedFormat");
            set => SetValue("SelectedFormat", value);
        }

        //public CharacterReference Stalker { get; set; } // TODO: verify

        /// <summary>
        /// Gets or sets the player's encumbrance level.
        /// </summary>
        public Encumbrance Encumbrance
        {
            get => GetValue<Encumbrance>("Encumbrance");
            set => SetValue("Encumbrance", value);
        }
    }
}
