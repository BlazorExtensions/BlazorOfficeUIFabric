using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLBRElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLBRElement : HTMLElement, IHTMLBRElement
    {
        internal HTMLBRElement(int handle) : base(handle) { }

        //public HTMLBRElement() { }
        [Export("clear")]
        public string Clear { get => GetProperty<string>("clear"); set => SetProperty<string>("clear", value); }
    }
}