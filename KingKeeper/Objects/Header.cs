using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SaveType { Auto, Quick, Manual }

    public class Header : BaseObject
    {
        public Header(string json)
            : base(json)
        { }

        /// <summary>
        /// Gets or sets the save's name.
        /// </summary>
        public string Name
        {
            get => GetValue<string>("Name");
            set => SetValue("Name", value);
        }

        /// <summary>
        /// Gets or sets the save's description.
        /// </summary>
        public string Description
        {
            get => GetValue<string>("Description");
            set => SetValue("Description", value);
        }

        /// <summary>
        /// Gets or sets the game's name.
        /// </summary>
        public string GameName
        {
            get => GetValue<string>("GameName");
            set => SetValue("GameName", value);
        }

        /// <summary>
        /// Gets or sets the save's type.
        /// </summary>
        public SaveType Type
        {
            get => GetValue<SaveType>("Type");
            set => SetValue("Type", value);
        }

        public IList<int> Versions
        {
            get => GetValue<IList<int>>("Versions");
            set => SetValue("Versions", value);
        }
    }
}
