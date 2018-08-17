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

    internal class FontStyleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontStyle) || t == typeof(FontStyle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "inherit":
                    return FontStyle.Inherit;
                case "initial":
                    return FontStyle.Initial;
                case "italic":
                    return FontStyle.Italic;
                case "normal":
                    return FontStyle.Normal;
                case "oblique":
                    return FontStyle.Oblique;
                case "unset":
                    return FontStyle.Unset;
            }
            throw new Exception("Cannot unmarshal type FontStyle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (FontStyle)untypedValue;
            switch (value)
            {
                case FontStyle.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case FontStyle.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case FontStyle.Italic:
                     writer.WriteRawValue("italic");
                    return;
                case FontStyle.Normal:
                     writer.WriteRawValue("normal");
                    return;
                case FontStyle.Oblique:
                     writer.WriteRawValue("oblique");
                    return;
                case FontStyle.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type FontStyle");
        }

        public static readonly FontStyleConverter Singleton = new FontStyleConverter();
    }
}
