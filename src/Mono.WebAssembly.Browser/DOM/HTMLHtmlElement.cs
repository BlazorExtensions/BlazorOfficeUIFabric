using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLHtmlElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLHtmlElement : HTMLElement, IHTMLHtmlElement
    {
        internal HTMLHtmlElement(int handle) : base(handle) { }

        //public HTMLHtmlElement() { }
        [Export("version")]
        public string Version { get => GetProperty<string>("version"); set => SetProperty<string>("version", value); }
    }
}