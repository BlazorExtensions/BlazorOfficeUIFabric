using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{
    [Export("HTMLMarqueeElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLMarqueeElement : HTMLElement, IHTMLMarqueeElement
    {
        internal HTMLMarqueeElement(int handle) : base(handle) { }

        //public HTMLMarqueeElement () { }
        [Export("behavior")]
        public string Behavior { get => GetProperty<string>("behavior"); set => SetProperty<string>("behavior", value); }
        [Export("bgColor")]
        public Object BgColor { get => GetProperty<Object>("bgColor"); set => SetProperty<Object>("bgColor", value); }
        [Export("direction")]
        public string Direction { get => GetProperty<string>("direction"); set => SetProperty<string>("direction", value); }
        [Export("height")]
        public string Height { get => GetProperty<string>("height"); set => SetProperty<string>("height", value); }
        [Export("hspace")]
        public double Hspace { get => GetProperty<double>("hspace"); set => SetProperty<double>("hspace", value); }
        [Export("loop")]
        public double Loop { get => GetProperty<double>("loop"); set => SetProperty<double>("loop", value); }
        public event DOMEventHandler OnBounce
        {
            add => AddEventListener("bounce", value, false);
            remove => RemoveEventListener("bounce", value, false);
        }
        public event DOMEventHandler OnFinish
        {
            add => AddEventListener("finish", value, false);
            remove => RemoveEventListener("finish", value, false);
        }
        public event DOMEventHandler OnStart
        {
            add => AddEventListener("start", value, false);
            remove => RemoveEventListener("start", value, false);
        }
        [Export("scrollAmount")]
        public double ScrollAmount { get => GetProperty<double>("scrollAmount"); set => SetProperty<double>("scrollAmount", value); }
        [Export("scrollDelay")]
        public double ScrollDelay { get => GetProperty<double>("scrollDelay"); set => SetProperty<double>("scrollDelay", value); }
        [Export("trueSpeed")]
        public bool TrueSpeed { get => GetProperty<bool>("trueSpeed"); set => SetProperty<bool>("trueSpeed", value); }
        [Export("vspace")]
        public double Vspace { get => GetProperty<double>("vspace"); set => SetProperty<double>("vspace", value); }
        [Export("width")]
        public string Width { get => GetProperty<string>("width"); set => SetProperty<string>("width", value); }
        [Export("start")]
        public void Start()
        {
            InvokeMethod<object>("start");
        }
        [Export("stop")]
        public void Stop()
        {
            InvokeMethod<object>("stop");
        }
    }

}