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

    internal class ResizeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Resize) || t == typeof(Resize?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "block":
                    return Resize.Block;
                case "both":
                    return Resize.Both;
                case "horizontal":
                    return Resize.Horizontal;
                case "inherit":
                    return Resize.Inherit;
                case "initial":
                    return Resize.Initial;
                case "inline":
                    return Resize.Inline;
                case "none":
                    return Resize.None;
                case "unset":
                    return Resize.Unset;
                case "vertical":
                    return Resize.Vertical;
            }
            throw new Exception("Cannot unmarshal type Resize");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (Resize)untypedValue;
            switch (value)
            {
                case Resize.Block:
                     writer.WriteRawValue("block");
                    return;
                case Resize.Both:
                     writer.WriteRawValue("both");
                    return;
                case Resize.Horizontal:
                     writer.WriteRawValue("horizontal");
                    return;
                case Resize.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case Resize.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case Resize.Inline:
                     writer.WriteRawValue("inline");
                    return;
                case Resize.None:
                     writer.WriteRawValue("none");
                    return;
                case Resize.Unset:
                     writer.WriteRawValue("unset");
                    return;
                case Resize.Vertical:
                     writer.WriteRawValue("vertical");
                    return;
            }
            throw new Exception("Cannot marshal type Resize");
        }

        public static readonly ResizeConverter Singleton = new ResizeConverter();
    }
}
