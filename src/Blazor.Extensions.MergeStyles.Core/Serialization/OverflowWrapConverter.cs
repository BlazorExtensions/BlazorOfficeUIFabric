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

    internal class OverflowWrapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OverflowWrap) || t == typeof(OverflowWrap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "break-word":
                    return OverflowWrap.BreakWord;
                case "inherit":
                    return OverflowWrap.Inherit;
                case "initial":
                    return OverflowWrap.Initial;
                case "normal":
                    return OverflowWrap.Normal;
                case "unset":
                    return OverflowWrap.Unset;
            }
            throw new Exception("Cannot unmarshal type OverflowWrap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (OverflowWrap)untypedValue;
            switch (value)
            {
                case OverflowWrap.BreakWord:
                     writer.WriteRawValue("break-word");
                    return;
                case OverflowWrap.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case OverflowWrap.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case OverflowWrap.Normal:
                     writer.WriteRawValue("normal");
                    return;
                case OverflowWrap.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type OverflowWrap");
        }

        public static readonly OverflowWrapConverter Singleton = new OverflowWrapConverter();
    }
}
