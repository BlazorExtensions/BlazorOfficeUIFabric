using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLParagraphElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLParagraphElement : HTMLElement, IHTMLParagraphElement
    {
        public HTMLParagraphElement(int handle) : base(handle) { }

        //public HTMLParagraphElement() { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("clear")]
        public string Clear { get => GetProperty<string>("clear"); set => SetProperty<string>("clear", value); }
    }

}