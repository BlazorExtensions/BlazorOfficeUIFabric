using System;
using System.Collections.Generic;

namespace Mono.WebAssembly.Browser.DOM.Events
{

    [Export("WheelEvent", typeof(Mono.WebAssembly.JSObject))]
    public sealed class WheelEvent : MouseEvent
    {
        internal WheelEvent(int handle) : base(handle) { }

        //public WheelEvent(string typeArg, IWheelEventInit eventInitDict) { }
        [Export("DOM_DELTA_LINE")]
        public double DomDeltaLine { get; internal set; }
        [Export("DOM_DELTA_PAGE")]
        public double DomDeltaPage { get; internal set; }
        [Export("DOM_DELTA_PIXEL")]
        public double DomDeltaPixel { get; internal set; }
        [Export("deltaMode")]
        public double DeltaMode { get; internal set; }
        [Export("deltaX")]
        public double DeltaX { get; internal set; }
        [Export("deltaY")]
        public double DeltaY { get; internal set; }
        [Export("deltaZ")]
        public double DeltaZ { get; internal set; }
        [Export("wheelDelta")]
        public double WheelDelta { get; internal set; }
        [Export("wheelDeltaX")]
        public double WheelDeltaX { get; internal set; }
        [Export("wheelDeltaY")]
        public double WheelDeltaY { get; internal set; }
        [Export("getCurrentPoint")]
        public void GetCurrentPoint(Element element)
        {
            InvokeMethod<object>("getCurrentPoint", element);
        }
        //[Export("initWheelEvent")]
        //public void InitWheelEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Window viewArg, double detailArg, double screenXArg, double screenYArg, double clientXArg, double clientYArg, double buttonArg, EventTarget relatedTargetArg, string modifiersListArg, double deltaXArg, double deltaYArg, double deltaZArg, double deltaMode)
        //{
        //    InvokeMethod<object>("initWheelEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, buttonArg, relatedTargetArg, modifiersListArg, deltaXArg, deltaYArg, deltaZArg, deltaMode);
        //}
        internal override void InitEvent(Dictionary<string, string> eventInfoDic)
        {
            base.InitEvent(eventInfoDic);
            string value = null;


            if (eventInfoDic.TryGetValue("DOM_DELTA_LINE", out value))
            {
                this.DomDeltaLine = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("DOM_DELTA_PAGE", out value))
            {
                this.DomDeltaPage = Convert.ToInt32(value);
            }


            if (eventInfoDic.TryGetValue("DOM_DELTA_PIXEL", out value))
            {
                this.DomDeltaPixel = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("deltaMode", out value))
            {
                this.DeltaMode = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("deltaX", out value))
            {
                this.DeltaX = Convert.ToDouble(value);
            }

            if (eventInfoDic.TryGetValue("deltaY", out value))
            {
                this.DeltaY = Convert.ToDouble(value);
            }


            if (eventInfoDic.TryGetValue("deltaZ", out value))
            {
                this.DeltaZ = Convert.ToDouble(value);
            }


            if (eventInfoDic.TryGetValue("wheelDelta", out value))
            {
                this.WheelDelta = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("wheelDeltaX", out value))
            {
                this.WheelDeltaX = Convert.ToDouble(value);
            }

            if (eventInfoDic.TryGetValue("wheelDeltaY", out value))
            {
                this.WheelDeltaY = Convert.ToDouble(value);
            }
        }
    }

}
