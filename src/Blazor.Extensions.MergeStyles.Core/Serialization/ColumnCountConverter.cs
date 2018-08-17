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

    internal class ColumnCountConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColumnCount) || t == typeof(ColumnCount?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return (ColumnCount)doubleValue;
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "auto":
                            return new ColumnCount(ColumnCountValues.Auto);
                        case "inherit":
                            return new ColumnCount(ColumnCountValues.Inherit);
                        case "initial":
                            return new ColumnCount(ColumnCountValues.Initial);
                        case "unset":
                            return new ColumnCount(ColumnCountValues.Unset);
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type ColumnCount");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColumnCount)untypedValue;
            if (value.Double != null)
            {
                 writer.WriteRawValue(value.Double.Value.ToString());
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
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
            }
            throw new Exception("Cannot marshal type ColumnCountUnion");
        }

        public static readonly ColumnCountConverter Singleton = new ColumnCountConverter();
    }
}
