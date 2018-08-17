using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLDivElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLDivElement : HTMLElement, IHTMLDivElement
    {
        internal HTMLDivElement(int handle) : base(handle) { }

        //public HTMLDivElement() { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("noWrap")]
        public bool NoWrap { get => GetProperty<bool>("noWrap"); set => SetProperty<bool>("noWrap", value); }
    }
}