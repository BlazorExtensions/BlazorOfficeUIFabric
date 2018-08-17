using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLStyleElement", typeof(Mono.WebAssembly.JSObject))]
    public class HTMLStyleElement : HTMLElement, IHTMLStyleElement
    {
        public HTMLStyleElement(int handle) : base(handle) { }

        //public HTMLStyleElement() { }
        [Export("disabled")]
        public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
        [Export("media")]
        public string Media { get => GetProperty<string>("media"); set => SetProperty<string>("media", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("sheet")]
        public StyleSheet Sheet => GetProperty<StyleSheet>("sheet");
    }
}