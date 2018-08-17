using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLTableSectionElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLTableSectionElement : HTMLElement, IHTMLTableSectionElement {
    internal HTMLTableSectionElement  (int handle) : base (handle) {}

    //public HTMLTableSectionElement () { }
    [Export("align")]
    public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
    [Export("rows")]
    public HTMLCollectionOf<HTMLTableRowElement> Rows { get => GetProperty<HTMLCollectionOf<HTMLTableRowElement>>("rows"); set => SetProperty<HTMLCollectionOf<HTMLTableRowElement>>("rows", value); }
    [Export("ch")]
    public string Ch { get => GetProperty<string>("ch"); set => SetProperty<string>("ch", value); }
    [Export("chOff")]
    public string ChOff { get => GetProperty<string>("chOff"); set => SetProperty<string>("chOff", value); }
    [Export("vAlign")]
    public string VAlign { get => GetProperty<string>("vAlign"); set => SetProperty<string>("vAlign", value); }
    [Export("deleteRow")]
    public void DeleteRow(double index)
    {
    	InvokeMethod<object>("deleteRow", index);
    }
    [Export("insertRow")]
    public HTMLTableRowElement InsertRow(double index)
    {
    	return InvokeMethod<HTMLTableRowElement>("insertRow", index);
    }
}
}