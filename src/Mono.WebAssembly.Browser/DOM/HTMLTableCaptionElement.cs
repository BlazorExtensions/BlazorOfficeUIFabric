using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTableCaptionElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTableCaptionElement : HTMLElement, IHTMLTableCaptionElement
    {
        internal HTMLTableCaptionElement(int handle) : base(handle) { }

        //public HTMLTableCaptionElement () { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("vAlign")]
        public string VAlign { get => GetProperty<string>("vAlign"); set => SetProperty<string>("vAlign", value); }
    }
}