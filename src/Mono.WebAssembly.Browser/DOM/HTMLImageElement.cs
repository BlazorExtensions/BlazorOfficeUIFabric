using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLImageElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLImageElement : HTMLElement, IHTMLImageElement
    {
        internal HTMLImageElement(int handle) : base(handle) { }

        //public HTMLImageElement () { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("alt")]
        public string Alt { get => GetProperty<string>("alt"); set => SetProperty<string>("alt", value); }
        [Export("border")]
        public string Border { get => GetProperty<string>("border"); set => SetProperty<string>("border", value); }
        [Export("complete")]
        public bool Complete => GetProperty<bool>("complete");
        [Export("crossOrigin")]
        public string CrossOrigin { get => GetProperty<string>("crossOrigin"); set => SetProperty<string>("crossOrigin", value); }
        [Export("currentSrc")]
        public string CurrentSrc => GetProperty<string>("currentSrc");
        [Export("height")]
        public double Height { get => GetProperty<double>("height"); set => SetProperty<double>("height", value); }
        [Export("hspace")]
        public double Hspace { get => GetProperty<double>("hspace"); set => SetProperty<double>("hspace", value); }
        [Export("isMap")]
        public bool IsMap { get => GetProperty<bool>("isMap"); set => SetProperty<bool>("isMap", value); }
        [Export("longDesc")]
        public string LongDesc { get => GetProperty<string>("longDesc"); set => SetProperty<string>("longDesc", value); }
        [Export("lowsrc")]
        public string Lowsrc { get => GetProperty<string>("lowsrc"); set => SetProperty<string>("lowsrc", value); }
        [Export("msPlayToDisabled")]
        public bool MsPlayToDisabled { get => GetProperty<bool>("msPlayToDisabled"); set => SetProperty<bool>("msPlayToDisabled", value); }
        [Export("msPlayToPreferredSourceUri")]
        public string MsPlayToPreferredSourceUri { get => GetProperty<string>("msPlayToPreferredSourceUri"); set => SetProperty<string>("msPlayToPreferredSourceUri", value); }
        [Export("msPlayToPrimary")]
        public bool MsPlayToPrimary { get => GetProperty<bool>("msPlayToPrimary"); set => SetProperty<bool>("msPlayToPrimary", value); }
        [Export("msPlayToSource")]
        public Object MsPlayToSource => GetProperty<Object>("msPlayToSource");
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("naturalHeight")]
        public double NaturalHeight => GetProperty<double>("naturalHeight");
        [Export("naturalWidth")]
        public double NaturalWidth => GetProperty<double>("naturalWidth");
        [Export("sizes")]
        public string Sizes { get => GetProperty<string>("sizes"); set => SetProperty<string>("sizes", value); }
        [Export("src")]
        public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
        [Export("srcset")]
        public string Srcset { get => GetProperty<string>("srcset"); set => SetProperty<string>("srcset", value); }
        [Export("useMap")]
        public string UseMap { get => GetProperty<string>("useMap"); set => SetProperty<string>("useMap", value); }
        [Export("vspace")]
        public double Vspace { get => GetProperty<double>("vspace"); set => SetProperty<double>("vspace", value); }
        [Export("width")]
        public double Width { get => GetProperty<double>("width"); set => SetProperty<double>("width", value); }
        [Export("x")]
        public double X => GetProperty<double>("x");
        [Export("y")]
        public double Y => GetProperty<double>("y");
        [Export("msGetAsCastingSource")]
        public Object MsGetAsCastingSource()
        {
            return InvokeMethod<Object>("msGetAsCastingSource");
        }
    }

}