using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLLegendElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLLegendElement : HTMLElement, IHTMLLegendElement
    {
        internal HTMLLegendElement(int handle) : base(handle) { }

        //public HTMLLegendElement () { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("form")]
        public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
    }
}