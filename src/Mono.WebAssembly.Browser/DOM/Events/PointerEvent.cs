using System;
namespace Mono.WebAssembly.Browser.DOM.Events
{

    [Export("PointerEvent", typeof(Mono.WebAssembly.JSObject))]
    public sealed class PointerEvent : MouseEvent
    {
        internal PointerEvent(int handle) : base(handle) { }

        //public PointerEvent(string typeArg, IPointerEventInit eventInitDict) { }
        [Export("currentPoint")]
        public Object CurrentPoint => GetProperty<Object>("currentPoint");
        [Export("height")]
        public double Height => GetProperty<double>("height");
        [Export("hwTimestamp")]
        public double HwTimestamp => GetProperty<double>("hwTimestamp");
        [Export("intermediatePoints")]
        public Object IntermediatePoints => GetProperty<Object>("intermediatePoints");
        [Export("isPrimary")]
        public bool IsPrimary => GetProperty<bool>("isPrimary");
        [Export("pointerId")]
        public double PointerId => GetProperty<double>("pointerId");
        [Export("pointerType")]
        public Object PointerType => GetProperty<Object>("pointerType");
        [Export("pressure")]
        public double Pressure => GetProperty<double>("pressure");
        [Export("rotation")]
        public double Rotation => GetProperty<double>("rotation");
        [Export("tiltX")]
        public double TiltX => GetProperty<double>("tiltX");
        [Export("tiltY")]
        public double TiltY => GetProperty<double>("tiltY");
        [Export("width")]
        public double Width => GetProperty<double>("width");
        [Export("getCurrentPoint")]
        public void GetCurrentPoint(Element element)
        {
            InvokeMethod<object>("getCurrentPoint", element);
        }
        [Export("getIntermediatePoints")]
        public void GetIntermediatePoints(Element element)
        {
            InvokeMethod<object>("getIntermediatePoints", element);
        }
        [Export("initPointerEvent")]
        public void InitPointerEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Window viewArg, double detailArg, double screenXArg, double screenYArg, double clientXArg, double clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, double buttonArg, EventTarget relatedTargetArg, double offsetXArg, double offsetYArg, double widthArg, double heightArg, double pressure, double rotation, double tiltX, double tiltY, double pointerIdArg, Object pointerType, double hwTimestampArg, bool isPrimary)
        {
            InvokeMethod<object>("initPointerEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, offsetXArg, offsetYArg, widthArg, heightArg, pressure, rotation, tiltX, tiltY, pointerIdArg, pointerType, hwTimestampArg, isPrimary);
        }
    }
}
