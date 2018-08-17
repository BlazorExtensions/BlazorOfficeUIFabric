using System;
namespace Mono.WebAssembly.Browser.DOM
{
    public partial class EventTarget
    {

        public void DispatchDOMEvent(string type, string typeOfEvent, string UID, string eventHandle, string eventInfo = null)
        {

            //#if DEBUG
            //Console.WriteLine($"EventType: {type} TypeOfEvent: {typeOfEvent}, Event Id: {UID}, Event Handle: {eventHandle}, Event Info: {eventInfo}");
            //#endif

            var eventArgs = new DOMEventArgs(this, type, typeOfEvent, eventHandle, eventInfo);


            lock (this.eventHandlers)
            {
                DOMEventHandler eventHandler;
                if (this.eventHandlers.TryGetValue(type, out eventHandler))
                {
                    eventHandler?.Invoke(this, eventArgs);
                }
            }

            eventArgs.EventObject.Dispose();
        }
    }
}
