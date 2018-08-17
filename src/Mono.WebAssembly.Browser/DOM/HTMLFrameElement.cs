using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("HTMLFrameElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLFrameElement : HTMLElement, IHTMLFrameElement
    {
        internal HTMLFrameElement(int handle) : base(handle) { }

        //public HTMLFrameElement() { }
        [Export("border")]
        public string Border { get => GetProperty<string>("border"); set => SetProperty<string>("border", value); }
        [Export("borderColor")]
        public Object BorderColor { get => GetProperty<Object>("borderColor"); set => SetProperty<Object>("borderColor", value); }
        [Export("contentDocument")]
        public Document ContentDocument => GetProperty<Document>("contentDocument");
        [Export("contentWindow")]
        public Window ContentWindow => GetProperty<Window>("contentWindow");
        [Export("frameBorder")]
        public string FrameBorder { get => GetProperty<string>("frameBorder"); set => SetProperty<string>("frameBorder", value); }
        [Export("frameSpacing")]
        public Object FrameSpacing { get => GetProperty<Object>("frameSpacing"); set => SetProperty<Object>("frameSpacing", value); }
        [Export("height")]
        public string Height { get => GetProperty<string>("height"); set => SetProperty<string>("height", value); }
        [Export("longDesc")]
        public string LongDesc { get => GetProperty<string>("longDesc"); set => SetProperty<string>("longDesc", value); }
        [Export("marginHeight")]
        public string MarginHeight { get => GetProperty<string>("marginHeight"); set => SetProperty<string>("marginHeight", value); }
        [Export("marginWidth")]
        public string MarginWidth { get => GetProperty<string>("marginWidth"); set => SetProperty<string>("marginWidth", value); }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("noResize")]
        public bool NoResize { get => GetProperty<bool>("noResize"); set => SetProperty<bool>("noResize", value); }
        [Export("scrolling")]
        public string Scrolling { get => GetProperty<string>("scrolling"); set => SetProperty<string>("scrolling", value); }
        [Export("src")]
        public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
        [Export("width")]
        public string Width { get => GetProperty<string>("width"); set => SetProperty<string>("width", value); }
        [Export("getSVGDocument")]
        public Document GetSvgDocument()
        {
            return InvokeMethod<Document>("getSVGDocument");
        }
    }
}