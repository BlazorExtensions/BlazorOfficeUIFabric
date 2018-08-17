using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTitleElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTitleElement : HTMLElement, IHTMLSpanElement
    {
        internal HTMLTitleElement(int handle) : base(handle) { }

        //public HTMLTitleElement() { }
        [Export("text")]
        public string Text { get => GetProperty<string>("text"); set => SetProperty<string>("text", value); }
    }
}