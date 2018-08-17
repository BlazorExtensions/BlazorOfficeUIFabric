using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLDataListElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLDataListElement : HTMLElement, IHTMLDataListElement
    {
        internal HTMLDataListElement(int handle) : base(handle) { }

        //public HTMLDataListElement () { }
        [Export("options")]
        public HTMLCollectionOf<HTMLOptionElement> Options { get => GetProperty<HTMLCollectionOf<HTMLOptionElement>>("options"); set => SetProperty<HTMLCollectionOf<HTMLOptionElement>>("options", value); }
    }

}