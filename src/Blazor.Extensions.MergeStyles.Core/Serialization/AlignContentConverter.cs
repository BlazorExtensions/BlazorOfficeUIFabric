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

    internal class AlignContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlignContent) || t == typeof(AlignContent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return AlignContent.Center;
                case "flex-end":
                    return AlignContent.FlexEnd;
                case "flex-start":
                    return AlignContent.FlexStart;
                case "inherit":
                    return AlignContent.Inherit;
                case "initial":
                    return AlignContent.Initial;
                case "space-around":
                    return AlignContent.SpaceAround;
                case "space-between":
                    return AlignContent.SpaceBetween;
                case "stretch":
                    return AlignContent.Stretch;
                case "unset":
                    return AlignContent.Unset;
            }
            throw new Exception("Cannot unmarshal type AlignContent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                writer.WriteRawValue(null);
                return;
            }
            var value = (AlignContent)untypedValue;
            switch (value)
            {
                case AlignContent.Center:
                    writer.WriteRawValue("center");
                    return;
                case AlignContent.FlexEnd:
                    writer.WriteRawValue("flex-end");
                    return;
                case AlignContent.FlexStart:
                    writer.WriteRawValue("flex-start");
                    return;
                case AlignContent.Inherit:
                    writer.WriteRawValue("inherit");
                    return;
                case AlignContent.Initial:
                    writer.WriteRawValue("initial");
                    return;
                case AlignContent.SpaceAround:
                    writer.WriteRawValue("space-around");
                    return;
                case AlignContent.SpaceBetween:
                    writer.WriteRawValue("space-between");
                    return;
                case AlignContent.Stretch:
                    writer.WriteRawValue("stretch");
                    return;
                case AlignContent.Unset:
                    writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type AlignContent");
        }

        public static readonly AlignContentConverter Singleton = new AlignContentConverter();
    }
}
