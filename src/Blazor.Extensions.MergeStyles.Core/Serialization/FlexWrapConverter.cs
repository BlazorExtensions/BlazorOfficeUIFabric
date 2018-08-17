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

    internal class FlexWrapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FlexWrap) || t == typeof(FlexWrap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "inherit":
                    return FlexWrap.Inherit;
                case "initial":
                    return FlexWrap.Initial;
                case "nowrap":
                    return FlexWrap.Nowrap;
                case "unset":
                    return FlexWrap.Unset;
                case "wrap":
                    return FlexWrap.Wrap;
                case "wrap-reverse":
                    return FlexWrap.WrapReverse;
            }
            throw new Exception("Cannot unmarshal type FlexWrap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (FlexWrap)untypedValue;
            switch (value)
            {
                case FlexWrap.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case FlexWrap.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case FlexWrap.Nowrap:
                     writer.WriteRawValue("nowrap");
                    return;
                case FlexWrap.Unset:
                     writer.WriteRawValue("unset");
                    return;
                case FlexWrap.Wrap:
                     writer.WriteRawValue("wrap");
                    return;
                case FlexWrap.WrapReverse:
                     writer.WriteRawValue("wrap-reverse");
                    return;
            }
            throw new Exception("Cannot marshal type FlexWrap");
        }

        public static readonly FlexWrapConverter Singleton = new FlexWrapConverter();
    }
}
