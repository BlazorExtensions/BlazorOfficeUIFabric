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

    internal class AlignItemsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlignItems) || t == typeof(AlignItems?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "baseline":
                    return AlignItems.Baseline;
                case "center":
                    return AlignItems.Center;
                case "flex-end":
                    return AlignItems.FlexEnd;
                case "flex-start":
                    return AlignItems.FlexStart;
                case "inherit":
                    return AlignItems.Inherit;
                case "initial":
                    return AlignItems.Initial;
                case "stretch":
                    return AlignItems.Stretch;
                case "unset":
                    return AlignItems.Unset;
            }
            throw new Exception("Cannot unmarshal type AlignItems");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                writer.WriteRawValue(null);
                return;
            }
            var value = (AlignItems)untypedValue;
            switch (value)
            {
                case AlignItems.Baseline:
                    writer.WriteRawValue("baseline");
                    return;
                case AlignItems.Center:
                    writer.WriteRawValue("center");
                    return;
                case AlignItems.FlexEnd:
                    writer.WriteRawValue("flex-end");
                    return;
                case AlignItems.FlexStart:
                    writer.WriteRawValue("flex-start");
                    return;
                case AlignItems.Inherit:
                    writer.WriteRawValue("inherit");
                    return;
                case AlignItems.Initial:
                    writer.WriteRawValue("initial");
                    return;
                case AlignItems.Stretch:
                    writer.WriteRawValue("stretch");
                    return;
                case AlignItems.Unset:
                    writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type AlignItems");
        }

        public static readonly AlignItemsConverter Singleton = new AlignItemsConverter();
    }
}
