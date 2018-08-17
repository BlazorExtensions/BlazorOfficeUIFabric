using System;
//using System.ComponentModel.Composition;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("Window", typeof(Mono.WebAssembly.JSObject))]
    public sealed class Window : EventTarget
    {
        internal Window(int handle) : base(handle) { }

        public Window() : base("window") { } 
        // [Export("applicationCache")]
        // public ApplicationCache ApplicationCache => GetProperty<ApplicationCache>("applicationCache");
        // [Export("caches")]
        // public CacheStorage Caches => GetProperty<CacheStorage>("caches");
        // [Export("clientInformation")]
        // public Navigator ClientInformation => GetProperty<Navigator>("clientInformation");
        [Export("closed")]
        public bool Closed => GetProperty<bool>("closed");
        // [Export("crypto")]
        // public Crypto Crypto => GetProperty<Crypto>("crypto");
        [Export("defaultStatus")]
        public string DefaultStatus { get => GetProperty<string>("defaultStatus"); set => SetProperty<string>("defaultStatus", value); }
        [Export("devicePixelRatio")]
        public double DevicePixelRatio => GetProperty<double>("devicePixelRatio");
        [Export("document")]
        public Document Document => GetProperty<Document>("document");
        [Export("doNotTrack")]
        public string DoNotTrack => GetProperty<string>("doNotTrack");
        // [Export("event")]
        // public Event Event { get => GetProperty<Event>("event"); set => SetProperty<Event>("event", value); }
        // [Export("external")]
        // public External External => GetProperty<External>("external");
        // [Export("frameElement")]
        // public Element FrameElement => GetProperty<Element>("frameElement");
        [Export("frames")]
        public Window Frames => GetProperty<Window>("frames");
        [Export("history")]
        public History History => GetProperty<History>("history");
        [Export("innerHeight")]
        public double InnerHeight => GetProperty<double>("innerHeight");
        [Export("innerWidth")]
        public double InnerWidth => GetProperty<double>("innerWidth");
        [Export("isSecureContext")]
        public bool IsSecureContext => GetProperty<bool>("isSecureContext");
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("location")]
        public Location Location => GetProperty<Location>("location");
        [Export("locationbar")]
        public BarProp Locationbar => GetProperty<BarProp>("locationbar");
        [Export("menubar")]
        public BarProp Menubar => GetProperty<BarProp>("menubar");
        // [Export("msContentScript")]
        // public ExtensionScriptApis MsContentScript => GetProperty<ExtensionScriptApis>("msContentScript");
        // [Export("msCredentials")]
        // public MSCredentials MsCredentials => GetProperty<MSCredentials>("msCredentials");
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        // [Export("navigator")]
        // public Navigator Navigator => GetProperty<Navigator>("navigator");
        [Export("offscreenBuffering")]
        public object OffscreenBuffering { get => GetProperty<object>("offscreenBuffering"); set => SetProperty<object>("offscreenBuffering", value); }
        public event DOMEventHandler OnAbort
        {
            add => AddEventListener("abort", value, false);
            remove => RemoveEventListener("abort", value, false);
        }
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
        public event DOMEventHandler OnBlur
        {
            add => AddEventListener("blur", value, false);
            remove => RemoveEventListener("blur", value, false);
        }
        public event DOMEventHandler OnCanplay
        {
            add => AddEventListener("canplay", value, false);
            remove => RemoveEventListener("canplay", value, false);
        }
        public event DOMEventHandler OnCanplaythrough
        {
            add => AddEventListener("canplaythrough", value, false);
            remove => RemoveEventListener("canplaythrough", value, false);
        }
        public event DOMEventHandler OnChange
        {
            add => AddEventListener("change", value, false);
            remove => RemoveEventListener("change", value, false);
        }
        public event DOMEventHandler OnClick
        {
            add => AddEventListener("click", value, false);
            remove => RemoveEventListener("click", value, false);
        }
        public event DOMEventHandler OnCompassneedscalibration
        {
            add => AddEventListener("compassneedscalibration", value, false);
            remove => RemoveEventListener("compassneedscalibration", value, false);
        }
        public event DOMEventHandler OnContextmenu
        {
            add => AddEventListener("contextmenu", value, false);
            remove => RemoveEventListener("contextmenu", value, false);
        }
        public event DOMEventHandler OnDblclick
        {
            add => AddEventListener("dblclick", value, false);
            remove => RemoveEventListener("dblclick", value, false);
        }
        public event DOMEventHandler OnDevicelight
        {
            add => AddEventListener("devicelight", value, false);
            remove => RemoveEventListener("devicelight", value, false);
        }
        public event DOMEventHandler OnDevicemotion
        {
            add => AddEventListener("devicemotion", value, false);
            remove => RemoveEventListener("devicemotion", value, false);
        }
        public event DOMEventHandler OnDeviceorientation
        {
            add => AddEventListener("deviceorientation", value, false);
            remove => RemoveEventListener("deviceorientation", value, false);
        }
        public event DOMEventHandler OnDrag
        {
            add => AddEventListener("drag", value, false);
            remove => RemoveEventListener("drag", value, false);
        }
        public event DOMEventHandler OnDragend
        {
            add => AddEventListener("dragend", value, false);
            remove => RemoveEventListener("dragend", value, false);
        }
        public event DOMEventHandler OnDragenter
        {
            add => AddEventListener("dragenter", value, false);
            remove => RemoveEventListener("dragenter", value, false);
        }
        public event DOMEventHandler OnDragleave
        {
            add => AddEventListener("dragleave", value, false);
            remove => RemoveEventListener("dragleave", value, false);
        }
        public event DOMEventHandler OnDragover
        {
            add => AddEventListener("dragover", value, false);
            remove => RemoveEventListener("dragover", value, false);
        }
        public event DOMEventHandler OnDragstart
        {
            add => AddEventListener("dragstart", value, false);
            remove => RemoveEventListener("dragstart", value, false);
        }
        public event DOMEventHandler OnDrop
        {
            add => AddEventListener("drop", value, false);
            remove => RemoveEventListener("drop", value, false);
        }
        public event DOMEventHandler OnDurationchange
        {
            add => AddEventListener("durationchange", value, false);
            remove => RemoveEventListener("durationchange", value, false);
        }
        public event DOMEventHandler OnEmptied
        {
            add => AddEventListener("emptied", value, false);
            remove => RemoveEventListener("emptied", value, false);
        }
        public event DOMEventHandler OnEnded
        {
            add => AddEventListener("ended", value, false);
            remove => RemoveEventListener("ended", value, false);
        }
        // [Export("onerror")]
        // public ErrorEventHandler Onerror { get => GetProperty<ErrorEventHandler>("onerror"); set => SetProperty<ErrorEventHandler>("onerror", value); }
        public event DOMEventHandler OnFocus
        {
            add => AddEventListener("focus", value, false);
            remove => RemoveEventListener("focus", value, false);
        }
        public event DOMEventHandler OnHashchange
        {
            add => AddEventListener("hashchange", value, false);
            remove => RemoveEventListener("hashchange", value, false);
        }
        public event DOMEventHandler OnInput
        {
            add => AddEventListener("input", value, false);
            remove => RemoveEventListener("input", value, false);
        }
        public event DOMEventHandler OnInvalid
        {
            add => AddEventListener("invalid", value, false);
            remove => RemoveEventListener("invalid", value, false);
        }
        public event DOMEventHandler OnKeydown
        {
            add => AddEventListener("keydown", value, false);
            remove => RemoveEventListener("keydown", value, false);
        }
        public event DOMEventHandler OnKeypress
        {
            add => AddEventListener("keypress", value, false);
            remove => RemoveEventListener("keypress", value, false);
        }
        public event DOMEventHandler OnKeyup
        {
            add => AddEventListener("keyup", value, false);
            remove => RemoveEventListener("keyup", value, false);
        }
        public event DOMEventHandler OnLoad
        {
            add => AddEventListener("load", value, false);
            remove => RemoveEventListener("load", value, false);
        }
        public event DOMEventHandler OnLoadedData
        {
            add => AddEventListener("loadeddata", value, false);
            remove => RemoveEventListener("loadeddata", value, false);
        }
        public event DOMEventHandler OnLoadedMetaData
        {
            add => AddEventListener("loadedmetadata", value, false);
            remove => RemoveEventListener("loadedmetadata", value, false);
        }
        public event DOMEventHandler OnLoadStart
        {
            add => AddEventListener("loadstart", value, false);
            remove => RemoveEventListener("loadstart", value, false);
        }
        public event DOMEventHandler OnMessage
        {
            add => AddEventListener("message", value, false);
            remove => RemoveEventListener("message", value, false);
        }
        public event DOMEventHandler OnMouseDown
        {
            add => AddEventListener("mousedown", value, false);
            remove => RemoveEventListener("mousedown", value, false);
        }
        public event DOMEventHandler OnMouseEnter
        {
            add => AddEventListener("mouseenter", value, false);
            remove => RemoveEventListener("mouseenter", value, false);
        }
        public event DOMEventHandler OnMouseLeave
        {
            add => AddEventListener("mouseleave", value, false);
            remove => RemoveEventListener("mouseleave", value, false);
        }
        public event DOMEventHandler OnMouseMove
        {
            add => AddEventListener("mousemove", value, false);
            remove => RemoveEventListener("mousemove", value, false);
        }
        public event DOMEventHandler OnMouseOut
        {
            add => AddEventListener("mouseout", value, false);
            remove => RemoveEventListener("mouseout", value, false);
        }
        public event DOMEventHandler OnMouseOver
        {
            add => AddEventListener("mouseover", value, false);
            remove => RemoveEventListener("mouseover", value, false);
        }
        public event DOMEventHandler OnMouseUp
        {
            add => AddEventListener("mouseup", value, false);
            remove => RemoveEventListener("mouseup", value, false);
        }
        public event DOMEventHandler OnMouseWheel
        {
            add => AddEventListener("mousewheel", value, false);
            remove => RemoveEventListener("mousewheel", value, false);
        }
        public event DOMEventHandler OnMsgestureChange
        {
            add => AddEventListener("msgesturechange", value, false);
            remove => RemoveEventListener("msgesturechange", value, false);
        }
        public event DOMEventHandler OnMsgesturedoubletap
        {
            add => AddEventListener("msgesturedoubletap", value, false);
            remove => RemoveEventListener("msgesturedoubletap", value, false);
        }
        public event DOMEventHandler OnMsgestureend
        {
            add => AddEventListener("msgestureend", value, false);
            remove => RemoveEventListener("msgestureend", value, false);
        }
        public event DOMEventHandler OnMsgesturehold
        {
            add => AddEventListener("msgesturehold", value, false);
            remove => RemoveEventListener("msgesturehold", value, false);
        }
        public event DOMEventHandler OnMsgesturestart
        {
            add => AddEventListener("msgesturestart", value, false);
            remove => RemoveEventListener("msgesturestart", value, false);
        }
        public event DOMEventHandler OnMsgesturetap
        {
            add => AddEventListener("msgesturetap", value, false);
            remove => RemoveEventListener("msgesturetap", value, false);
        }
        public event DOMEventHandler OnMsinertiastart
        {
            add => AddEventListener("msinertiastart", value, false);
            remove => RemoveEventListener("msinertiastart", value, false);
        }
        public event DOMEventHandler OnMspointercancel
        {
            add => AddEventListener("mspointercancel", value, false);
            remove => RemoveEventListener("mspointercancel", value, false);
        }
        public event DOMEventHandler OnMspointerdown
        {
            add => AddEventListener("mspointerdown", value, false);
            remove => RemoveEventListener("mspointerdown", value, false);
        }
        public event DOMEventHandler OnMspointerenter
        {
            add => AddEventListener("mspointerenter", value, false);
            remove => RemoveEventListener("mspointerenter", value, false);
        }
        public event DOMEventHandler OnMspointerleave
        {
            add => AddEventListener("mspointerleave", value, false);
            remove => RemoveEventListener("mspointerleave", value, false);
        }
        public event DOMEventHandler OnMspointermove
        {
            add => AddEventListener("mspointermove", value, false);
            remove => RemoveEventListener("mspointermove", value, false);
        }
        public event DOMEventHandler OnMspointerout
        {
            add => AddEventListener("mspointerout", value, false);
            remove => RemoveEventListener("mspointerout", value, false);
        }
        public event DOMEventHandler OnMspointerover
        {
            add => AddEventListener("mspointerover", value, false);
            remove => RemoveEventListener("mspointerover", value, false);
        }
        public event DOMEventHandler OnMspointerup
        {
            add => AddEventListener("mspointerup", value, false);
            remove => RemoveEventListener("mspointerup", value, false);
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
        public event DOMEventHandler OnOrientationChange
        {
            add => AddEventListener("orientationchange", value, false);
            remove => RemoveEventListener("orientationchange", value, false);
        }
        public event DOMEventHandler OnPageHide
        {
            add => AddEventListener("pagehide", value, false);
            remove => RemoveEventListener("pagehide", value, false);
        }
        public event DOMEventHandler OnPageShow
        {
            add => AddEventListener("pageshow", value, false);
            remove => RemoveEventListener("pageshow", value, false);
        }
        public event DOMEventHandler OnPause
        {
            add => AddEventListener("pause", value, false);
            remove => RemoveEventListener("pause", value, false);
        }
        public event DOMEventHandler OnPlay
        {
            add => AddEventListener("play", value, false);
            remove => RemoveEventListener("play", value, false);
        }
        public event DOMEventHandler OnPlaying
        {
            add => AddEventListener("playing", value, false);
            remove => RemoveEventListener("playing", value, false);
        }
        public event DOMEventHandler OnPopState
        {
            add => AddEventListener("popstate", value, false);
            remove => RemoveEventListener("popstate", value, false);
        }
        public event DOMEventHandler OnProgress
        {
            add => AddEventListener("progress", value, false);
            remove => RemoveEventListener("progress", value, false);
        }
        public event DOMEventHandler OnRateChange
        {
            add => AddEventListener("ratechange", value, false);
            remove => RemoveEventListener("ratechange", value, false);
        }
        public event DOMEventHandler OnReadyStateChange
        {
            add => AddEventListener("readystatechange", value, false);
            remove => RemoveEventListener("readystatechange", value, false);
        }
        public event DOMEventHandler OnReset
        {
            add => AddEventListener("reset", value, false);
            remove => RemoveEventListener("reset", value, false);
        }
        public event DOMEventHandler OnResize
        {
            add => AddEventListener("resize", value, false);
            remove => RemoveEventListener("resize", value, false);
        }
        public event DOMEventHandler OnScroll
        {
            add => AddEventListener("scroll", value, false);
            remove => RemoveEventListener("scroll", value, false);
        }
        public event DOMEventHandler OnSeeked
        {
            add => AddEventListener("seeked", value, false);
            remove => RemoveEventListener("seeked", value, false);
        }
        public event DOMEventHandler OnSeeking
        {
            add => AddEventListener("seeking", value, false);
            remove => RemoveEventListener("seeking", value, false);
        }
        public event DOMEventHandler OnSelect
        {
            add => AddEventListener("select", value, false);
            remove => RemoveEventListener("select", value, false);
        }
        public event DOMEventHandler OnStalled
        {
            add => AddEventListener("stalled", value, false);
            remove => RemoveEventListener("stalled", value, false);
        }
        public event DOMEventHandler OnStorage
        {
            add => AddEventListener("storage", value, false);
            remove => RemoveEventListener("storage", value, false);
        }
        public event DOMEventHandler OnSubmit
        {
            add => AddEventListener("submit", value, false);
            remove => RemoveEventListener("submit", value, false);
        }
        public event DOMEventHandler OnSuspend
        {
            add => AddEventListener("suspend", value, false);
            remove => RemoveEventListener("suspend", value, false);
        }
        public event DOMEventHandler OnTimeupdate
        {
            add => AddEventListener("timeupdate", value, false);
            remove => RemoveEventListener("timeupdate", value, false);
        }
        // [Export("ontouchcancel")]
        // public Action Ontouchcancel { get => GetProperty<Action>("ontouchcancel"); set => SetProperty<Action>("ontouchcancel", value); }
        // [Export("ontouchend")]
        // public Action Ontouchend { get => GetProperty<Action>("ontouchend"); set => SetProperty<Action>("ontouchend", value); }
        // [Export("ontouchmove")]
        // public Action Ontouchmove { get => GetProperty<Action>("ontouchmove"); set => SetProperty<Action>("ontouchmove", value); }
        // [Export("ontouchstart")]
        // public Action Ontouchstart { get => GetProperty<Action>("ontouchstart"); set => SetProperty<Action>("ontouchstart", value); }
        public event DOMEventHandler OnUnload
        {
            add => AddEventListener("unload", value, false);
            remove => RemoveEventListener("unload", value, false);
        }
        public event DOMEventHandler OnVolumechange
        {
            add => AddEventListener("volumechange", value, false);
            remove => RemoveEventListener("volumechange", value, false);
        }
        public event DOMEventHandler OnWaiting
        {
            add => AddEventListener("waiting", value, false);
            remove => RemoveEventListener("waiting", value, false);
        }
        [Export("opener")]
        public Object Opener { get => GetProperty<Object>("opener"); set => SetProperty<Object>("opener", value); }
        [Export("orientation")]
        public object Orientation { get => GetProperty<object>("orientation"); set => SetProperty<object>("orientation", value); }
        [Export("outerHeight")]
        public double OuterHeight => GetProperty<double>("outerHeight");
        [Export("outerWidth")]
        public double OuterWidth => GetProperty<double>("outerWidth");
        [Export("pageXOffset")]
        public double PageXOffset => GetProperty<double>("pageXOffset");
        [Export("pageYOffset")]
        public double PageYOffset => GetProperty<double>("pageYOffset");
        [Export("parent")]
        public Window Parent => GetProperty<Window>("parent");
        [Export("performance")]
        public Performance Performance => GetProperty<Performance>("performance");
        [Export("personalbar")]
        public BarProp Personalbar => GetProperty<BarProp>("personalbar");
        // [Export("screen")]
        // public Screen Screen => GetProperty<Screen>("screen");
        [Export("screenLeft")]
        public double ScreenLeft => GetProperty<double>("screenLeft");
        [Export("screenTop")]
        public double ScreenTop => GetProperty<double>("screenTop");
        [Export("screenX")]
        public double ScreenX => GetProperty<double>("screenX");
        [Export("screenY")]
        public double ScreenY => GetProperty<double>("screenY");
        [Export("scrollbars")]
        public BarProp Scrollbars => GetProperty<BarProp>("scrollbars");
        [Export("scrollX")]
        public double ScrollX => GetProperty<double>("scrollX");
        [Export("scrollY")]
        public double ScrollY => GetProperty<double>("scrollY");
        [Export("self")]
        public Window Self => GetProperty<Window>("self");
        // [Export("speechSynthesis")]
        // public SpeechSynthesis SpeechSynthesis => GetProperty<SpeechSynthesis>("speechSynthesis");
        [Export("status")]
        public string Status { get => GetProperty<string>("status"); set => SetProperty<string>("status", value); }
        [Export("statusbar")]
        public BarProp Statusbar => GetProperty<BarProp>("statusbar");
        // [Export("styleMedia")]
        // public StyleMedia StyleMedia => GetProperty<StyleMedia>("styleMedia");
        [Export("toolbar")]
        public BarProp Toolbar => GetProperty<BarProp>("toolbar");
        [Export("top")]
        public Window Top => GetProperty<Window>("top");
        [Export("window")]
        public Window IWindow => GetProperty<Window>("window");
         [Export("URL")]
         public URL Url { get => GetProperty<URL>("URL"); set => SetProperty<URL>("URL", value); }
         [Export("URLSearchParams")]
         public URLSearchParams UrlSearchParams { get => GetProperty<URLSearchParams>("URLSearchParams"); set => SetProperty<URLSearchParams>("URLSearchParams", value); }
        // [Export("Blob")]
        // public Blob Blob { get => GetProperty<Blob>("Blob"); set => SetProperty<Blob>("Blob", value); }
        // [Export("customElements")]
        // public CustomElementRegistry CustomElements { get => GetProperty<CustomElementRegistry>("customElements"); set => SetProperty<CustomElementRegistry>("customElements", value); }
        // [Export("console")]
        // public IConsole IConsole => GetProperty<Console>("console");
        public event DOMEventHandler OnPointercancel
        {
            add => AddEventListener("pointercancel", value, false);
            remove => RemoveEventListener("pointercancel", value, false);
        }
        public event DOMEventHandler OnPointerdown
        {
            add => AddEventListener("pointerdown", value, false);
            remove => RemoveEventListener("pointerdown", value, false);
        }
        public event DOMEventHandler OnPointerenter
        {
            add => AddEventListener("pointerenter", value, false);
            remove => RemoveEventListener("pointerenter", value, false);
        }
        public event DOMEventHandler OnPointerleave
        {
            add => AddEventListener("pointerleave", value, false);
            remove => RemoveEventListener("pointerleave", value, false);
        }
        public event DOMEventHandler OnPointermove
        {
            add => AddEventListener("pointermove", value, false);
            remove => RemoveEventListener("pointermove", value, false);
        }
        public event DOMEventHandler OnPointerout
        {
            add => AddEventListener("pointerout", value, false);
            remove => RemoveEventListener("pointerout", value, false);
        }
        public event DOMEventHandler OnPointerover
        {
            add => AddEventListener("pointerover", value, false);
            remove => RemoveEventListener("pointerover", value, false);
        }
        public event DOMEventHandler OnPointerup
        {
            add => AddEventListener("pointerup", value, false);
            remove => RemoveEventListener("pointerup", value, false);
        }
        public event DOMEventHandler OnWheel
        {
            add => AddEventListener("wheel", value, false);
            remove => RemoveEventListener("wheel", value, false);
        }
        [Export("alert")]
        public void Alert(Object message)
        {
            InvokeMethod<object>("alert", message);
        }
        [Export("blur")]
        public void Blur()
        {
            InvokeMethod<object>("blur");
        }
        [Export("cancelAnimationFrame")]
        public void CancelAnimationFrame(double handle)
        {
            InvokeMethod<object>("cancelAnimationFrame", handle);
        }
        [Export("captureEvents")]
        public void CaptureEvents()
        {
            InvokeMethod<object>("captureEvents");
        }
        [Export("close")]
        public void Close()
        {
            InvokeMethod<object>("close");
        }
        [Export("confirm")]
        public bool Confirm(string message)
        {
            return InvokeMethod<bool>("confirm", message);
        }
        // [Export("departFocus")]
        // public void DepartFocus(string navigationReason, FocusNavigationOrigin origin)
        // {
        //     InvokeMethod<object>("departFocus", navigationReason, origin);
        // }
        [Export("focus")]
        public void Focus()
        {
            InvokeMethod<object>("focus");
        }
        // [Export("getComputedStyle")]
        // public CSSStyleDeclaration GetComputedStyle(Element elt, string pseudoElt)
        // {
        //     return InvokeMethod<CSSStyleDeclaration>("getComputedStyle", elt, pseudoElt);
        // }
        // [Export("getMatchedCSSRules")]
        // public CSSRuleList GetMatchedCssRules(Element elt, string pseudoElt)
        // {
        //     return InvokeMethod<CSSRuleList>("getMatchedCSSRules", elt, pseudoElt);
        // }
        // [Export("getSelection")]
        // public Selection GetSelection()
        // {
        //     return InvokeMethod<Selection>("getSelection");
        // }
        // [Export("matchMedia")]
        // public MediaQueryList MatchMedia(string mediaQuery)
        // {
        //     return InvokeMethod<MediaQueryList>("matchMedia", mediaQuery);
        // }
        [Export("moveBy")]
        public void MoveBy(double x, double y)
        {
            InvokeMethod<object>("moveBy", x, y);
        }
        [Export("moveTo")]
        public void MoveTo(double x, double y)
        {
            InvokeMethod<object>("moveTo", x, y);
        }
        [Export("msWriteProfilerMark")]
        public void MsWriteProfilerMark(string profilerMarkName)
        {
            InvokeMethod<object>("msWriteProfilerMark", profilerMarkName);
        }
        [Export("open")]
        public Window Open(string url, string target, string features, bool replace)
        {
            return InvokeMethod<Window>("open", url, target, features, replace);
        }
        [Export("postMessage")]
        public void PostMessage(Object message, string targetOrigin, Object[] transfer)
        {
            InvokeMethod<object>("postMessage", message, targetOrigin, transfer);
        }
        [Export("print")]
        public void Print()
        {
            InvokeMethod<object>("print");
        }
        [Export("prompt")]
        public string Prompt(string message, string _default)
        {
            return InvokeMethod<string>("prompt", message, _default);
        }
        [Export("releaseEvents")]
        public void ReleaseEvents()
        {
            InvokeMethod<object>("releaseEvents");
        }
        // [Export("requestAnimationFrame")]
        // public double RequestAnimationFrame(FrameRequestCallback callback)
        // {
        //     return InvokeMethod<double>("requestAnimationFrame", callback);
        // }
        [Export("resizeBy")]
        public void ResizeBy(double x, double y)
        {
            InvokeMethod<object>("resizeBy", x, y);
        }
        [Export("resizeTo")]
        public void ResizeTo(double x, double y)
        {
            InvokeMethod<object>("resizeTo", x, y);
        }
        [Export("scroll")]
        public void Scroll(double x, double y)
        {
            InvokeMethod<object>("scroll", x, y);
        }
        [Export("scrollBy")]
        public void ScrollBy(double x, double y)
        {
            InvokeMethod<object>("scrollBy", x, y);
        }
        [Export("scrollTo")]
        public void ScrollTo(double x, double y)
        {
            InvokeMethod<object>("scrollTo", x, y);
        }
        [Export("stop")]
        public void Stop()
        {
            InvokeMethod<object>("stop");
        }
        [Export("webkitCancelAnimationFrame")]
        public void WebkitCancelAnimationFrame(double handle)
        {
            InvokeMethod<object>("webkitCancelAnimationFrame", handle);
        }
        [Export("webkitConvertPointFromNodeToPage")]
        public WebKitPoint WebkitConvertPointFromNodeToPage(Node node, WebKitPoint pt)
        {
            return InvokeMethod<WebKitPoint>("webkitConvertPointFromNodeToPage", node, pt);
        }
        [Export("webkitConvertPointFromPageToNode")]
        public WebKitPoint WebkitConvertPointFromPageToNode(Node node, WebKitPoint pt)
        {
            return InvokeMethod<WebKitPoint>("webkitConvertPointFromPageToNode", node, pt);
        }
        // [Export("webkitRequestAnimationFrame")]
        // public double WebkitRequestAnimationFrame(FrameRequestCallback callback)
        // {
        //     return InvokeMethod<double>("webkitRequestAnimationFrame", callback);
        // }
        // [Export("createImageBitmap")]
        // public Promise<ImageBitmap> CreateImageBitmap(object image, ImageBitmapOptions options)
        // {
        //     return InvokeMethod<Promise<ImageBitmap>>("createImageBitmap", image, options);
        // }
        [Export("atob")]
        public string Atob(string encodedString)
        {
            return InvokeMethod<string>("atob", encodedString);
        }
        [Export("btoa")]
        public string Btoa(string rawString)
        {
            return InvokeMethod<string>("btoa", rawString);
        }
    }
}