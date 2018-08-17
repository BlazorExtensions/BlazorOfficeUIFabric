using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLTableElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTableElement : HTMLElement, IHTMLTableElement {
    internal HTMLTableElement  (int handle) : base (handle) {}

    //public HTMLTableElement () { }
    [Export("align")]
    public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
    [Export("bgColor")]
    public Object BgColor { get => GetProperty<Object>("bgColor"); set => SetProperty<Object>("bgColor", value); }
    [Export("border")]
    public string Border { get => GetProperty<string>("border"); set => SetProperty<string>("border", value); }
    [Export("borderColor")]
    public Object BorderColor { get => GetProperty<Object>("borderColor"); set => SetProperty<Object>("borderColor", value); }
    [Export("caption")]
    public HTMLTableCaptionElement Caption { get => GetProperty<HTMLTableCaptionElement>("caption"); set => SetProperty<HTMLTableCaptionElement>("caption", value); }
    [Export("cellPadding")]
    public string CellPadding { get => GetProperty<string>("cellPadding"); set => SetProperty<string>("cellPadding", value); }
    [Export("cellSpacing")]
    public string CellSpacing { get => GetProperty<string>("cellSpacing"); set => SetProperty<string>("cellSpacing", value); }
    [Export("cols")]
    public double Cols { get => GetProperty<double>("cols"); set => SetProperty<double>("cols", value); }
    [Export("frame")]
    public string Frame { get => GetProperty<string>("frame"); set => SetProperty<string>("frame", value); }
    [Export("height")]
    public Object Height { get => GetProperty<Object>("height"); set => SetProperty<Object>("height", value); }
    [Export("rows")]
    public HTMLCollectionOf<HTMLTableRowElement> Rows { get => GetProperty<HTMLCollectionOf<HTMLTableRowElement>>("rows"); set => SetProperty<HTMLCollectionOf<HTMLTableRowElement>>("rows", value); }
    [Export("rules")]
    public string Rules { get => GetProperty<string>("rules"); set => SetProperty<string>("rules", value); }
    [Export("summary")]
    public string Summary { get => GetProperty<string>("summary"); set => SetProperty<string>("summary", value); }
    [Export("tBodies")]
    public HTMLCollectionOf<HTMLTableSectionElement> TBodies { get => GetProperty<HTMLCollectionOf<HTMLTableSectionElement>>("tBodies"); set => SetProperty<HTMLCollectionOf<HTMLTableSectionElement>>("tBodies", value); }
    [Export("tFoot")]
    public HTMLTableSectionElement TFoot { get => GetProperty<HTMLTableSectionElement>("tFoot"); set => SetProperty<HTMLTableSectionElement>("tFoot", value); }
    [Export("tHead")]
    public HTMLTableSectionElement THead { get => GetProperty<HTMLTableSectionElement>("tHead"); set => SetProperty<HTMLTableSectionElement>("tHead", value); }
    [Export("width")]
    public string Width { get => GetProperty<string>("width"); set => SetProperty<string>("width", value); }
    [Export("createCaption")]
    public HTMLTableCaptionElement CreateCaption()
    {
    	return InvokeMethod<HTMLTableCaptionElement>("createCaption");
    }
    [Export("createTBody")]
    public HTMLTableSectionElement CreateTBody()
    {
    	return InvokeMethod<HTMLTableSectionElement>("createTBody");
    }
    [Export("createTFoot")]
    public HTMLTableSectionElement CreateTFoot()
    {
    	return InvokeMethod<HTMLTableSectionElement>("createTFoot");
    }
    [Export("createTHead")]
    public HTMLTableSectionElement CreateTHead()
    {
    	return InvokeMethod<HTMLTableSectionElement>("createTHead");
    }
    [Export("deleteCaption")]
    public void DeleteCaption()
    {
    	InvokeMethod<object>("deleteCaption");
    }
    [Export("deleteRow")]
    public void DeleteRow(double index)
    {
    	InvokeMethod<object>("deleteRow", index);
    }
    [Export("deleteTFoot")]
    public void DeleteTFoot()
    {
    	InvokeMethod<object>("deleteTFoot");
    }
    [Export("deleteTHead")]
    public void DeleteTHead()
    {
    	InvokeMethod<object>("deleteTHead");
    }
    [Export("insertRow")]
    public HTMLTableRowElement InsertRow(double index)
    {
    	return InvokeMethod<HTMLTableRowElement>("insertRow", index);
    }
}
}