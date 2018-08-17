using Blazor.Extensions.MergeStyles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{

    public partial class FontWeights : RawStyleBase
    {
        private FontWeight bold;
        private FontWeight light;
        private FontWeight regular;
        private FontWeight semibold;
        private FontWeight semiLight;

        public FontWeights()
        {

        }

        protected void SetProperty(in FontWeight value, [CallerMemberName]string propertyName = null)
        {
            this.Dictionary[propertyName] = value;
        }

        [JsonProperty("bold", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight Bold { get => this.bold; set => this.bold = value; }
        public FontWeight Light { get => this.light; set => this.light = value; }
        public FontWeight Regular { get => this.regular; set => this.regular = value; }
        public FontWeight SemiBold { get => this.semibold; set => this.semibold = value; }
        public FontWeight SemiLight { get => this.semiLight; set => this.semiLight = value; }

        public static FontWeights DefaultFontWeight => lazyFontWeight.Value;

        static Lazy<FontWeights> lazyFontWeight = new Lazy<FontWeights>(() => new FontWeights
        {
            Regular = FontEngine.StandardFontWeight.Regular,
            Light = FontEngine.StandardFontWeight.Light,
            SemiBold = FontEngine.StandardFontWeight.SemiBold,
            Bold = FontEngine.StandardFontWeight.Bold
        });

    }
}
