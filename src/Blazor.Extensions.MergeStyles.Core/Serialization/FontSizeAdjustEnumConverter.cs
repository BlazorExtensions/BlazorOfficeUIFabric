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

    internal class FontSizeAdjustEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontSizeAdjustValues) || t == typeof(FontSizeAdjustValues?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "inherit":
                    return FontSizeAdjustValues.Inherit;
                case "initial":
                    return FontSizeAdjustValues.Initial;
                case "none":
                    return FontSizeAdjustValues.None;
                case "unset":
                    return FontSizeAdjustValues.Unset;
            }
            throw new Exception("Cannot unmarshal type FontSizeAdjustEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (FontSizeAdjustValues)untypedValue;
            switch (value)
            {
                case FontSizeAdjustValues.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case FontSizeAdjustValues.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case FontSizeAdjustValues.None:
                     writer.WriteRawValue("none");
                    return;
                case FontSizeAdjustValues.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type FontSizeAdjustEnum");
        }

        public static readonly FontSizeAdjustEnumConverter Singleton = new FontSizeAdjustEnumConverter();
    }
}
