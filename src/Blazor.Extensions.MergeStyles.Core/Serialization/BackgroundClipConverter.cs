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

    internal class BackgroundClipConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BackgroundClip) || t == typeof(BackgroundClip?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "border-box":
                    return BackgroundClip.BorderBox;
                case "content-box":
                    return BackgroundClip.ContentBox;
                case "inherit":
                    return BackgroundClip.Inherit;
                case "initial":
                    return BackgroundClip.Initial;
                case "padding-box":
                    return BackgroundClip.PaddingBox;
                case "text":
                    return BackgroundClip.Text;
                case "unset":
                    return BackgroundClip.Unset;
            }
            throw new Exception("Cannot unmarshal type BackgroundClip");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (BackgroundClip)untypedValue;
            switch (value)
            {
                case BackgroundClip.BorderBox:
                     writer.WriteRawValue("border-box");
                    return;
                case BackgroundClip.ContentBox:
                     writer.WriteRawValue("content-box");
                    return;
                case BackgroundClip.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case BackgroundClip.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case BackgroundClip.PaddingBox:
                     writer.WriteRawValue("padding-box");
                    return;
                case BackgroundClip.Text:
                     writer.WriteRawValue("text");
                    return;
                case BackgroundClip.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type BackgroundClip");
        }

        public static readonly BackgroundClipConverter Singleton = new BackgroundClipConverter();
    }
}
