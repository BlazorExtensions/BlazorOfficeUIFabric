using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTableDataCellElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTableDataCellElement : HTMLTableCellElement, IHTMLTableDataCellElement
    {
        internal HTMLTableDataCellElement(int handle) : base(handle) { }

        //public HTMLTableDataCellElement () { }
    }
}