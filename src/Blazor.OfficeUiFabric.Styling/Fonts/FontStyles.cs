using Blazor.Extensions.MergeStyles;
using Blazor.OfficeUiFabric.Styling.Fonts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public partial class FontStyles : StyleSet<FontStyles>
    {
        [JsonProperty("large", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle Large { get => this.large; set => this.SetProperty(ref this.large, value); }

        [JsonProperty("medium", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle Medium { get => this.medium; set => this.SetProperty(ref this.medium, value); }

        [JsonProperty("mediumPlus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle MediumPlus { get => this.mediumPlus; set => this.SetProperty(ref this.mediumPlus, value); }

        [JsonProperty("mega", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle Mega { get => this.mega; set => this.SetProperty(ref this.mega, value); }

        [JsonProperty("small", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle Small { get => this.small; set => this.SetProperty(ref this.small, value); }

        [JsonProperty("smallPlus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle SmallPlus { get => this.smallPlus; set => this.SetProperty(ref this.smallPlus, value); }

        [JsonProperty("superLarge", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle SuperLarge { get => this.superLarge; set => this.SetProperty(ref this.superLarge, value); }

        [JsonProperty("tiny", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle Tiny { get => this.tiny; set => this.SetProperty(ref this.tiny, value); }

        [JsonProperty("xLarge", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle XLarge { get => this.xLarge; set => this.SetProperty(ref this.xLarge, value); }

        [JsonProperty("xSmall", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle XSmall { get => this.xSmall; set => this.SetProperty(ref this.xSmall, value); }

        [JsonProperty("xxLarge", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RawStyle XxLarge { get => this.xxLarge; set => this.SetProperty(ref this.xxLarge, value); }

        public static FontStyles DefaultFontStyle => lazyDefaultFontStyle.Value;

        static Lazy<FontStyles> lazyDefaultFontStyle = new Lazy<FontStyles>(()
            => FontEngine.CreateFontStyles(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName));
        private RawStyle large;
        private RawStyle medium;
        private RawStyle mediumPlus;
        private RawStyle mega;
        private RawStyle small;
        private RawStyle smallPlus;
        private RawStyle superLarge;
        private RawStyle tiny;
        private RawStyle xLarge;
        private RawStyle xSmall;
        private RawStyle xxLarge;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, RawConverter.Settings);
        }

    }


}
