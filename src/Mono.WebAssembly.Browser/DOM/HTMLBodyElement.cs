using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLBodyElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLBodyElement : HTMLElement, IHTMLBodyElement {
    internal HTMLBodyElement  (int handle) : base (handle) {}

    //public HTMLBodyElement () { }
    [Export("aLink")]
    public Object ALink { get => GetProperty<Object>("aLink"); set => SetProperty<Object>("aLink", value); }
    [Export("background")]
    public string Background { get => GetProperty<string>("background"); set => SetProperty<string>("background", value); }
    [Export("bgColor")]
    public Object BgColor { get => GetProperty<Object>("bgColor"); set => SetProperty<Object>("bgColor", value); }
    [Export("bgProperties")]
    public string BgProperties { get => GetProperty<string>("bgProperties"); set => SetProperty<string>("bgProperties", value); }
    [Export("link")]
    public Object Link { get => GetProperty<Object>("link"); set => SetProperty<Object>("link", value); }
    [Export("noWrap")]
    public bool NoWrap { get => GetProperty<bool>("noWrap"); set => SetProperty<bool>("noWrap", value); }
    public event DOMEventHandler OnAfterprint
    {
    	add => AddEventListener("afterprint", value, false);
    	remove => RemoveEventListener("afterprint", value, false);
    }
    public event DOMEventHandler OnBeforeprint
    {
    	add => AddEventListener("beforeprint", value, false);
    	remove => RemoveEventListener("beforeprint", value, false);
    }
    public event DOMEventHandler OnBeforeunload
    {
    	add => AddEventListener("beforeunload", value, false);
    	remove => RemoveEventListener("beforeunload", value, false);
    }
    public event DOMEventHandler OnHashchange
    {
    	add => AddEventListener("hashchange", value, false);
    	remove => RemoveEventListener("hashchange", value, false);
    }
    public event DOMEventHandler OnMessage
    {
    	add => AddEventListener("message", value, false);
    	remove => RemoveEventListener("message", value, false);
    }
    public event DOMEventHandler OnOffline
    {
    	add => AddEventListener("offline", value, false);
    	remove => RemoveEventListener("offline", value, false);
    }
    public event DOMEventHandler OnOnline
    {
    	add => AddEventListener("online", value, false);
    	remove => RemoveEventListener("online", value, false);
    }
    public event DOMEventHandler OnOrientationchange
    {
    	add => AddEventListener("orientationchange", value, false);
    	remove => RemoveEventListener("orientationchange", value, false);
    }
    public event DOMEventHandler OnPagehide
    {
    	add => AddEventListener("pagehide", value, false);
    	remove => RemoveEventListener("pagehide", value, false);
    }
    public event DOMEventHandler OnPageshow
    {
    	add => AddEventListener("pageshow", value, false);
    	remove => RemoveEventListener("pageshow", value, false);
    }
    public event DOMEventHandler OnPopstate
    {
    	add => AddEventListener("popstate", value, false);
    	remove => RemoveEventListener("popstate", value, false);
    }
    public event DOMEventHandler OnResize
    {
    	add => AddEventListener("resize", value, false);
    	remove => RemoveEventListener("resize", value, false);
    }
    public event DOMEventHandler OnStorage
    {
    	add => AddEventListener("storage", value, false);
    	remove => RemoveEventListener("storage", value, false);
    }
    public event DOMEventHandler OnUnload
    {
    	add => AddEventListener("unload", value, false);
    	remove => RemoveEventListener("unload", value, false);
    }
    [Export("text")]
    public Object Text { get => GetProperty<Object>("text"); set => SetProperty<Object>("text", value); }
    [Export("vLink")]
    public Object VLink { get => GetProperty<Object>("vLink"); set => SetProperty<Object>("vLink", value); }
}
}