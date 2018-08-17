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

    internal class ColumnCountEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColumnCountValues) || t == typeof(ColumnCountValues?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "auto":
                    return ColumnCountValues.Auto;
                case "inherit":
                    return ColumnCountValues.Inherit;
                case "initial":
                    return ColumnCountValues.Initial;
                case "unset":
                    return ColumnCountValues.Unset;
            }
            throw new Exception("Cannot unmarshal type ColumnCountEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (ColumnCountValues)untypedValue;
            switch (value)
            {
                case ColumnCountValues.Auto:
                     writer.WriteRawValue("auto");
                    return;
                case ColumnCountValues.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case ColumnCountValues.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case ColumnCountValues.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type ColumnCountEnum");
        }

        public static readonly ColumnCountEnumConverter Singleton = new ColumnCountEnumConverter();
    }
}
