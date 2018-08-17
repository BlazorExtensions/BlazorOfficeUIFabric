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

    internal class FontSizeAdjustUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontSizeAdjust) || t == typeof(FontSizeAdjust?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FontSizeAdjust(doubleValue);
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "inherit":
                            return new FontSizeAdjust(FontSizeAdjustValues.Inherit);
                        case "initial":
                            return new FontSizeAdjust(FontSizeAdjustValues.Initial);
                        case "none":
                            return new FontSizeAdjust(FontSizeAdjustValues.None);
                        case "unset":
                            return new FontSizeAdjust(FontSizeAdjustValues.Unset);
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type FontSizeAdjustUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FontSizeAdjust)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
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
            }
            throw new Exception("Cannot marshal type FontSizeAdjustUnion");
        }

        public static readonly FontSizeAdjustUnionConverter Singleton = new FontSizeAdjustUnionConverter();
    }
}
