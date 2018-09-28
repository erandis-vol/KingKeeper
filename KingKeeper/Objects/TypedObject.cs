using Newtonsoft.Json.Linq;

namespace KingKeeper.Objects
{
    public abstract class TypedObject : BaseObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypedObject"/> class.
        /// </summary>
        /// <param name="obj"></param>
        protected TypedObject(JObject obj)
            : base(obj)
        { }

        /// <summary>
        /// <c>$type</c> Gets or set the object's expected type.
        /// </summary>
        public string Type
        {
            get => GetValue<string>("$type");
            set => SetValue("$type", value);
        }
    }
}
