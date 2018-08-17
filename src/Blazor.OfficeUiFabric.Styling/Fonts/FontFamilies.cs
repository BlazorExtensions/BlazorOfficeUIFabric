using Blazor.OfficeUiFabric.Utilities;
using System;
using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public partial class FontFamilies : ExpandableObject<string>
    {

        public string Default { get => this.@default; set => SetProperty(ref this.@default, value); }

        public string Monospace { get => this.monospace; set => SetProperty(ref this.monospace, value); }

        public static FontFamilies DefaultFontFamilies => lazyDefaultFontFamilies.Value;

        static Lazy<FontFamilies> lazyDefaultFontFamilies = new Lazy<FontFamilies>(() => new FontFamilies()
        {
            Default = FontStyles.DefaultFontStyle.Medium.FontFamily,
            Monospace = "Menlo, Monaco, \"Courier New\", monospace"
        });
        private string @default;
        private string monospace;
    }


}
