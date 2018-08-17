using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLHeadingElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLHeadingElement : HTMLElement, IHTMLHeadingElement
    {
        internal HTMLHeadingElement(int handle) : base(handle) { }

        //public HTMLHeadingElement() { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
    }

}