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

    internal class UserSelectConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UserSelect) || t == typeof(UserSelect?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return UserSelect.All;
                case "auto":
                    return UserSelect.Auto;
                case "contain":
                    return UserSelect.Contain;
                case "inherit":
                    return UserSelect.Inherit;
                case "initial":
                    return UserSelect.Initial;
                case "none":
                    return UserSelect.None;
                case "text":
                    return UserSelect.Text;
                case "unset":
                    return UserSelect.Unset;
            }
            throw new Exception("Cannot unmarshal type UserSelect");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue(null);
                return;
            }
            var value = (UserSelect)untypedValue;
            switch (value)
            {
                case UserSelect.All:
                     writer.WriteRawValue("all");
                    return;
                case UserSelect.Auto:
                     writer.WriteRawValue("auto");
                    return;
                case UserSelect.Contain:
                     writer.WriteRawValue("contain");
                    return;
                case UserSelect.Inherit:
                     writer.WriteRawValue("inherit");
                    return;
                case UserSelect.Initial:
                     writer.WriteRawValue("initial");
                    return;
                case UserSelect.None:
                     writer.WriteRawValue("none");
                    return;
                case UserSelect.Text:
                     writer.WriteRawValue("text");
                    return;
                case UserSelect.Unset:
                     writer.WriteRawValue("unset");
                    return;
            }
            throw new Exception("Cannot marshal type UserSelect");
        }

        public static readonly UserSelectConverter Singleton = new UserSelectConverter();
    }
}
