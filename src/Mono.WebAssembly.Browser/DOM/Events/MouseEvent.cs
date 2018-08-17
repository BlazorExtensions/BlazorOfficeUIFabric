using System;
using System.Collections.Generic;

namespace Mono.WebAssembly.Browser.DOM.Events
{
    [Export("MouseEvent", typeof(Mono.WebAssembly.JSObject))]
    public class MouseEvent : UIEvent
    {
        internal MouseEvent(int handle) : base(handle) { }

        //public MouseEvent(string typeArg, IMouseEventInit eventInitDict) { }
        [Export("altKey")]
        public bool AltKey { get; internal set; }
        [Export("button")]
        public double Button { get; internal set; }
        [Export("buttons")]
        public double Buttons { get; internal set; }
        [Export("clientX")]
        public double ClientX { get; internal set; }
        [Export("clientY")]
        public double ClientY { get; internal set; }
        [Export("ctrlKey")]
        public bool CtrlKey { get; internal set; }
        [Export("fromElement")]
        public Element FromElement => GetProperty<Element>("fromElement");
        [Export("layerX")]
        public double LayerX { get; internal set; }
        [Export("layerY")]
        public double LayerY { get; internal set; }
        [Export("metaKey")]
        public bool MetaKey { get; internal set; }
        [Export("movementX")]
        public double MovementX { get; internal set; }
        [Export("movementY")]
        public double MovementY { get; internal set; }
        [Export("offsetX")]
        public double OffsetX { get; internal set; }
        [Export("offsetY")]
        public double OffsetY { get; internal set; }
        [Export("pageX")]
        public double PageX { get; internal set; }
        [Export("pageY")]
        public double PageY { get; internal set; }
        [Export("relatedTarget")]
        public EventTarget RelatedTarget => GetProperty<EventTarget>("relatedTarget");
        [Export("screenX")]
        public double ScreenX { get; internal set; }
        [Export("screenY")]
        public double ScreenY { get; internal set; }
        [Export("shiftKey")]
        public bool ShiftKey { get; internal set; }
        [Export("toElement")]
        public Element ToElement => GetProperty<Element>("toElement");
        [Export("which")]
        public double Which { get; internal set; }
        [Export("x")]
        public double X { get; internal set; }
        [Export("y")]
        public double Y { get; internal set; }
        [Export("getModifierState")]
        public bool GetModifierState(string keyArg)
        {
            return InvokeMethod<bool>("getModifierState", keyArg);
        }
        //[Export("initMouseEvent")]
        //public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Window viewArg, double detailArg, double screenXArg, double screenYArg, double clientXArg, double clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, double buttonArg, EventTarget relatedTargetArg)
        //{
        //    InvokeMethod<object>("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
        //}
        internal override void InitEvent(Dictionary<string,string> eventInfoDic)
        {
            base.InitEvent(eventInfoDic);
            string value = null;

            if (eventInfoDic.TryGetValue("button", out value))
            {
                this.Button = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("buttons", out value))
            {
                this.Buttons = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("clientX", out value))
            {
                this.ClientX = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("clientY", out value))
            {
                this.ClientY = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("offsetX", out value))
            {
                this.OffsetX = Convert.ToInt32(value);
            }
            if (eventInfoDic.TryGetValue("offsetY", out value))
            {
                this.OffsetY = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("pageX", out value))
            {
                this.PageX = Convert.ToInt32(value);
            }
            if (eventInfoDic.TryGetValue("pageY", out value))
            {
                this.PageY = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("screenX", out value))
            {
                this.ScreenX = Convert.ToInt32(value);
            }
            if (eventInfoDic.TryGetValue("screenY", out value))
            {
                this.ScreenY = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("movementX", out value))
            {
                this.MovementX = Convert.ToInt32(value);
            }
            if (eventInfoDic.TryGetValue("movementY", out value))
            {
                this.MovementY = Convert.ToInt32(value);
            }


            if (eventInfoDic.TryGetValue("layerX", out value))
            {
                this.LayerX = Convert.ToInt32(value);
            }
            if (eventInfoDic.TryGetValue("layerY", out value))
            {
                this.LayerY = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("altKey", out value))
            {
                this.AltKey = Convert.ToBoolean(value);
            }

            if (eventInfoDic.TryGetValue("ctrlKey", out value))
            {
                this.CtrlKey = Convert.ToBoolean(value);
            }
            if (eventInfoDic.TryGetValue("shiftKey", out value))
            {
                this.ShiftKey = Convert.ToBoolean(value);
            }
            if (eventInfoDic.TryGetValue("metaKey", out value))
            {
                this.MetaKey = Convert.ToBoolean(value);
            }


            if (eventInfoDic.TryGetValue("x", out value))
            {
                this.X = Convert.ToInt32(value);
            }
            if (eventInfoDic.TryGetValue("y", out value))
            {
                this.Y = Convert.ToInt32(value);
            }

            if (eventInfoDic.TryGetValue("which", out value))
            {
                this.Which = Convert.ToInt32(value);
            }
        }
    }

}
