using KingKeeper.Core;
using System;
using System.ComponentModel;
using System.Globalization;

namespace KingKeeper.Editors
{
    public class UnitReferenceTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string) || sourceType == typeof(Guid))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string stringValue)
            {
                try
                {
                    return new UnitReference { UniqueID = Guid.Parse(stringValue).ToString() };
                }
                catch
                {
                    throw new InvalidCastException("Cannot convert \""
                        + (value ?? string.Empty) + "\" to a UnitReference.");
                }
            }
            else if (value is Guid guidValue)
            {
                return new UnitReference { UniqueID = guidValue.ToString() };
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is UnitReference unitRef)
            {
                return unitRef.UniqueID;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
