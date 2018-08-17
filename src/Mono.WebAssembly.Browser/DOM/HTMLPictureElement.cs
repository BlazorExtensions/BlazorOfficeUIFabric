using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLPictureElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLPictureElement : HTMLElement
    {
        internal HTMLPictureElement(int handle) : base(handle) { }

        //public HTMLPictureElement() { }
    }
}