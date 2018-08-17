using System;
using System.Collections.Generic;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM.Events
{

    [Export("DragEvent", typeof(Mono.WebAssembly.JSObject))]
    public sealed class DragEvent : MouseEvent
    {
        internal DragEvent(int handle) : base(handle) { }

        //public DragEvent(object type, object dragEventInit) { }
        DataTransfer dataTransfer;
        [Export("dataTransfer")]
        public DataTransfer DataTransfer { 
            get
            {
                if (this.dataTransfer == null)
                    this.dataTransfer = GetProperty<DataTransfer>("dataTransfer");
                return this.dataTransfer;
            }
            set => SetProperty<DataTransfer>("dataTransfer", value); 
        }
		//[Export("initDragEvent")]
		//public void InitDragEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Window viewArg, double detailArg, double screenXArg, double screenYArg, double clientXArg, double clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, double buttonArg, EventTarget relatedTargetArg, IDataTransfer dataTransferArg)
		//{
		//    InvokeMethod<object>("initDragEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, dataTransferArg);
		//}
		//[Export("msConvertURL")]
		//public void MsConvertUrl(File file, string targetType, string targetURL)
		//{
		//    InvokeMethod<object>("msConvertURL", file, targetType, targetURL);
		//}

		protected override void Dispose(bool disposing)
		{
			// the event object handle is already unregistered within the event handling function
            // no need to do this again.
            if (disposing)
            {
                if (this.dataTransfer != null)
                {
                    this.dataTransfer.Dispose();    
                }
            }

		}

        internal override void InitEvent(Dictionary<string, string> eventInfoDic)
        {
            base.InitEvent(eventInfoDic);
        }
	}

}