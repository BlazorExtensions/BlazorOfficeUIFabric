using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("PerformanceTiming", typeof(Mono.WebAssembly.JSObject))]
    public sealed class PerformanceTiming : JSObject
    {
        internal PerformanceTiming(int handle) : base(handle) { }

        //public PerformanceTiming() { }
        [Export("connectEnd")]
        public double ConnectEnd => GetProperty<double>("connectEnd");
        [Export("connectStart")]
        public double ConnectStart => GetProperty<double>("connectStart");
        [Export("domainLookupEnd")]
        public double DomainLookupEnd => GetProperty<double>("domainLookupEnd");
        [Export("domainLookupStart")]
        public double DomainLookupStart => GetProperty<double>("domainLookupStart");
        [Export("domComplete")]
        public double DomComplete => GetProperty<double>("domComplete");
        [Export("domContentLoadedEventEnd")]
        public double DomContentLoadedEventEnd => GetProperty<double>("domContentLoadedEventEnd");
        [Export("domContentLoadedEventStart")]
        public double DomContentLoadedEventStart => GetProperty<double>("domContentLoadedEventStart");
        [Export("domInteractive")]
        public double DomInteractive => GetProperty<double>("domInteractive");
        [Export("domLoading")]
        public double DomLoading => GetProperty<double>("domLoading");
        [Export("fetchStart")]
        public double FetchStart => GetProperty<double>("fetchStart");
        [Export("loadEventEnd")]
        public double LoadEventEnd => GetProperty<double>("loadEventEnd");
        [Export("loadEventStart")]
        public double LoadEventStart => GetProperty<double>("loadEventStart");
        [Export("msFirstPaint")]
        public double MsFirstPaint => GetProperty<double>("msFirstPaint");
        [Export("navigationStart")]
        public double NavigationStart => GetProperty<double>("navigationStart");
        [Export("redirectEnd")]
        public double RedirectEnd => GetProperty<double>("redirectEnd");
        [Export("redirectStart")]
        public double RedirectStart => GetProperty<double>("redirectStart");
        [Export("requestStart")]
        public double RequestStart => GetProperty<double>("requestStart");
        [Export("responseEnd")]
        public double ResponseEnd => GetProperty<double>("responseEnd");
        [Export("responseStart")]
        public double ResponseStart => GetProperty<double>("responseStart");
        [Export("unloadEventEnd")]
        public double UnloadEventEnd => GetProperty<double>("unloadEventEnd");
        [Export("unloadEventStart")]
        public double UnloadEventStart => GetProperty<double>("unloadEventStart");
        [Export("secureConnectionStart")]
        public double SecureConnectionStart => GetProperty<double>("secureConnectionStart");
        [Export("toJSON")]
        public string ToJson()
        {
            return InvokeMethod<string>("toJSON");
        }
    }

}