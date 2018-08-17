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

    internal class FillOpacityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FillOpacity) || t == typeof(FillOpacity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FillOpacity(doubleValue);
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "inherit":
                            return new FillOpacity(CssRule.Inherit);
                        case "initial":
                            return new FillOpacity(CssRule.Initial);
                        case "unset":
                            return new FillOpacity(CssRule.Unset);
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type FillOpacity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FillOpacity)untypedValue;
            if (value.Double != null)
            {
                writer.WriteRawValue(value.Double.Value.ToString());
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case CssRule.Inherit:
                        writer.WriteRawValue("inherit");
                        return;
                    case CssRule.Initial:
                        writer.WriteRawValue("initial");
                        return;
                    case CssRule.Unset:
                        writer.WriteRawValue("unset");
                        return;
                }
            }
            throw new Exception("Cannot marshal type FillOpacity");
        }

        public static readonly FillOpacityConverter Singleton = new FillOpacityConverter();
    }
}
