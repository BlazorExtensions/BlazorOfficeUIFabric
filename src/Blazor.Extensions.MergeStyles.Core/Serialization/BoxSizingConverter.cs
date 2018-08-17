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

    internal class BoxSizingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoxSizing) || t == typeof(BoxSizing?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "border-box":
                    return BoxSizing.BorderBox;
                case "content-box":
                    return BoxSizing.ContentBox;
                case "inherit":
                    return BoxSizing.Inherit;
                case "initial":
                    return BoxSizing.Initial;
                case "unset":
                    return BoxSizing.Unset;
            }
            throw new Exception("Cannot unmarshal type BoxSizing");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (BoxSizing)untypedValue;
            switch (value)
            {
                case BoxSizing.BorderBox:
                     writer.WriteRawValue("border-box");
                    return;
                case BoxSizing.ContentBox:
                     writer.WriteRawValue("content-box");
                    return;
                case BoxSizing.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case BoxSizing.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case BoxSizing.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type BoxSizing");
        }

        public static readonly BoxSizingConverter Singleton = new BoxSizingConverter();
    }
}
