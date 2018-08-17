using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLMeterElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLMeterElement : HTMLElement, IHTMLMeterElement
    {
        internal HTMLMeterElement(int handle) : base(handle) { }

        //public HTMLMeterElement() { }
        [Export("high")]
        public double High { get => GetProperty<double>("high"); set => SetProperty<double>("high", value); }
        [Export("low")]
        public double Low { get => GetProperty<double>("low"); set => SetProperty<double>("low", value); }
        [Export("max")]
        public double Max { get => GetProperty<double>("max"); set => SetProperty<double>("max", value); }
        [Export("min")]
        public double Min { get => GetProperty<double>("min"); set => SetProperty<double>("min", value); }
        [Export("optimum")]
        public double Optimum { get => GetProperty<double>("optimum"); set => SetProperty<double>("optimum", value); }
        [Export("value")]
        public double Value { get => GetProperty<double>("value"); set => SetProperty<double>("value", value); }
    }

}