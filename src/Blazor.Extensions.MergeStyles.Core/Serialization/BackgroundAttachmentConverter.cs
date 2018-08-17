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

    internal class BackgroundAttachmentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BackgroundAttachment) || t == typeof(BackgroundAttachment?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fixed":
                    return BackgroundAttachment.Fixed;
                case "inherit":
                    return BackgroundAttachment.Inherit;
                case "initial":
                    return BackgroundAttachment.Initial;
                case "local":
                    return BackgroundAttachment.Local;
                case "scroll":
                    return BackgroundAttachment.Scroll;
                case "unset":
                    return BackgroundAttachment.Unset;
            }
            throw new Exception("Cannot unmarshal type BackgroundAttachment");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue( null);
                return;
            }
            var value = (BackgroundAttachment)untypedValue;
            switch (value)
            {
                case BackgroundAttachment.Fixed:
                     writer.WriteRawValue( "fixed");
                    return;
                case BackgroundAttachment.Inherit:
                     writer.WriteRawValue( "inherit");
                    return;
                case BackgroundAttachment.Initial:
                     writer.WriteRawValue( "initial");
                    return;
                case BackgroundAttachment.Local:
                     writer.WriteRawValue( "local");
                    return;
                case BackgroundAttachment.Scroll:
                     writer.WriteRawValue( "scroll");
                    return;
                case BackgroundAttachment.Unset:
                     writer.WriteRawValue( "unset");
                    return;
            }
            throw new Exception("Cannot marshal type BackgroundAttachment");
        }

        public static readonly BackgroundAttachmentConverter Singleton = new BackgroundAttachmentConverter();
    }
}
