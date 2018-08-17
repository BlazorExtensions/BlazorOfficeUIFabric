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

    internal class AnimationFillModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AnimationFillMode) || t == typeof(AnimationFillMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "backwards":
                    return AnimationFillMode.Backwards;
                case "both":
                    return AnimationFillMode.Both;
                case "forwards":
                    return AnimationFillMode.Forwards;
                case "inherit":
                    return AnimationFillMode.Inherit;
                case "initial":
                    return AnimationFillMode.Initial;
                case "none":
                    return AnimationFillMode.None;
                case "unset":
                    return AnimationFillMode.Unset;
            }
            throw new Exception("Cannot unmarshal type AnimationFillMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                writer.WriteRawValue(null);
                return;
            }
            var value = (AnimationFillMode)untypedValue;
            switch (value)
            {
                case AnimationFillMode.Backwards:
                    writer.WriteRawValue("backwards");
                    return;
                case AnimationFillMode.Both:
                    writer.WriteRawValue("both");
                    return;
                case AnimationFillMode.Forwards:
                    writer.WriteRawValue("forwards");
                    return;
                case AnimationFillMode.Inherit:
                    writer.WriteRawValue("inherit");
                    return;
                case AnimationFillMode.Initial:
                    writer.WriteRawValue("initial");
                    return;
                case AnimationFillMode.None:
                    writer.WriteRawValue("none");
                    return;
                case AnimationFillMode.Unset:
                    writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type AnimationFillMode");
        }

        public static readonly AnimationFillModeConverter Singleton = new AnimationFillModeConverter();
    }
}
