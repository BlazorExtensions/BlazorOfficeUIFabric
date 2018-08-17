using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLUnknownElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLUnknownElement : HTMLElement
    {
        internal HTMLUnknownElement(int handle) : base(handle) { }

        //public HTMLUnknownElement () { }
    }
}