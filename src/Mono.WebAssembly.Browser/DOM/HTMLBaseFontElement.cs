using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLBaseFontElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLBaseFontElement : HTMLElement, IHTMLFontElement
    {
        internal HTMLBaseFontElement(int handle) : base(handle) { }

        //public HTMLBaseFontElement() { }
        [Export("face")]
        public string Face { get => GetProperty<string>("face"); set => SetProperty<string>("face", value); }
        [Export("size")]
        public double Size { get => GetProperty<double>("size"); set => SetProperty<double>("size", value); }
        [Export("color")]
        public string Color { get => GetProperty<string>("color"); set => SetProperty<string>("color", value); }
    }
}