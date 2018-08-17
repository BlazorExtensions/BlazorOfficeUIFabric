using System;
using System.Collections.Generic;

namespace Mono.WebAssembly.Browser.DOM.Events
{
    [Export("Event", typeof(Mono.WebAssembly.JSObject))]
    public class Event : JSObject
    {
        internal Event(int handle) : base(handle) { }

        public Event(string typeArg, IEventInit eventInitDict) { }
        [Export("AT_TARGET")]
        public double AtTarget => GetProperty<double>("AT_TARGET");
        [Export("BUBBLING_PHASE")]
        public double BubblingPhase => GetProperty<double>("BUBBLING_PHASE");
        [Export("CAPTURING_PHASE")]
        public double CapturingPhase => GetProperty<double>("CAPTURING_PHASE");
        [Export("bubbles")]
        public bool Bubbles { get; internal set; }
        [Export("cancelable")]
        public bool Cancelable { get; internal set; }
        [Export("cancelBubble")]
        public bool CancelBubble { get => GetProperty<bool>("cancelBubble"); set => SetProperty<bool>("cancelBubble", value); }
        [Export("currentTarget")]
        public EventTarget CurrentTarget => GetProperty<EventTarget>("currentTarget");
        [Export("defaultPrevented")]
        public bool DefaultPrevented => GetProperty<bool>("defaultPrevented");
        [Export("eventPhase")]
        public double EventPhase { get; internal set; }
        [Export("isTrusted")]
        public bool IsTrusted { get; internal set; }
        [Export("returnValue")]
        public bool ReturnValue { get => GetProperty<bool>("returnValue"); set => SetProperty<bool>("returnValue", value); }
        [Export("srcElement")]
        public Element SrcElement => GetProperty<Element>("srcElement");
        [Export("target")]
        public EventTarget Target => GetProperty<EventTarget>("target");
        [Export("timeStamp")]
        public double TimeStamp { get; internal set; }
        [Export("type")]
        public string Type { get; internal set; }
        [Export("scoped")]
        public bool Scoped { get; internal set; }
        //[Export("initEvent")]
        //public void InitEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg)
        //{
        //    InvokeMethod<object>("initEvent", eventTypeArg, canBubbleArg, cancelableArg);
        //}
        [Export("preventDefault")]
        public void PreventDefault()
        {
            InvokeMethod<object>("preventDefault");
        }
        [Export("stopImmediatePropagation")]
        public void StopImmediatePropagation()
        {
            InvokeMethod<object>("stopImmediatePropagation");
        }
        [Export("stopPropagation")]
        public void StopPropagation()
        {
            InvokeMethod<object>("stopPropagation");
        }
        [Export("deepPath")]
        public EventTarget[] DeepPath()
        {
            return InvokeMethod<EventTarget[]>("deepPath");
        }


        internal virtual void InitEvent(Dictionary<string, string> eventInfoDic)
        {
            string value = null;

            if (eventInfoDic.TryGetValue("bubbles", out value))
            {
                this.Bubbles = Convert.ToBoolean(value);
            }

            if (eventInfoDic.TryGetValue("cancelable", out value))
            {
                this.Cancelable = Convert.ToBoolean(value);
            }

            if (eventInfoDic.TryGetValue("timeStamp", out value))
            {
                this.TimeStamp = Convert.ToDouble(value);
            }

            if (eventInfoDic.TryGetValue("scoped", out value))
            {
                this.Scoped = Convert.ToBoolean(value);
            }

            if (eventInfoDic.TryGetValue("type", out value))
            {
                this.Type = Convert.ToString(value);
            }


            if (eventInfoDic.TryGetValue("eventPhase", out value))
            {
                this.EventPhase = Convert.ToDouble(value);
            }

        }

    }
}
