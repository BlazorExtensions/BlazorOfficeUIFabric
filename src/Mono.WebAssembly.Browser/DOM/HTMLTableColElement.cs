using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTableColElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTableColElement : HTMLElement, IHTMLTableColElement
    {
        internal HTMLTableColElement(int handle) : base(handle) { }

        //public HTMLTableColElement() { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("span")]
        public double Span { get => GetProperty<double>("span"); set => SetProperty<double>("span", value); }
        [Export("width")]
        public Object Width { get => GetProperty<Object>("width"); set => SetProperty<Object>("width", value); }
        [Export("ch")]
        public string Ch { get => GetProperty<string>("ch"); set => SetProperty<string>("ch", value); }
        [Export("chOff")]
        public string ChOff { get => GetProperty<string>("chOff"); set => SetProperty<string>("chOff", value); }
        [Export("vAlign")]
        public string VAlign { get => GetProperty<string>("vAlign"); set => SetProperty<string>("vAlign", value); }
    }
}