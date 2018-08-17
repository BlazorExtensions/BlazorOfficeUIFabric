using Blazor.Extensions.MergeStyles;
using Blazor.OfficeUiFabric.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public partial class FontSizes : ExpandableObject<string>
    {
        [JsonProperty("large", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Large { get => this.large; set => SetProperty(ref this.large, value); }

        [JsonProperty("medium", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Medium { get => this.medium; set => SetProperty(ref this.medium, value); }

        [JsonProperty("mega", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Mega { get => this.mega; set => SetProperty(ref this.mega, value); }

        [JsonProperty("small", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Small { get => this.small; set => SetProperty(ref this.small, value); }

        [JsonProperty("tiny", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Tiny { get => this.tiny; set => SetProperty(ref this.tiny, value); }

        [JsonProperty("xLarge", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string XLarge { get => this.xLarge; set => SetProperty(ref this.xLarge, value); }

        [JsonProperty("xSmall", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string XSmall { get => this.xSmall; set => SetProperty(ref this.xSmall, value); }

        [JsonProperty("xxLarge", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string XxLarge { get => this.xxLarge; set => SetProperty(ref this.xxLarge, value); }

        [JsonProperty("xxxLarge", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string XxxLarge { get => this.xxxLarge; set => SetProperty(ref this.xxxLarge, value); }

        public static FontSizes DefaultFontSizes => lazyDefaultFontSizes.Value;

        public string SmallPlus { get; internal set; }
        public string MediumPlus { get; internal set; }
        public string Icon { get; internal set; }
        public string SuperLarge { get; internal set; }
        public string Mini { get; internal set; }

        static Lazy<FontSizes> lazyDefaultFontSizes = new Lazy<FontSizes>(() => new FontSizes()
        {
            Tiny = "1rem",
            XSmall = "1.2rem",
            Small = "1.3rem",
            Medium = "1.4rem",
            Large = "1.6rem",
            XLarge = "1.8rem",
            XxLarge = "2rem",
            XxxLarge = "3rem",
            Mega = "4rem"
        });
        private string large;
        private string medium;
        private string mega;
        private string small;
        private string tiny;
        private string xLarge;
        private string xSmall;
        private string xxLarge;
        private string xxxLarge;
    }


}
