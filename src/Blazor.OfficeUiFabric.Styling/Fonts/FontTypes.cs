using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public partial class FontTypes : ReadOnlyDictionary<string, FontType>
    {
        public FontTypes() : base(new Dictionary<string, FontType>())
        {
            this.Caption = new FontType();
            this.Default = new FontType();
            this.Disabled = new FontType();
            this.H1 = new FontType();
            this.H2 = new FontType();
            this.H3 = new FontType();
            this.H4 = new FontType();
            this.H5 = new FontType();

        }

        protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
            where T : FontType
        {
            if (propertyName == null)
                return;
            if (value == default && this.Dictionary.ContainsKey(propertyName))
            {
                this.Dictionary.Remove(propertyName);
            }
            else
            {
                this.Dictionary[propertyName] = field = value;
            }
        }

        public FontType Caption { get => this.caption; set => this.SetProperty(ref this.caption, value); }
        public FontType Default { get => this.@default; set => this.SetProperty(ref this.@default, value); }
        public FontType Disabled { get => this.disabled; set => this.SetProperty(ref this.disabled, value); }
        public FontType H1 { get => this.h1; set => this.SetProperty(ref this.h1, value); }
        public FontType H2 { get => this.h2; set => this.SetProperty(ref this.h2, value); }
        public FontType H3 { get => this.h3; set => this.SetProperty(ref this.h3, value); }
        public FontType H4 { get => this.h4; set => this.SetProperty(ref this.h4, value); }
        public FontType H5 { get => this.h5; set => this.SetProperty(ref this.h5, value); }

        static Lazy<FontTypes> lazyDefaultFontTypes = new Lazy<FontTypes>(() => new FontTypes()
        {
            Default = {
                FontFamily = "default",
                FontSize = "medium",
                FontWeight = "default"
            },
            Caption = {
                FontSize = "xSmall"
            },
            H1 = {
              FontSize= "mega",
              FontWeight= "light"
            },

            H2 = {
              FontSize= "xxxLarge",
              FontWeight= "light"
            },

            H3 = {
              FontSize= "xxLarge",
              FontWeight= "light"
            },

            H4 = {
              FontSize= "xLarge",
              FontWeight= "light"
            },

            H5 = {
              FontSize= "large",
              FontWeight= "light"
            }
        });

        public static FontTypes DefaultFontType = lazyDefaultFontTypes.Value;
        private FontType caption;
        private FontType @default;
        private FontType disabled;
        private FontType h1;
        private FontType h2;
        private FontType h3;
        private FontType h4;
        private FontType h5;
    }


}
