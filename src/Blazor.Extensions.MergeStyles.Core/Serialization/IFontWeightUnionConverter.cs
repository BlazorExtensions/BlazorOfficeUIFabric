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

    internal class IFontWeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontWeight) || t == typeof(FontWeight?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new FontWeight { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FontWeight { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "100":
                            return new FontWeight { Enum = FontWeightValues.The100 };
                        case "200":
                            return new FontWeight { Enum = FontWeightValues.The200 };
                        case "300":
                            return new FontWeight { Enum = FontWeightValues.The300 };
                        case "400":
                            return new FontWeight { Enum = FontWeightValues.The400 };
                        case "500":
                            return new FontWeight { Enum = FontWeightValues.The500 };
                        case "600":
                            return new FontWeight { Enum = FontWeightValues.The600 };
                        case "700":
                            return new FontWeight { Enum = FontWeightValues.The700 };
                        case "800":
                            return new FontWeight { Enum = FontWeightValues.The800 };
                        case "900":
                            return new FontWeight { Enum = FontWeightValues.The900 };
                        case "bold":
                            return new FontWeight { Enum = FontWeightValues.Bold };
                        case "bolder":
                            return new FontWeight { Enum = FontWeightValues.Bolder };
                        case "inherit":
                            return new FontWeight { Enum = FontWeightValues.Inherit };
                        case "initial":
                            return new FontWeight { Enum = FontWeightValues.Initial };
                        case "lighter":
                            return new FontWeight { Enum = FontWeightValues.Lighter };
                        case "normal":
                            return new FontWeight { Enum = FontWeightValues.Normal };
                        case "unset":
                            return new FontWeight { Enum = FontWeightValues.Unset };
                        default:
                            return stringValue;
                    }
            }
            throw new Exception("Cannot unmarshal type IFontWeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FontWeight)untypedValue;
            if (value.Integer != null)
            {
                writer.WriteRawValue(value.Integer.Value.ToString());
                return;
            }
            if (value.Double != null)
            {
                writer.WriteRawValue(value.Double.Value.ToString());
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case FontWeightValues.The100:
                        writer.WriteRawValue("100");
                        return;
                    case FontWeightValues.The200:
                        writer.WriteRawValue("200");
                        return;
                    case FontWeightValues.The300:
                        writer.WriteRawValue("300");
                        return;
                    case FontWeightValues.The400:
                        writer.WriteRawValue("400");
                        return;
                    case FontWeightValues.The500:
                        writer.WriteRawValue("500");
                        return;
                    case FontWeightValues.The600:
                        writer.WriteRawValue("600");
                        return;
                    case FontWeightValues.The700:
                        writer.WriteRawValue("700");
                        return;
                    case FontWeightValues.The800:
                        writer.WriteRawValue("800");
                        return;
                    case FontWeightValues.The900:
                        writer.WriteRawValue("900");
                        return;
                    case FontWeightValues.Bold:
                        writer.WriteRawValue("bold");
                        return;
                    case FontWeightValues.Bolder:
                        writer.WriteRawValue("bolder");
                        return;
                    case FontWeightValues.Inherit:
                        writer.WriteRawValue("inherit");
                        return;
                    case FontWeightValues.Initial:
                        writer.WriteRawValue("initial");
                        return;
                    case FontWeightValues.Lighter:
                        writer.WriteRawValue("lighter");
                        return;
                    case FontWeightValues.Normal:
                        writer.WriteRawValue("normal");
                        return;
                    case FontWeightValues.Unset:
                        writer.WriteRawValue("unset");
                        return;

                }
            }

            if (!string.IsNullOrEmpty(value.String))
            {
                writer.WriteRawValue(value.String);
                return;
            }
            throw new Exception("Cannot marshal type IFontWeightUnion");
        }

        public static readonly IFontWeightUnionConverter Singleton = new IFontWeightUnionConverter();
    }
}
