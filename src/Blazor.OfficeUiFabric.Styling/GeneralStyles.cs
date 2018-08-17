using Blazor.Extensions.MergeStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling
{
    public class GeneralStyles
    {
        public static Style Normalize => lazyNormalize.Value;

        static Lazy<Style> lazyNormalize = new Lazy<Style>(() => new Style()
        {
            BoxShadow = "none",
            Margin = 0,
            Padding = 0,
            BoxSizing = BoxSizing.BorderBox
        });


        public static Style NoWrap => lazyNoWrap.Value;

        static Lazy<Style> lazyNoWrap = new Lazy<Style>(() => new Style()
        {
            Overflow = Overflow.Hidden,
            TextOverflow = "ellipsis",
            WhiteSpace = "nowrap"
        });
    }
}
