using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KingKeeper.Extensions
{
    public static class JObjectExtensions
    {
        public static IList<T> ToList<T>(this JToken source)
        {
            if (source == null)
                return new List<T>();

            if (source is JValue value)
                return new List<T> { value.ToObject<T>() };

            if (source is JArray array)
                return array.Select(x => x.ToObject<T>()).ToList();

            throw new InvalidCastException();
        }
    }
}
