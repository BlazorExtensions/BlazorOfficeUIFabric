using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("HTMLTableCellElement", typeof(Mono.WebAssembly.JSObject))]
    public class HTMLTableCellElement : HTMLElement
    {
        internal HTMLTableCellElement(int handle) : base(handle) { }

        //public HTMLTableCellElement() { }
        [Export("abbr")]
        public string Abbr { get => GetProperty<string>("abbr"); set => SetProperty<string>("abbr", value); }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("axis")]
        public string Axis { get => GetProperty<string>("axis"); set => SetProperty<string>("axis", value); }
        [Export("bgColor")]
        public Object BgColor { get => GetProperty<Object>("bgColor"); set => SetProperty<Object>("bgColor", value); }
        [Export("cellIndex")]
        public double CellIndex => GetProperty<double>("cellIndex");
        [Export("colSpan")]
        public double ColSpan { get => GetProperty<double>("colSpan"); set => SetProperty<double>("colSpan", value); }
        [Export("headers")]
        public string Headers { get => GetProperty<string>("headers"); set => SetProperty<string>("headers", value); }
        [Export("height")]
        public Object Height { get => GetProperty<Object>("height"); set => SetProperty<Object>("height", value); }
        [Export("noWrap")]
        public bool NoWrap { get => GetProperty<bool>("noWrap"); set => SetProperty<bool>("noWrap", value); }
        [Export("rowSpan")]
        public double RowSpan { get => GetProperty<double>("rowSpan"); set => SetProperty<double>("rowSpan", value); }
        [Export("scope")]
        public string Scope { get => GetProperty<string>("scope"); set => SetProperty<string>("scope", value); }
        [Export("width")]
        public string Width { get => GetProperty<string>("width"); set => SetProperty<string>("width", value); }
        [Export("ch")]
        public string Ch { get => GetProperty<string>("ch"); set => SetProperty<string>("ch", value); }
        [Export("chOff")]
        public string ChOff { get => GetProperty<string>("chOff"); set => SetProperty<string>("chOff", value); }
        [Export("vAlign")]
        public string VAlign { get => GetProperty<string>("vAlign"); set => SetProperty<string>("vAlign", value); }
    }
}