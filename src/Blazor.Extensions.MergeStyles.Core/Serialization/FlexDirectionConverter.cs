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

    internal class FlexDirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FlexDirection) || t == typeof(FlexDirection?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "column":
                    return FlexDirection.Column;
                case "column-reverse":
                    return FlexDirection.ColumnReverse;
                case "inherit":
                    return FlexDirection.Inherit;
                case "initial":
                    return FlexDirection.Initial;
                case "row":
                    return FlexDirection.Row;
                case "row-reverse":
                    return FlexDirection.RowReverse;
                case "unset":
                    return FlexDirection.Unset;
            }
            throw new Exception("Cannot unmarshal type FlexDirection");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                writer.WriteRawValue(null);
                return;
            }
            var value = (FlexDirection)untypedValue;
            switch (value)
            {
                case FlexDirection.Column:
                    writer.WriteRawValue("column");
                    return;
                case FlexDirection.ColumnReverse:
                    writer.WriteRawValue("column-reverse");
                    return;
                case FlexDirection.Inherit:
                    writer.WriteRawValue("inherit");
                    return;
                case FlexDirection.Initial:
                    writer.WriteRawValue("initial");
                    return;
                case FlexDirection.Row:
                    writer.WriteRawValue("row");
                    return;
                case FlexDirection.RowReverse:
                    writer.WriteRawValue("row-reverse");
                    return;
                case FlexDirection.Unset:
                    writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type FlexDirection");
        }

        public static readonly FlexDirectionConverter Singleton = new FlexDirectionConverter();
    }
}
