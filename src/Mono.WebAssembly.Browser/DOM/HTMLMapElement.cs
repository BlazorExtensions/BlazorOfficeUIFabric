using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLMapElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLMapElement : HTMLElement, IHTMLMapElement
    {
        internal HTMLMapElement(int handle) : base(handle) { }

        //public HTMLMapElement () { }
        [Export("areas")]
        public HTMLAreasCollection Areas => GetProperty<HTMLAreasCollection>("areas");
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
    }
}