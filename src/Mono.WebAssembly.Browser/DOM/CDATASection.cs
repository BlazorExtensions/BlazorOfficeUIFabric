using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("CDATASection", typeof(Mono.WebAssembly.JSObject))]
    public sealed class CDATASection : Text
    {
        internal CDATASection(int handle) : base(handle) { }

        //public CDATASection() { }
    }
}