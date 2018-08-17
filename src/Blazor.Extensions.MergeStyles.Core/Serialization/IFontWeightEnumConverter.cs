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

    internal class IFontWeightEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontWeightValues) || t == typeof(FontWeightValues?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "100":
                    return FontWeightValues.The100;
                case "200":
                    return FontWeightValues.The200;
                case "300":
                    return FontWeightValues.The300;
                case "400":
                    return FontWeightValues.The400;
                case "500":
                    return FontWeightValues.The500;
                case "600":
                    return FontWeightValues.The600;
                case "700":
                    return FontWeightValues.The700;
                case "800":
                    return FontWeightValues.The800;
                case "900":
                    return FontWeightValues.The900;
                case "bold":
                    return FontWeightValues.Bold;
                case "bolder":
                    return FontWeightValues.Bolder;
                case "inherit":
                    return FontWeightValues.Inherit;
                case "initial":
                    return FontWeightValues.Initial;
                case "lighter":
                    return FontWeightValues.Lighter;
                case "normal":
                    return FontWeightValues.Normal;
                case "unset":
                    return FontWeightValues.Unset;
            }
            throw new Exception("Cannot unmarshal type IFontWeightEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (FontWeightValues)untypedValue;
            switch (value)
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
            throw new Exception("Cannot marshal type IFontWeightEnum");
        }

        public static readonly IFontWeightEnumConverter Singleton = new IFontWeightEnumConverter();
    }
}
