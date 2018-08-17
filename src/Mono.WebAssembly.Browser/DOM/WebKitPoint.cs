using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("WebKitPoint", typeof(Mono.WebAssembly.JSObject))]
    public sealed class WebKitPoint : JSObject
    {
        public WebKitPoint(int handle) : base(handle) { }

        public WebKitPoint(double x, double y) { }
        [Export("x")]
        public double X { get => GetProperty<double>("x"); set => SetProperty<double>("x", value); }
        [Export("y")]
        public double Y { get => GetProperty<double>("y"); set => SetProperty<double>("y", value); }
    }
}