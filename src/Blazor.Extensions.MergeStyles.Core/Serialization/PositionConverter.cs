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

    internal class PositionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Position) || t == typeof(Position?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "absolute":
                    return Position.Absolute;
                case "fixed":
                    return Position.Fixed;
                case "inherit":
                    return Position.Inherit;
                case "initial":
                    return Position.Initial;
                case "relative":
                    return Position.Relative;
                case "static":
                    return Position.Static;
                case "sticky":
                    return Position.Sticky;
                case "unset":
                    return Position.Unset;
            }
            throw new Exception("Cannot unmarshal type Position");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (Position)untypedValue;
            switch (value)
            {
                case Position.Absolute:
                     writer.WriteRawValue("absolute");
                    return;
                case Position.Fixed:
                     writer.WriteRawValue("fixed");
                    return;
                case Position.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case Position.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case Position.Relative:
                     writer.WriteRawValue("relative");
                    return;
                case Position.Static:
                     writer.WriteRawValue("static");
                    return;
                case Position.Sticky:
                     writer.WriteRawValue("sticky");
                    return;
                case Position.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type Position");
        }

        public static readonly PositionConverter Singleton = new PositionConverter();
    }
}
