using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLPreElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLPreElement : HTMLElement, IHTMLPreElement
    {
        internal HTMLPreElement(int handle) : base(handle) { }

        //public HTMLPreElement () { }
        [Export("width")]
        public double Width { get => GetProperty<double>("width"); set => SetProperty<double>("width", value); }
    }
}