using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class Header : BaseObject
    {
        public Header(string json)
            : base(json)
        { }

        public IList<int> Versions
        {
            get => GetValue<IList<int>>("Versions");
            set => SetValue("Versions", value);
        }
    }
}
