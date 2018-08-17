using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLElement", typeof(Mono.WebAssembly.JSObject))]
    public class HTMLElement : Element, IHTMLElement
    {
        internal HTMLElement(int handle) : base(handle) { }

        //public HTMLElement() { }
        [Export("accessKey")]
        public string AccessKey { get => GetProperty<string>("accessKey"); set => SetProperty<string>("accessKey", value); }
        //[Export("children")]
        //public HTMLCollection Children => GetProperty<HTMLCollection>("children");
        [Export("contentEditable")]
        public string ContentEditable { get => GetProperty<string>("contentEditable"); set => SetProperty<string>("contentEditable", value); }
        //[Export("dataset")]
        //public DOMStringMap Dataset => GetProperty<DOMStringMap>("dataset");
        [Export("dir")]
        public string Dir { get => GetProperty<string>("dir"); set => SetProperty<string>("dir", value); }
        [Export("draggable")]
        public bool Draggable { get => GetProperty<bool>("draggable"); set => SetProperty<bool>("draggable", value); }
        [Export("hidden")]
        public bool Hidden { get => GetProperty<bool>("hidden"); set => SetProperty<bool>("hidden", value); }
        [Export("hideFocus")]
        public bool HideFocus { get => GetProperty<bool>("hideFocus"); set => SetProperty<bool>("hideFocus", value); }
        [Export("innerText")]
        public string InnerText { get => GetProperty<string>("innerText"); set => SetProperty<string>("innerText", value); }
        [Export("isContentEditable")]
        public bool IsContentEditable => GetProperty<bool>("isContentEditable");
        [Export("lang")]
        public string Lang { get => GetProperty<string>("lang"); set => SetProperty<string>("lang", value); }
        [Export("offsetHeight")]
        public double OffsetHeight => GetProperty<double>("offsetHeight");
        [Export("offsetLeft")]
        public double OffsetLeft => GetProperty<double>("offsetLeft");
        [Export("offsetParent")]
        public Element OffsetParent => GetProperty<Element>("offsetParent");
        [Export("offsetTop")]
        public double OffsetTop => GetProperty<double>("offsetTop");
        [Export("offsetWidth")]
        public double OffsetWidth => GetProperty<double>("offsetWidth");
        public event DOMEventHandler OnAbort
        {
            add => AddEventListener("abort", value, false);
            remove => RemoveEventListener("abort", value, false);
        }
        public event DOMEventHandler OnActivate
        {
            add => AddEventListener("activate", value, false);
            remove => RemoveEventListener("activate", value, false);
        }
        public event DOMEventHandler OnBeforeactivate
        {
            add => AddEventListener("beforeactivate", value, false);
            remove => RemoveEventListener("beforeactivate", value, false);
        }
        public event DOMEventHandler OnBeforecopy
        {
            add => AddEventListener("beforecopy", value, false);
            remove => RemoveEventListener("beforecopy", value, false);
        }
        public event DOMEventHandler OnBeforecut
        {
            add => AddEventListener("beforecut", value, false);
            remove => RemoveEventListener("beforecut", value, false);
        }
        public event DOMEventHandler OnBeforedeactivate
        {
            add => AddEventListener("beforedeactivate", value, false);
            remove => RemoveEventListener("beforedeactivate", value, false);
        }
        public event DOMEventHandler OnBeforepaste
        {
            add => AddEventListener("beforepaste", value, false);
            remove => RemoveEventListener("beforepaste", value, false);
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
        public event DOMEventHandler OnContextmenu
        {
            add => AddEventListener("contextmenu", value, false);
            remove => RemoveEventListener("contextmenu", value, false);
        }
        public event DOMEventHandler OnCopy
        {
            add => AddEventListener("copy", value, false);
            remove => RemoveEventListener("copy", value, false);
        }
        public event DOMEventHandler OnCuechange
        {
            add => AddEventListener("cuechange", value, false);
            remove => RemoveEventListener("cuechange", value, false);
        }
        public event DOMEventHandler OnCut
        {
            add => AddEventListener("cut", value, false);
            remove => RemoveEventListener("cut", value, false);
        }
        public event DOMEventHandler OnDblclick
        {
            add => AddEventListener("dblclick", value, false);
            remove => RemoveEventListener("dblclick", value, false);
        }
        public event DOMEventHandler OnDeactivate
        {
            add => AddEventListener("deactivate", value, false);
            remove => RemoveEventListener("deactivate", value, false);
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
        public event DOMEventHandler OnError
        {
            add => AddEventListener("error", value, false);
            remove => RemoveEventListener("error", value, false);
        }
        public event DOMEventHandler OnFocus
        {
            add => AddEventListener("focus", value, false);
            remove => RemoveEventListener("focus", value, false);
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
        public event DOMEventHandler OnLoadeddata
        {
            add => AddEventListener("loadeddata", value, false);
            remove => RemoveEventListener("loadeddata", value, false);
        }
        public event DOMEventHandler OnLoadedmetadata
        {
            add => AddEventListener("loadedmetadata", value, false);
            remove => RemoveEventListener("loadedmetadata", value, false);
        }
        public event DOMEventHandler OnLoadstart
        {
            add => AddEventListener("loadstart", value, false);
            remove => RemoveEventListener("loadstart", value, false);
        }
        public event DOMEventHandler OnMousedown
        {
            add => AddEventListener("mousedown", value, false);
            remove => RemoveEventListener("mousedown", value, false);
        }
        public event DOMEventHandler OnMouseenter
        {
            add => AddEventListener("mouseenter", value, false);
            remove => RemoveEventListener("mouseenter", value, false);
        }
        public event DOMEventHandler OnMouseleave
        {
            add => AddEventListener("mouseleave", value, false);
            remove => RemoveEventListener("mouseleave", value, false);
        }
        public event DOMEventHandler OnMousemove
        {
            add => AddEventListener("mousemove", value, false);
            remove => RemoveEventListener("mousemove", value, false);
        }
        public event DOMEventHandler OnMouseout
        {
            add => AddEventListener("mouseout", value, false);
            remove => RemoveEventListener("mouseout", value, false);
        }
        public event DOMEventHandler OnMouseover
        {
            add => AddEventListener("mouseover", value, false);
            remove => RemoveEventListener("mouseover", value, false);
        }
        public event DOMEventHandler OnMouseup
        {
            add => AddEventListener("mouseup", value, false);
            remove => RemoveEventListener("mouseup", value, false);
        }
        public event DOMEventHandler OnMousewheel
        {
            add => AddEventListener("mousewheel", value, false);
            remove => RemoveEventListener("mousewheel", value, false);
        }
        public event DOMEventHandler OnMscontentzoom
        {
            add => AddEventListener("mscontentzoom", value, false);
            remove => RemoveEventListener("mscontentzoom", value, false);
        }
        public event DOMEventHandler OnMsmanipulationstatechanged
        {
            add => AddEventListener("msmanipulationstatechanged", value, false);
            remove => RemoveEventListener("msmanipulationstatechanged", value, false);
        }
        public event DOMEventHandler OnPaste
        {
            add => AddEventListener("paste", value, false);
            remove => RemoveEventListener("paste", value, false);
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
        public event DOMEventHandler OnProgress
        {
            add => AddEventListener("progress", value, false);
            remove => RemoveEventListener("progress", value, false);
        }
        public event DOMEventHandler OnRatechange
        {
            add => AddEventListener("ratechange", value, false);
            remove => RemoveEventListener("ratechange", value, false);
        }
        public event DOMEventHandler OnReset
        {
            add => AddEventListener("reset", value, false);
            remove => RemoveEventListener("reset", value, false);
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
        public event DOMEventHandler OnSelectstart
        {
            add => AddEventListener("selectstart", value, false);
            remove => RemoveEventListener("selectstart", value, false);
        }
        public event DOMEventHandler OnStalled
        {
            add => AddEventListener("stalled", value, false);
            remove => RemoveEventListener("stalled", value, false);
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
        [Export("outerText")]
        public string OuterText { get => GetProperty<string>("outerText"); set => SetProperty<string>("outerText", value); }
        [Export("spellcheck")]
        public bool Spellcheck { get => GetProperty<bool>("spellcheck"); set => SetProperty<bool>("spellcheck", value); }
        //[Export("style")]
        //public CSSStyleDeclaration Style => GetProperty<CSSStyleDeclaration>("style");
        [Export("tabIndex")]
        public double TabIndex { get => GetProperty<double>("tabIndex"); set => SetProperty<double>("tabIndex", value); }
        [Export("title")]
        public string Title { get => GetProperty<string>("title"); set => SetProperty<string>("title", value); }
        [Export("blur")]
        public void Blur()
        {
            InvokeMethod<object>("blur");
        }
        [Export("click")]
        public void Click()
        {
            InvokeMethod<object>("click");
        }
        [Export("dragDrop")]
        public bool DragDrop()
        {
            return InvokeMethod<bool>("dragDrop");
        }
        [Export("focus")]
        public void Focus()
        {
            InvokeMethod<object>("focus");
        }
        //[Export("msGetInputContext")]
        //public MSInputMethodContext MsGetInputContext()
        //{
        //    return InvokeMethod<MSInputMethodContext>("msGetInputContext");
        //}
    }
}