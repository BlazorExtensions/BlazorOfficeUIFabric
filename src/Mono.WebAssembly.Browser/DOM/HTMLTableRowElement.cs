using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTableRowElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTableRowElement : HTMLElement, IHTMLTableRowElement
    {
        internal HTMLTableRowElement(int handle) : base(handle) { }

        //public HTMLTableRowElement() { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("bgColor")]
        public Object BgColor { get => GetProperty<Object>("bgColor"); set => SetProperty<Object>("bgColor", value); }
        [Export("cells")]
        public HTMLCollectionOf<HTMLTableCellElement> Cells { get => GetProperty <HTMLCollectionOf<HTMLTableCellElement>> ("cells"); set => SetProperty <HTMLCollectionOf<HTMLTableCellElement>> ("cells", value); }
        [Export("height")]
        public Object Height { get => GetProperty<Object>("height"); set => SetProperty<Object>("height", value); }
        [Export("rowIndex")]
        public double RowIndex => GetProperty<double>("rowIndex");
        [Export("sectionRowIndex")]
        public double SectionRowIndex => GetProperty<double>("sectionRowIndex");
        [Export("ch")]
        public string Ch { get => GetProperty<string>("ch"); set => SetProperty<string>("ch", value); }
        [Export("chOff")]
        public string ChOff { get => GetProperty<string>("chOff"); set => SetProperty<string>("chOff", value); }
        [Export("vAlign")]
        public string VAlign { get => GetProperty<string>("vAlign"); set => SetProperty<string>("vAlign", value); }
        [Export("deleteCell")]
        public void DeleteCell(double index)
        {
            InvokeMethod<object>("deleteCell", index);
        }
        [Export("insertCell")]
        public HTMLTableDataCellElement InsertCell(double index)
        {
            return InvokeMethod<HTMLTableDataCellElement>("insertCell", index);
        }
    }
}