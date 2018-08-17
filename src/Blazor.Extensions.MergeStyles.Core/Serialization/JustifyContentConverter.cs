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

    internal class JustifyContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(JustifyContent) || t == typeof(JustifyContent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return JustifyContent.Center;
                case "flex-end":
                    return JustifyContent.FlexEnd;
                case "flex-start":
                    return JustifyContent.FlexStart;
                case "inherit":
                    return JustifyContent.Inherit;
                case "initial":
                    return JustifyContent.Initial;
                case "space-around":
                    return JustifyContent.SpaceAround;
                case "space-between":
                    return JustifyContent.SpaceBetween;
                case "space-evenly":
                    return JustifyContent.SpaceEvenly;
                case "unset":
                    return JustifyContent.Unset;
            }
            throw new Exception("Cannot unmarshal type JustifyContent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (JustifyContent)untypedValue;
            switch (value)
            {
                case JustifyContent.Center:
                     writer.WriteRawValue("center");
                    return;
                case JustifyContent.FlexEnd:
                     writer.WriteRawValue("flex-end");
                    return;
                case JustifyContent.FlexStart:
                     writer.WriteRawValue("flex-start");
                    return;
                case JustifyContent.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case JustifyContent.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case JustifyContent.SpaceAround:
                     writer.WriteRawValue("space-around");
                    return;
                case JustifyContent.SpaceBetween:
                     writer.WriteRawValue("space-between");
                    return;
                case JustifyContent.SpaceEvenly:
                     writer.WriteRawValue("space-evenly");
                    return;
                case JustifyContent.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type JustifyContent");
        }

        public static readonly JustifyContentConverter Singleton = new JustifyContentConverter();
    }
}
