using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Mono.WebAssembly
{

	public sealed class RuntimeEventManager {
		

        // The event handling may be a little simple but works for now
        // Will need to be looked at in the future.
        static Dictionary<string, Browser.DOM.IEventTarget> eventManager = new Dictionary<string, Browser.DOM.IEventTarget>();
        static SemaphoreSlim eventSemaphore = new SemaphoreSlim(1);
        internal static void RegisterEventTarget(string uid, Browser.DOM.IEventTarget listener)
        {
            eventSemaphore.Wait();
            if (!eventManager.ContainsKey(uid))
                eventManager.Add(uid, listener);
            eventSemaphore.Release();
        }

        internal static void UnRegisterEventTarget(string uid)
        {
            eventSemaphore.Wait();
            if (eventManager.ContainsKey(uid))
                eventManager.Remove(uid);
            eventSemaphore.Release();
        }

        internal static void EventWrangler(string eventType, string typeOfEvent, string eventId, string eventHandle, string eventInfo)
        {
            eventSemaphore.Wait();
            Browser.DOM.IEventTarget eventTarget;
            if (eventManager.TryGetValue(eventId, out eventTarget))
            {
                eventTarget.DispatchDOMEvent(eventType, typeOfEvent, eventId, eventHandle, eventInfo);
            }
            eventSemaphore.Release();
            
        }
		
	}


}
