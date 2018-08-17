using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{

    internal class FontStretchConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontStretch) || t == typeof(FontStretch?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "condensed":
                    return FontStretch.Condensed;
                case "expanded":
                    return FontStretch.Expanded;
                case "extra-condensed":
                    return FontStretch.ExtraCondensed;
                case "extra-expanded":
                    return FontStretch.ExtraExpanded;
                case "inherit":
                    return FontStretch.Inherit;
                case "initial":
                    return FontStretch.Initial;
                case "normal":
                    return FontStretch.Normal;
                case "semi-condensed":
                    return FontStretch.SemiCondensed;
                case "semi-expanded":
                    return FontStretch.SemiExpanded;
                case "ultra-condensed":
                    return FontStretch.UltraCondensed;
                case "ultra-expanded":
                    return FontStretch.UltraExpanded;
                case "unset":
                    return FontStretch.Unset;
            }
            throw new Exception("Cannot unmarshal type FontStretch");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (FontStretch)untypedValue;
            switch (value)
            {
                case FontStretch.Condensed:
                     writer.WriteRawValue("condensed");
                    return;
                case FontStretch.Expanded:
                     writer.WriteRawValue("expanded");
                    return;
                case FontStretch.ExtraCondensed:
                     writer.WriteRawValue("extra-condensed");
                    return;
                case FontStretch.ExtraExpanded:
                     writer.WriteRawValue("extra-expanded");
                    return;
                case FontStretch.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case FontStretch.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case FontStretch.Normal:
                     writer.WriteRawValue("normal");
                    return;
                case FontStretch.SemiCondensed:
                     writer.WriteRawValue("semi-condensed");
                    return;
                case FontStretch.SemiExpanded:
                     writer.WriteRawValue("semi-expanded");
                    return;
                case FontStretch.UltraCondensed:
                     writer.WriteRawValue("ultra-condensed");
                    return;
                case FontStretch.UltraExpanded:
                     writer.WriteRawValue("ultra-expanded");
                    return;
                case FontStretch.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type FontStretch");
        }

        public static readonly FontStretchConverter Singleton = new FontStretchConverter();
    }
}
