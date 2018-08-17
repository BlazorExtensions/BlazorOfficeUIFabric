using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLQuoteElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLQuoteElement : HTMLElement, IHTMLQuoteElement
    {
        internal HTMLQuoteElement(int handle) : base(handle) { }

        //public HTMLQuoteElement() { }
        [Export("cite")]
        public string Cite { get => GetProperty<string>("cite"); set => SetProperty<string>("cite", value); }
    }
}