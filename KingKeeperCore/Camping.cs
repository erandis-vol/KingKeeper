using KingKeeperCore.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KingKeeperCore
{
    /// <summary>
    /// Represents the camping state.
    /// </summary>
    [JsonObject(IsReference = true)]
    public class Camping
    {
        public IList<string> ExtraEncounters { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<string, int> PlayedBanters { get; set; }

        public bool UseSpells { get; set; }

        public bool RestUntilHealed { get; set; }

        public bool NeedsInitialDistribution { get; set; }

        public IList<UnitReference> Hunters { get; set; }

        public IList<UnitReference> Cookers { get; set; }

        public string CookingRecipe { get; set; }

        public IList<UnitReference> Builders { get; set; }

        public IList<UnitReference> Special { get; set; }

        public IList<IList<UnitReference>> Guards { get; set; }

        public IList<string> KnownRecipes { get; set; }
    }
}
