using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLBaseElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLBaseElement : HTMLElement, IHTMLBaseElement
    {
        internal HTMLBaseElement(int handle) : base(handle) { }

        //public HTMLBaseElement() { }
        [Export("href")]
        public string Href { get => GetProperty<string>("href"); set => SetProperty<string>("href", value); }
        [Export("target")]
        public string Target { get => GetProperty<string>("target"); set => SetProperty<string>("target", value); }
    }
}