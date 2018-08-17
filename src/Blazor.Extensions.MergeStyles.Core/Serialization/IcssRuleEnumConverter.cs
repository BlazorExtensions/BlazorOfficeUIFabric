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

    internal class IcssRuleEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CssRule) || t == typeof(CssRule?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "inherit":
                    return CssRule.Inherit;
                case "initial":
                    return CssRule.Initial;
                case "unset":
                    return CssRule.Unset;
            }
            throw new Exception("Cannot unmarshal type IcssRuleEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (CssRule)untypedValue;
            switch (value)
            {
                case CssRule.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case CssRule.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case CssRule.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type IcssRuleEnum");
        }

        public static readonly IcssRuleEnumConverter Singleton = new IcssRuleEnumConverter();
    }
}
