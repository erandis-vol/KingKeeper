using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace KingKeeper.Objects
{
    public abstract class BaseObject
    {
        private JObject obj;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseObject"/> class.
        /// </summary>
        /// <param name="obj"></param>
        public BaseObject(JObject obj)
        {
            this.obj = obj ?? throw new ArgumentNullException(nameof(obj));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseObject"/> class from a string that contains JSON.
        /// </summary>
        /// <param name="json"></param>
        public BaseObject(string json)
            : this(JObject.Parse(json ?? throw new ArgumentNullException(nameof(json))))
        { }

        /// <summary>
        /// Returns the specified property as an object.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns></returns>
        protected JObject GetObject(string propertyName)
        {
            return (JObject)obj[propertyName];
        }

        /// <summary>
        /// Returns the specified property as an array.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected JArray GetArray(string propertyName)
        {
            return (JArray)obj[propertyName];
        }

        /// <summary>
        /// Returns the specified property as a value.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns></returns>
        protected JValue GetValue(string propertyName)
        {
            return (JValue)obj[propertyName];
        }

        /// <summary>
        /// Returns the specified property as a .NET type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns></returns>
        protected T GetValue<T>(string propertyName)
        {
            return GetValue(propertyName).ToObject<T>();
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="value"></param>
        protected void SetObject(string propertyName, JObject value)
        {
            obj[propertyName] = value;
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="value"></param>
        protected void SetValue(string propertyName, JValue value)
        {
            obj[propertyName] = value;
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="value"></param>
        protected void SetValue(string propertyName, bool value)
        {
            SetValue(propertyName, new JValue(value));
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        protected void SetValue(string propertyName, int value)
        {
            SetValue(propertyName, new JValue(value));
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        protected void SetValue(string propertyName, string value)
        {
            SetValue(propertyName, new JValue(value));
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        protected void SetValue(string propertyName, Guid value)
        {
            SetValue(propertyName, new JValue(value));
        }

        /// <summary>
        /// Sets the specified property.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="value"></param>
        protected void SetValue(string propertyName, object value)
        {
            obj[propertyName] = JToken.FromObject(value);
        }

        /// <summary>
        /// Returns whether the specified property exists.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns><c>true</c> if the specified properties exists; otherwise, <c>false</c>.</returns>
        protected bool Contains(string propertyName) => obj.ContainsKey(propertyName);

        /// <summary>
        /// Returns the object as a JSON string with the default formatting.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return obj.ToString();
        }

        /// <summary>
        /// Returns the object as a JSON string using the given formatting and converters.
        /// </summary>
        /// <param name="formatting"></param>
        /// <param name="converters"></param>
        /// <returns></returns>
        public string ToString(Formatting formatting, params JsonConverter[] converters)
        {
            return obj.ToString(formatting, converters);
        }

        /// <summary>
        /// Returns the underlying JSON object.
        /// </summary>
        /// <returns></returns>
        public JObject ToJObject() => obj;

        /// <summary>
        /// <c>$id</c> Gets or sets object's unique identifier.
        /// </summary>
        public int ID
        {
            get => GetValue<int>("$id");
            set => SetValue("$id", value);
        }

        /// <summary>
        /// <c>$ref</c> Gets or sets the object's reference identifier.
        /// </summary>
        public int Reference
        {
            get => GetValue<int>("$ref");
            set => SetValue("ref", value);
        }

        /// <summary>
        /// Determines whether the object is a reference.
        /// </summary>
        public bool IsReference => Contains("$ref");
    }
}
