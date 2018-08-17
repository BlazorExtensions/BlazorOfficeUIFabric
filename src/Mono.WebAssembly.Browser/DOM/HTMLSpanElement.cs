using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLSpanElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLSpanElement : HTMLElement, IHTMLSpanElement
    {
        internal HTMLSpanElement(int handle) : base(handle) { }

        //public HTMLSpanElement () { }
    }
}