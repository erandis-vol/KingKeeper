using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingKeeper.Objects
{
    public class Party : BaseObject
    {
        public Party(string json)
            : base(json)
        { }

        public bool BitexSave { get; set; }

        public string SceneName { get; set; } // = "<cross-scene>"

        public bool HasEntityData { get; set; }
    }
}
