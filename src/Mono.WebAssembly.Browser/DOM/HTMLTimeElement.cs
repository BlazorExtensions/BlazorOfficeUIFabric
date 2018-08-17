using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTimeElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTimeElement : HTMLElement, IHTMLTimeElement
    {
        internal HTMLTimeElement(int handle) : base(handle) { }

        //public HTMLTimeElement () { }
        [Export("dateTime")]
        public string DateTime { get => GetProperty<string>("dateTime"); set => SetProperty<string>("dateTime", value); }
    }

}