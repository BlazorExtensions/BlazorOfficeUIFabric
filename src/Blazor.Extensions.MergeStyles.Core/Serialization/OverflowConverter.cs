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

    internal class OverflowConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Overflow) || t == typeof(Overflow?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "auto":
                    return Overflow.Auto;
                case "hidden":
                    return Overflow.Hidden;
                case "inherit":
                    return Overflow.Inherit;
                case "initial":
                    return Overflow.Initial;
                case "scroll":
                    return Overflow.Scroll;
                case "unset":
                    return Overflow.Unset;
                case "visible":
                    return Overflow.Visible;
            }
            throw new Exception("Cannot unmarshal type Overflow");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (Overflow)untypedValue;
            switch (value)
            {
                case Overflow.Auto:
                     writer.WriteRawValue("auto");
                    return;
                case Overflow.Hidden:
                     writer.WriteRawValue("hidden");
                    return;
                case Overflow.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case Overflow.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case Overflow.Scroll:
                     writer.WriteRawValue("scroll");
                    return;
                case Overflow.Unset:
                     writer.WriteRawValue("unset");
                    return;
                case Overflow.Visible:
                     writer.WriteRawValue("visible");
                    return;
            }
            throw new Exception("Cannot marshal type Overflow");
        }

        public static readonly OverflowConverter Singleton = new OverflowConverter();
    }
}
