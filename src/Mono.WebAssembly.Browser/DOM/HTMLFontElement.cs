using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLFontElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLFontElement : HTMLElement
    {
        internal HTMLFontElement(int handle) : base(handle) { }

        //public HTMLFontElement() { }
        [Export("face")]
        public string Face { get => GetProperty<string>("face"); set => SetProperty<string>("face", value); }
        [Export("color")]
        public string Color { get => GetProperty<string>("color"); set => SetProperty<string>("color", value); }
        [Export("size")]
        public double Size { get => GetProperty<double>("size"); set => SetProperty<double>("size", value); }
    }

}