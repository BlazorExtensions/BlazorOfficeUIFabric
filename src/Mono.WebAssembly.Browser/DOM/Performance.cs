using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("Performance", typeof(Mono.WebAssembly.JSObject))]
    public sealed class Performance : JSObject
    {
        internal Performance(int handle) : base(handle) { }

        //public Performance() { }
        [Export("navigation")]
        public PerformanceNavigation Navigation => GetProperty<PerformanceNavigation>("navigation");
        [Export("timing")]
        public PerformanceTiming Timing => GetProperty<PerformanceTiming>("timing");
        [Export("clearMarks")]
        public void ClearMarks(string markName)
        {
            InvokeMethod<object>("clearMarks", markName);
        }
        [Export("clearMeasures")]
        public void ClearMeasures(string measureName)
        {
            InvokeMethod<object>("clearMeasures", measureName);
        }
        [Export("clearResourceTimings")]
        public void ClearResourceTimings()
        {
            InvokeMethod<object>("clearResourceTimings");
        }
        [Export("getEntries")]
        public Object GetEntries()
        {
            return InvokeMethod<Object>("getEntries");
        }
        [Export("getEntriesByName")]
        public Object GetEntriesByName(string name, string entryType)
        {
            return InvokeMethod<Object>("getEntriesByName", name, entryType);
        }
        [Export("getEntriesByType")]
        public Object GetEntriesByType(string entryType)
        {
            return InvokeMethod<Object>("getEntriesByType", entryType);
        }
        [Export("getMarks")]
        public Object GetMarks(string markName)
        {
            return InvokeMethod<Object>("getMarks", markName);
        }
        [Export("getMeasures")]
        public Object GetMeasures(string measureName)
        {
            return InvokeMethod<Object>("getMeasures", measureName);
        }
        [Export("mark")]
        public void Mark(string markName)
        {
            InvokeMethod<object>("mark", markName);
        }
        [Export("measure")]
        public void Measure(string measureName, string startMarkName, string endMarkName)
        {
            InvokeMethod<object>("measure", measureName, startMarkName, endMarkName);
        }
        [Export("now")]
        public double Now()
        {
            return InvokeMethod<double>("now");
        }
        [Export("setResourceTimingBufferSize")]
        public void SetResourceTimingBufferSize(double maxSize)
        {
            InvokeMethod<object>("setResourceTimingBufferSize", maxSize);
        }
        [Export("toJSON")]
        public string ToJson()
        {
            return InvokeMethod<string>("toJSON");
        }
    }

}