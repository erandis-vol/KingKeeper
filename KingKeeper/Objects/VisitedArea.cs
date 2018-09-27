using System;
using System.Collections.Generic;

namespace KingKeeper.Objects
{
    public class VisitedArea
    {
        public Guid Key { get; set; }

        public IList<string> Value { get; set; }
    }
}
