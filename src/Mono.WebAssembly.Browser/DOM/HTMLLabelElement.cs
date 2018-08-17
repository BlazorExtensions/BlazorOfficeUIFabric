using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLLabelElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLLabelElement : HTMLElement, IHTMLLabelElement
    {
        internal HTMLLabelElement(int handle) : base(handle) { }

        //public HTMLLabelElement() { }
        [Export("form")]
        public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
        [Export("htmlFor")]
        public string HtmlFor { get => GetProperty<string>("htmlFor"); set => SetProperty<string>("htmlFor", value); }
        [Export("control")]
        public HTMLInputElement Control => GetProperty<HTMLInputElement>("control");
    }

}