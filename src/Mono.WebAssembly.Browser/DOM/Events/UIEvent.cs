using System;
using System.Collections.Generic;

namespace Mono.WebAssembly.Browser.DOM.Events
{

    [Export("UIEvent", typeof(Mono.WebAssembly.JSObject))]
    public class UIEvent : Event
    {
        internal UIEvent(int handle) : base(handle) { }

        //        public UIEvent(string typeArg, IUIEventInit eventInitDict) { }
        [Export("detail")]
        public double Detail { get; internal set; }
        [Export("view")]
        public Window View => GetProperty<Window>("view");
        //[Export("initUIEvent")]
        //public void InitUiEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Window viewArg, double detailArg)
        //{
        //    InvokeMethod<object>("initUIEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg);
        //}

        internal override void InitEvent(Dictionary<string, string> eventInfoDic)
        {
            base.InitEvent(eventInfoDic);
            string value = null;

            if (eventInfoDic.TryGetValue("detail", out value))
            {
                this.Detail = Convert.ToInt32(value);
            }

        }

    }

}
