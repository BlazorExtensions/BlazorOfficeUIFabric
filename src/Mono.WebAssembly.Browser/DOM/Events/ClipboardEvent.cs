using System;
using System.Collections.Generic;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM.Events
{

    [Export("ClipboardEvent", typeof(Mono.WebAssembly.JSObject))]
    public sealed class ClipboardEvent : Event
    {
        internal ClipboardEvent(int handle) : base(handle) { }

        //public ClipboardEvent (string type, ClipboardEventInit eventInitDict) { }
        DataTransfer clipboardData;

        [Export("clipboardData")]
        public DataTransfer ClipboardData
        {
            get
            {
                if (this.clipboardData == null)
                    this.clipboardData = GetProperty<DataTransfer>("clipboardData");
                return this.clipboardData;
            }
            set => SetProperty<DataTransfer>("clipboardData", value);
        }


        protected override void Dispose(bool disposing)
        {
            // the event object handle is already unregistered within the event handling function
            // no need to do this again.
            if (disposing)
            {
                if (this.clipboardData != null)
                {
                    this.clipboardData.Dispose();
                }
            }

        }

        internal override void InitEvent(Dictionary<string, string> eventInfoDic)
        {
            base.InitEvent(eventInfoDic);
        }


    }

}