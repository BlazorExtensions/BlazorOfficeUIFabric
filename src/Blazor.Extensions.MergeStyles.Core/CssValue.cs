using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public struct CssValue : IComparable<string>, IComparable<double>, IComparable<bool>, IComparable<int>
    {
        public CssValue(int value)
        {
            this.Integer = value;
            this.Double = null;
            this.String = null;
            this.Bolean = null;
        }

        public CssValue(double value)
        {
            this.Double = value;
            this.String = null;
            this.Bolean = null;
            this.Integer = null;
        }

        public CssValue(string value)
        {
            this.String = value;
            this.Double = null;
            this.Bolean = null;
            this.Integer = null;
        }

        public CssValue(bool value)
        {
            this.Bolean = value;
            this.Double = null;
            this.String = null;
            this.Integer = null;
        }

        public bool IsDouble => this.Double.HasValue;

        public bool IsInteger => this.Integer.HasValue;

        public bool IsNumber => this.IsDouble || this.IsInteger;

        public bool IsBolean => this.Bolean.HasValue;

        public string String { get; internal set; }

        public bool? Bolean { get; internal set; }

        public double? Double { get; internal set; }

        public int? Integer { get; internal set; }

        public bool IsString => !this.IsNumber && !this.IsBolean;

        public static implicit operator CssValue(in double value) => new CssValue(value);
        public static implicit operator CssValue(in int value) => new CssValue(value);
        public static implicit operator CssValue(in string value) => new CssValue(value);
        public static implicit operator CssValue(in bool value) => new CssValue(value);

        public static implicit operator CssValue(in AlignContent value) => new CssValue { String = JsonConvert.SerializeObject(value, RawConverter.Settings) };

        public static explicit operator string(in CssValue rule) => rule.IsString ? rule.String : throw new InvalidCastException($"The rule {rule} is not a string value");
        public static explicit operator double(in CssValue rule) => rule.Double ?? throw new InvalidCastException($"The rule {rule} is not a double value");
        public static explicit operator int(in CssValue rule) => rule.Integer ?? throw new InvalidCastException($"The rule {rule} is not a integer value");
        public static explicit operator bool(in CssValue rule) => rule.Bolean ?? throw new InvalidCastException($"The rule {rule} is not a bolean value");


        public bool IsNull => this.String is null && this.Double is null && this.Bolean is null && this.Integer is null;

        public override bool Equals(object obj)
        {
            if (!(obj is CssValue other))
            {
                return false;
            }
            if (other.IsDouble)
                return other.Double == this.Double;

            if (other.IsInteger)
                return other.Integer == this.Integer;

            else if (other.IsBolean)
                return other.Bolean == this.Bolean;

            return other.String == this.String;
        }

        public override int GetHashCode()
        {
            if (this.IsDouble)
                return this.Double.Value.GetHashCode();
            if (this.IsInteger)
                return this.Integer.Value.GetHashCode();
            if (this.IsBolean)
                return this.Bolean.Value.GetHashCode();
            return this.String.GetHashCode();
        }

       

        public static bool operator ==(CssValue rule, string value) => rule.String == value;
        public static bool operator !=(CssValue rule, string value) => rule.String != value;

        public static bool operator ==(CssValue rule1, CssValue rule2)
        {
            if (rule1.IsNull || rule2.IsNull)
                return false;
            return rule1.String == rule2.String || rule1.Double == rule2.Double || rule1.Integer == rule2.Integer;
        }

        public static bool operator !=(CssValue rule1, CssValue rule2)
        {
            if (rule1.IsNull || rule2.IsNull)
                return true;
            return rule1.String == rule2.String || rule1.Double == rule2.Double || rule1.Integer == rule1.Integer;
        }

        public override string ToString()
        {
            return this.Double?.ToString() ?? this.Integer?.ToString() ?? this.String ?? this.Bolean?.ToString();
        }


        public string Replace(string oldValue, string newValue)
        {
            if (!this.IsString)
                throw new InvalidOperationException($"This rule is not a string, value {this}");
            return this.String.Replace(oldValue, newValue);
        }

        public int CompareTo(double other)
        {
            if (!this.IsDouble)
                return 1;

            return this.Double == other ? 0 : 1;
        }

        public int CompareTo(string other)
        {

            if (this.String != null)
                return 1;
            return this.String == other ? 0 : 1;
        }
        public int CompareTo(bool other)
        {
            if (!this.IsBolean)
                return 1;
            return this.Bolean == other ? 0 : 1;
        }

        public int CompareTo(int other)
        {
            if (!this.IsInteger)
                return 1;

            return this.Integer == other ? 0 : 1;
        }
    }
}
