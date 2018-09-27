using Newtonsoft.Json;
using System;

namespace KingKeeper.Objects
{
    public class Player
    {
        [JsonProperty("$id")]
        public int ID { get; set; }

        public Guid CurrentArea { get; set; }

        [JsonProperty("m_CurrentFormationIndex")]
        public int CurrentFormationIndex { get; set; }

        [JsonProperty("m_MainCharacter")]
        public CharacterReference MainCharacter { get; set; }

        public int Chapter { get; set; }

        public CharacterReference[] PartyCharacters { get; set; }

        public CharacterReference[] DetachedPartyCharacters { get; set; }

        public int Money { get; set; }

        public Guid SelectedFormation { get; set; }
    }
}
