using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLLIElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLLIElement : HTMLElement, IHTMLLIElement
    {
        internal HTMLLIElement(int handle) : base(handle) { }

        //public HTMLLIElement () { }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("value")]
        public double Value { get => GetProperty<double>("value"); set => SetProperty<double>("value", value); }
    }
}