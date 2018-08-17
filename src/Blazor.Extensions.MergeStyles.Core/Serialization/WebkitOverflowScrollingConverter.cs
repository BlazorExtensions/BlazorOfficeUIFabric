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

    internal class WebkitOverflowScrollingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WebkitOverflowScrolling) || t == typeof(WebkitOverflowScrolling?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "auto":
                    return WebkitOverflowScrolling.Auto;
                case "touch":
                    return WebkitOverflowScrolling.Touch;
            }
            throw new Exception("Cannot unmarshal type WebkitOverflowScrolling");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (WebkitOverflowScrolling)untypedValue;
            switch (value)
            {
                case WebkitOverflowScrolling.Auto:
                     writer.WriteRawValue("auto");
                    return;
                case WebkitOverflowScrolling.Touch:
                     writer.WriteRawValue("touch");
                    return;
            }
            throw new Exception("Cannot marshal type WebkitOverflowScrolling");
        }

        public static readonly WebkitOverflowScrollingConverter Singleton = new WebkitOverflowScrollingConverter();
    }
}
