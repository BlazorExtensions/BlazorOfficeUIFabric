using Blazor.Extensions.MergeStyles;
using System;
using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public partial class Typography 
    {
        public FontFamilies Families { get; set; }
        public FontSizes Sizes { get; set; }
        public FontWeights Weights { get; set; }

        public FontTypes Types { get; set; }

        public static Typography DefaultTypography => lazyDefault.Value;
        static Lazy<Typography> lazyDefault = new Lazy<Typography>(() => new Typography()
        {
            Families = FontFamilies.DefaultFontFamilies,
            Sizes = FontSizes.DefaultFontSizes,
            Weights = FontWeights.DefaultFontWeight,
            Types = FontTypes.DefaultFontType,
        });
    }
}
