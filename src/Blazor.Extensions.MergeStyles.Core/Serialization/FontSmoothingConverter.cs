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

    internal class FontSmoothingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontSmoothing) || t == typeof(FontSmoothing?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "antialiased":
                    return FontSmoothing.Antialiased;
                case "grayscale":
                    return FontSmoothing.Grayscale;
                case "none":
                    return FontSmoothing.None;
                case "subpixel-antialiased":
                    return FontSmoothing.SubpixelAntialiased;
            }
            throw new Exception("Cannot unmarshal type FontSmoothing");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (FontSmoothing)untypedValue;
            switch (value)
            {
                case FontSmoothing.Antialiased:
                     writer.WriteRawValue("antialiased");
                    return;
                case FontSmoothing.Grayscale:
                     writer.WriteRawValue("grayscale");
                    return;
                case FontSmoothing.None:
                     writer.WriteRawValue("none");
                    return;
                case FontSmoothing.SubpixelAntialiased:
                     writer.WriteRawValue("subpixel-antialiased");
                    return;
            }
            throw new Exception("Cannot marshal type FontSmoothing");
        }

        public static readonly FontSmoothingConverter Singleton = new FontSmoothingConverter();
    }
}
