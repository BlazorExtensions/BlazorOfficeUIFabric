using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLDataElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLDataElement : HTMLElement, IHTMLDataElement
    {
        internal HTMLDataElement(int handle) : base(handle) { }

        //public HTMLDataElement() { }
        [Export("value")]
        public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
    }

}