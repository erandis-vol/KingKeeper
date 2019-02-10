using KingKeeper.Core;
using System;
using System.ComponentModel;
using System.Globalization;

namespace KingKeeper.Editors
{
    public class GlobalMapUVTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string str)
            {
                var xy = str.Split(',');
                try
                {
                    return new GlobalMapUV {
                        X = float.Parse(xy[0]),
                        Y = float.Parse(xy[1])
                    };
                }
                catch
                {
                    throw new InvalidCastException("Cannot converter the string \""
                        + str + "\" to a GlobalMapUV.");
                }
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is GlobalMapUV uv)
            {
                return $"{uv.X}, {uv.Y}";
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(value);
        }
    }
}
