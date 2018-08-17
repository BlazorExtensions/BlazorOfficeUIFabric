using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{


[Export("HTMLFrameSetElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLFrameSetElement : HTMLElement, IHTMLFrameSetElement {
    internal HTMLFrameSetElement  (int handle) : base (handle) {}

    //public HTMLFrameSetElement () { }
    [Export("border")]
    public string Border { get => GetProperty<string>("border"); set => SetProperty<string>("border", value); }
    [Export("borderColor")]
    public string BorderColor { get => GetProperty<string>("borderColor"); set => SetProperty<string>("borderColor", value); }
    [Export("cols")]
    public string Cols { get => GetProperty<string>("cols"); set => SetProperty<string>("cols", value); }
    [Export("frameBorder")]
    public string FrameBorder { get => GetProperty<string>("frameBorder"); set => SetProperty<string>("frameBorder", value); }
    [Export("frameSpacing")]
    public string FrameSpacing { get => GetProperty<string>("frameSpacing"); set => SetProperty<string>("frameSpacing", value); }
    [Export("name")]
    public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
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
    [Export("rows")]
    public string Rows { get => GetProperty<string>("rows"); set => SetProperty<string>("rows", value); }
}
}