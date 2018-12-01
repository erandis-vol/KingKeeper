using KingKeeperCore.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace KingKeeperCore
{
    /// <summary>
    /// Represents the global map state.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class GlobalMap
    {
        public string LastLocation { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<string, GlobalMapLocation> Locations { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<string, GlobalMapEdge> Edges { get; set; }

        public IList<string> PerceptionRolledLocations { get; set; }

        [JsonProperty("m_TravelData")]
        public GlobalMapTravelData TravelData { get; set; }

        public IList<GlobalMapTravelData> HistoryTravels { get; set; }

        [JsonProperty("m_Encounters")]
        public IList<GlobalMapEncounter> Encounters { get; set; }

        [JsonProperty("m_EncountersCount")]
        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<string, int> EncountersCount { get; set; }

        public GlobalMapPosition PartyPosition { get; set; }

        public GlobalMapUV PartyPositionUV { get; set; }

        public float MilesTraveled { get; set; }

        public float NextEncounterRollMiles { get; set; }

        public string LastEncounter { get; set; }

        public GlobalMapEncounter CurrentEncounterData { get; set; }

        public float SpeedModifier { get; set; }

        public float KingdomSpeedModifier { get; set; }
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapLocation
    {
        public string Blueprint { get; set; }

        public bool IsExplored { get; set; }

        public bool IsSeen { get; set; }

        public bool IsClosed { get; set; }

        public bool EdgesOpened { get; set; }

        public bool IsFake { get; set; }

        public TimeSpan LastVisited { get; set; }

        [JsonProperty("m_CustomEntrance")]
        public string CustomEntrance { get; set; }

        public bool IsRevealed { get; set; }

        public int LastPerceptionRolled { get; set; }
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapEdge
    {
        public string Blueprint { get; set; }

        public float Explored1 { get; set; }

        public float Explored2 { get; set; }
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapTravelData
    {
        [JsonProperty("m_From")]
        public GlobalMapPosition From { get; set; }

        public GlobalMapPosition To { get; set; }

        public IList<GlobalMapTravelEdge> Path { get; set; }

        public GlobalMapTravelEdge CurrentEdge { get; set; }

        public float EdgePosition { get; set; }

        public float WalkedDistance { get; set; }

        public bool EnterDestination { get; set; }

        public bool Walking { get; set; }

        public bool Finished { get; set; }
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapTravelEdge
    {
        public string Blueprint { get; set; }

        public int Direction { get; set; }

        public bool RevealPath { get; set; }
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapEncounter
    {
        public string Blueprint { get; set; }

        public Vector3? Position { get; set; }

        public Vector3 FinalPosition { get; set; }

        [JsonProperty("EulerAngels")] // nice typo Owlcat lol
        public Vector3 EulerAngles { get; set; }

        public GlobalMapEncounterAvoidanceCheckResult AvoidanceCheckResult { get; set; }

        public int CR { get; set; }

        public IList<GlobalMapEncounterSpawnData> SpawnersGroups { get; set; }

        public bool UserEnter { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GlobalMapEncounterAvoidanceCheckResult
    {
        Success, Fail, CriticalFail
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapEncounterSpawnData
    {
        // TODO
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapSpawnerGroup
    {
        // TODO
    }

    [JsonObject(IsReference = true)]
    public class GlobalMapPosition
    {
        public string Location { get; set; }

        public string Edge { get; set; }

        public float EdgePosition { get; set; }
    }

    public struct GlobalMapUV // : Vector2
    {
        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }
    }


}
