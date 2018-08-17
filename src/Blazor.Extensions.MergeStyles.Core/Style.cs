// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do one of these:
//
//    using Blazor.Extensions.MergeStyles;
//
//    var iRawStyle = IRawStyle.FromJson(jsonString);
//    var iStyleBase = IStyleBase.FromJson(jsonString);

namespace Blazor.Extensions.MergeStyles
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Linq;
    using Blazor.Extensions.MergeStyles.Extensions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    public class Style : RawStyle, IEnumerable<Style>, IComparable<Style>
    {
        public Style()
        {

        }

        public Style(Style[] styles)
        {
            this.Array = styles;
        }


        public static implicit operator Style(Style[] values) => new Style() { Array = values };

        public static implicit operator Style(string value) => new Style() { String = value };

        public static implicit operator Style(bool value) => new Style() { Bool = value };

        public static implicit operator Style(int value) => new Style() { Numnber = value };

        public static implicit operator Style(string[] values) => values.Select(v => new Style { String = v }).ToArray();

        public static explicit operator int(Style style) => style.Numnber ?? throw new InvalidCastException("The style is not a number value");
        public static explicit operator bool(Style style) => style.Bool ?? throw new InvalidCastException("The style is not a boolean value");
        public static explicit operator string(Style style) => style.IsString ? style.String : throw new InvalidCastException("The style is not a string value");


        public override bool Equals(object obj)
        {
            if (!(obj is Style style))
                return false;

            if (this.IsNumber && style.IsNumber)
                return this.Numnber == style.Numnber;

            if (this.IsString && style.IsString)
                return this.String == style.String;

            if (this.IsBool && style.IsBool)
                return this.Bool == style.Bool;

            if (this.IsArray && style.IsArray)
                return this.Array.Any(t => style.Array.Any(o => !o.Equals(t)));

            if (this.Dictionary.AreEquals(style.Dictionary) && this.Selectors.AreEquals(style.Selectors))
                return true;

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            if (this.IsArray)
                return this.Array.GetHashCode();
            if (this.IsNumber)
                return this.Numnber.Value.GetHashCode();
            if (this.IsString)
                return this.String.GetHashCode();
            if (this.IsBool)
                return this.Bool.Value.GetHashCode();

            return this.GetHashCode();
        }

        public override string ToString()
        {
            if (this.IsArray)
                return this.Array.Select(i => i.ToString()).Join("");
            if (this.IsNumber)
                return this.Numnber.Value.ToString();
            if (this.IsString)
                return this.String;
            if (this.IsBool)
                return this.Bool.Value.ToString();
            if (this.Dictionary.Any())
                return this.Dictionary.Select(s => s.Value).Join("");
            return base.ToString();
        }

        IEnumerator<Style> IEnumerable<Style>.GetEnumerator()
        {
            return this.Enumerator;
        }

        public int CompareTo(Style other)
        {
            if (this.IsNull || other.IsNull)
                return 1;

            if (this.IsString && other.IsString)
                return this.String == other.String ? 0 : 1;

            if (this.IsNumber && other.IsNumber)
                return this.Numnber == other.Numnber ? 0 : 1;

            if (this.IsBool && other.IsBool)
                return this.Bool == other.Bool ? 0 : 1;

            if (this.IsArray && other.IsArray)
                return this.Array.Any(t => other.Array.Any(o => o.CompareTo(t) != 0)) ? 1 : 0;

            if (this.Dictionary.AreEquals(other.Dictionary))
                return 0;

            return 1;
        }

        public StyleEnum Enumerator => new StyleEnum(this.Array);
    }

    public class StyleEnum : IEnumerator<Style>
    {
        private int position = -1;

        public StyleEnum(Style[] styles)
        {
            this.Styles = styles;
        }

        public Style[] Styles { get; }

        public Style Current
        {
            get
            {
                try
                {
                    return this.Styles[this.position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            this.position++;
            return (this.position < this.Styles.Length);
        }

        public void Reset()
        {
            this.position = -1;
        }


    }
    /// <summary>
    /// IStyleObject extends a raw style objects, but allows selectors to be defined
    /// under the selectors node.
    /// </summary>
    public partial class RawStyle : RawStyleBase
    {
        private Dictionary<string, Style> _selectors;
        private string _displayName;

        public RawStyle()
        {

        }


        public bool IsString => this.String != null;
        public bool IsNumber => this.Numnber.HasValue;
        public bool IsBool => this.Bool.HasValue;
        public bool IsArray => this.Array != null;

        [NotParse]
        public Style[] Array { get; internal set; }

        [NotParse]
        public string String { get; internal set; }

        [NotParse]
        public bool? Bool { get; internal set; }

        [NotParse]
        public int? Numnber { get; internal set; }

        public bool IsNull => this.Bool is null && this.Numnber is null && this.String is null && this.Array is null;

        /// <summary>
        /// Display name for the style.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get => this._displayName; set => SetProperty(ref this._displayName, value); }

        /// <summary>
        /// Custom selectors for the style.
        /// </summary>

        public Dictionary<string, Style> Selectors
        {
            get
            {
                if (this._selectors == null)
                {
                    var selector = new Dictionary<string, Style>();
                    SetProperty(ref this._selectors, selector);
                }
                return this._selectors;

            }

            set
            {
                SetProperty(ref this._selectors, value);
            }
        }



    };





    public class IStyleBase
    {
        public static object FromJson(string json) => JsonConvert.DeserializeObject<object>(json, Blazor.Extensions.MergeStyles.RawConverter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this Style self) => JsonConvert.SerializeObject(self, Blazor.Extensions.MergeStyles.RawConverter.Settings);
    }


    internal class IStyleBaseUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(Style);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Style { };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Style { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Style { String = stringValue };
                case JsonToken.StartObject:
                    return serializer.Deserialize<Style>(reader);
            }
            throw new Exception("Cannot unmarshal type IStyleBaseUnion");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var @object = (Style)value;
            if (@object.IsNull)
            {
                writer.WriteRawValue(null);
                return;
            }
            if (@object.Bool != null)
            {
                writer.WriteRawValue(@object.Bool.Value.ToString());
                return;
            }
            if (@object.String != null)
            {
                writer.WriteRawValue(@object.String);
                return;
            }

            if (@object.Numnber != null)
            {
                writer.WriteRawValue(@object.Numnber.ToString());
                return;
            }

            if (value != null)
            {
                writer.WriteRawValue(@object.ToString());
                return;
            }
            throw new Exception("Cannot marshal type IStyleBaseUnion");
        }

        public static readonly IStyleBaseUnionConverter Singleton = new IStyleBaseUnionConverter();
    }
}
