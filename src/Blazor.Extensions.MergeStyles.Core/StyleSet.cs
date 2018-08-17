using Blazor.Extensions.MergeStyles.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{

    public class StyleSet : ReadOnlyDictionary<(string key, string properertyName), object>, IStyleSet
    {
        Type type;
        private Dictionary<string, object> subComponentStyles;
        private Style root;
        private Style child;
        public Style Root { get => this.root; set => SetProperty(ref this.root, value); }

        public Style Child { get => this.child; set => SetProperty(ref this.child, value); }

        protected bool SetProperty<TValue>(ref TValue field, TValue value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            var key = (propertyName.Kebab(), propertyName);
            //Remove the value if default
            if (value == default && this.Dictionary.ContainsKey(key))
            {
                this.Dictionary.Remove(key);
            }
            //add or update the new value
            else
            {
                this.Dictionary[key] = value;
            }
            return true;
        }

        public bool? Bolean { get; internal set; }

        public bool IsBool => this.Bolean.HasValue;

        [JsonProperty("SubComponentStyles")]
        public Dictionary<string, object> SubComponentStyles
        {
            get
            {
                if (this.subComponentStyles == null)
                {
                    var subComponentStyles = new Dictionary<string, object>();
                    SetProperty(ref this.subComponentStyles, subComponentStyles);
                }
                return this.subComponentStyles;
            }
            set
            {
                SetProperty(ref this.subComponentStyles, value);
            }
        }

        void IStyleSet.AddStyle(string key, Style style)
        {
            var prop = this.GetType().GetProperty(key);
            prop?.SetValue(this, style);
        }


        public StyleSet() : base(new Dictionary<(string key, string properertyName), object>())
        {
            this.type = this.GetType();
        }


        public override bool Equals(object obj)
        {
            if (!(obj is StyleSet style))
                return false;
            if (this.Dictionary.AreEquals(style.Dictionary) && this.SubComponentStyles?.AreEquals(style?.SubComponentStyles) == true)
                return true;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Dictionary.Select(s => s.Value).Join(" ");
        }
    }


    public class StyleSet<T> : StyleSet, IStyleSet<T>
        where T : StyleSet<T>
    {

        public static implicit operator StyleSet<T>(bool value) => new StyleSet<T>() { Bolean = value };

        public static explicit operator bool(StyleSet<T> value) => value.IsBool ? value.Bolean.Value : throw new InvalidCastException("The style set is not a boolean value");


    }
}
