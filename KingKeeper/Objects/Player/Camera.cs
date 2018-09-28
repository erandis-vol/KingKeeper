using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;

namespace KingKeeper.Objects
{
    // NOTE: The Camera is represented by a UnityEngine.Vector3 internally.
    [DebuggerDisplay("X = {X}, Y = {Y}, Z = {Z}")]
    public class Camera : TypedObject
    {
        public Camera(JObject obj)
            : base(obj)
        { }

        public double X
        {
            get => GetValue<double>("x");
            set => SetValue("x", value);
        }

        public double Y
        {
            get => GetValue<double>("y");
            set => SetValue("y", value);
        }

        public double Z
        {
            get => GetValue<double>("z");
            set => SetValue("z", value);
        }
    }
}
