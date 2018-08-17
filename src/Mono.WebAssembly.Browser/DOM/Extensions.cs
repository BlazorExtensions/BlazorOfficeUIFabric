using System;
using System.Reflection;

namespace Mono.WebAssembly.Browser.DOM
{
    public static class Extensions
    {
        public static T As<T>(this Element htmlElement) where T : Element
        {
            var type = typeof(T);
            var jsobjectnew = typeof(T).GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                            null, new Type[] { typeof(Int32) }, null);

            return (T)jsobjectnew.Invoke(new object[] { htmlElement.Handle });
        }

        public static T As<T>(this EventTarget eventTarget) where T : EventTarget
        {
            return eventTarget.ConvertTo<T>();
        }
    }
}
