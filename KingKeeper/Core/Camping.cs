using KingKeeper.Core.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace KingKeeper.Core
{
    /// <summary>
    /// Represents the camping state.
    /// </summary>
    [JsonObject(IsReference = true)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Camping
    {
        public List<string> ExtraEncounters { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public Dictionary<string, int> PlayedBanters { get; set; }

        public bool UseSpells { get; set; }

        public bool RestUntilHealed { get; set; }

        public bool NeedsInitialDistribution { get; set; }

        public List<UnitReference> Hunters { get; set; }

        public List<UnitReference> Cookers { get; set; }

        public string CookingRecipe { get; set; }

        public List<UnitReference> Builders { get; set; }

        public List<UnitReference> Special { get; set; }

        public List<IList<UnitReference>> Guards { get; set; }

        public List<string> KnownRecipes { get; set; }
    }
}
