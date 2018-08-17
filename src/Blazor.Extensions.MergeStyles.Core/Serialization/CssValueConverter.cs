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

    internal class CssValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CssValue) || t == typeof(CssValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new CssValue { Bolean = boolValue };
                case JsonToken.Integer:
                    var intValue = serializer.Deserialize<int>(reader);
                    return new CssValue { Integer = intValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new CssValue { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new CssValue { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type CssValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CssValue)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.IsInteger)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.IsString)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.IsBolean)
            {
                serializer.Serialize(writer, value.Bolean);
            }
            throw new Exception("Cannot marshal type CssValue");
        }

        public static readonly CssValueConverter Singleton = new CssValueConverter();
    }
}
