using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTableHeaderCellElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTableHeaderCellElement : HTMLTableCellElement
    {
        internal HTMLTableHeaderCellElement(int handle) : base(handle) { }

        //public HTMLTableHeaderCellElement () { }
        //[Export("scope")]
        //public string Scope { get => GetProperty<string>("scope"); set => SetProperty<string>("scope", value); }
    }
}