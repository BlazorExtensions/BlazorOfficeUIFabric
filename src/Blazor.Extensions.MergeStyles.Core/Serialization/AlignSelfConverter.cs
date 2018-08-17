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

    internal class AlignSelfConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlignSelf) || t == typeof(AlignSelf?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "auto":
                    return AlignSelf.Auto;
                case "baseline":
                    return AlignSelf.Baseline;
                case "center":
                    return AlignSelf.Center;
                case "flex-end":
                    return AlignSelf.FlexEnd;
                case "flex-start":
                    return AlignSelf.FlexStart;
                case "inherit":
                    return AlignSelf.Inherit;
                case "initial":
                    return AlignSelf.Initial;
                case "stretch":
                    return AlignSelf.Stretch;
                case "unset":
                    return AlignSelf.Unset;
            }
            throw new Exception("Cannot unmarshal type AlignSelf");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                 writer.WriteRawValue( null);
                return;
            }
            var value = (AlignSelf)untypedValue;
            switch (value)
            {
                case AlignSelf.Auto:
                     writer.WriteRawValue( "auto");
                    return;
                case AlignSelf.Baseline:
                     writer.WriteRawValue( "baseline");
                    return;
                case AlignSelf.Center:
                     writer.WriteRawValue( "center");
                    return;
                case AlignSelf.FlexEnd:
                     writer.WriteRawValue( "flex-end");
                    return;
                case AlignSelf.FlexStart:
                     writer.WriteRawValue( "flex-start");
                    return;
                case AlignSelf.Inherit:
                     writer.WriteRawValue( "inherit");
                    return;
                case AlignSelf.Initial:
                     writer.WriteRawValue( "initial");
                    return;
                case AlignSelf.Stretch:
                     writer.WriteRawValue( "stretch");
                    return;
                case AlignSelf.Unset:
                     writer.WriteRawValue( "unset");
                    return;
            }
            throw new Exception("Cannot marshal type AlignSelf");
        }

        public static readonly AlignSelfConverter Singleton = new AlignSelfConverter();
    }
}
