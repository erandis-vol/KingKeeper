using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents the type of a save.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SaveType
    {
        Manual, Quick, Auto, Remote, Bugreport
    }

    /// <summary>
    /// Represents a save header.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class Save
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string GameName { get; set; }

        public SaveType Type { get; set; }

        public bool IsAutoLevelupSave { get; set; }

        public int QuicksaveNumber { get; set; }

        public int LoadedTimes { get; set; }

        public string AreaNameOverride { get; set; }

        public IList<SavePortrait> PartyPortraits { get; set; }

        public DateTime SystemSaveTime { get; set; }

        public TimeSpan GameSaveTime { get; set; }

        public TimeSpan GameTotalTime { get; set; }

        public IList<int> Versions { get; set; }

        public int ComatibilityVersion { get; set; }
    }

    /// <summary>
    /// Represents a portrait reference in the save header.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class SavePortrait
    {
        [JsonProperty("m_Blueprint")]
        private string Blueprint { get; set; }

        [JsonProperty("m_Data")]
        private string Data { get; set; } // TODO, not actually a string
    }
}
