using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace KingKeeper.Objects
{
    public class CharacterReference : BaseObject
    {
        public CharacterReference(JObject obj)
            : base(obj)
        { }

        public Guid UniqueID
        {
            get => GetValue<Guid>("m_UniqueId");
            set => SetValue("m_UniqueId", value);
        }
    }
}
