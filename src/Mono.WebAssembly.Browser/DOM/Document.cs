using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("Document", typeof(Mono.WebAssembly.JSObject))]
    public sealed partial class Document : Node
    {
        internal Document(int handle) : base(handle) { }

        public Document() : base("document") { }

        [Export("activeElement")]
        public Element ActiveElement => GetProperty<Element>("activeElement");
        [Export("alinkColor")]
        public string AlinkColor { get => GetProperty<string>("alinkColor"); set => SetProperty<string>("alinkColor", value); }
        // [Export("all")]
        // public HTMLAllCollection All => GetProperty<HTMLAllCollection>("all");
        [Export("anchors")]
        public HTMLCollectionOf<HTMLAnchorElement> Anchors { get => GetProperty<HTMLCollectionOf<HTMLAnchorElement>>("anchors"); set => SetProperty<HTMLCollectionOf<HTMLAnchorElement>>("anchors", value); }
        // [Export("applets")]
        // public HTMLCollectionOf<HTMLAppletElement> Applets { get => GetProperty<HTMLCollectionOf<HTMLAppletElement>>("applets"); set => SetProperty<HTMLCollectionOf<HTMLAppletElement>>("applets", value); }
        /**
         * Deprecated. Sets or retrieves a value that indicates the background color behind the object.
         */
        // [Export("bgColor")]
        // public string BgColor { get => GetProperty<string>("bgColor"); set => SetProperty<string>("bgColor", value); }
        [Export("body")]
        public HTMLElement Body { get => GetProperty<HTMLElement>("body"); set => SetProperty<HTMLElement>("body", value); }
        [Export("characterSet")]
        public string CharacterSet => GetProperty<string>("characterSet");
        [Export("charset")]
        public string Charset { get => GetProperty<string>("charset"); set => SetProperty<string>("charset", value); }
        [Export("compatMode")]
        public string CompatMode => GetProperty<string>("compatMode");
        [Export("cookie")]
        public string Cookie { get => GetProperty<string>("cookie"); set => SetProperty<string>("cookie", value); }
        [Export("currentScript")]
        public object CurrentScript => GetProperty<object>("currentScript");
        [Export("defaultView")]
        public Window DefaultView => GetProperty<Window>("defaultView");
        [Export("designMode")]
        public string DesignMode { get => GetProperty<string>("designMode"); set => SetProperty<string>("designMode", value); }
        [Export("dir")]
        public string Dir { get => GetProperty<string>("dir"); set => SetProperty<string>("dir", value); }
        [Export("doctype")]
        public DocumentType Doctype => GetProperty<DocumentType>("doctype");
        [Export("documentElement")]
        public HTMLElement DocumentElement { get => GetProperty<HTMLElement>("documentElement"); set => SetProperty<HTMLElement>("documentElement", value); }
        [Export("domain")]
        public string Domain { get => GetProperty<string>("domain"); set => SetProperty<string>("domain", value); }
        // [Export("embeds")]
        // public HTMLCollectionOf<HTMLEmbedElement> Embeds { get => GetProperty<HTMLCollectionOf<HTMLEmbedElement>>("embeds"); set => SetProperty<HTMLCollectionOf<HTMLEmbedElement>>("embeds", value); }
        [Export("fgColor")]
        public string FgColor { get => GetProperty<string>("fgColor"); set => SetProperty<string>("fgColor", value); }
        [Export("forms")]
        public HTMLCollectionOf<HTMLFormElement> Forms { get => GetProperty<HTMLCollectionOf<HTMLFormElement>>("forms"); set => SetProperty<HTMLCollectionOf<HTMLFormElement>>("forms", value); }
        [Export("fullscreenElement")]
        public Element FullscreenElement => GetProperty<Element>("fullscreenElement");
        [Export("fullscreenEnabled")]
        public bool FullscreenEnabled => GetProperty<bool>("fullscreenEnabled");
        [Export("head")]
        public HTMLHeadElement Head => GetProperty<HTMLHeadElement>("head");
        [Export("hidden")]
        public bool Hidden => GetProperty<bool>("hidden");
        // [Export("images")]
        // public HTMLCollectionOf<HTMLImageElement> Images { get => GetProperty<HTMLCollectionOf<HTMLImageElement>>("images"); set => SetProperty<HTMLCollectionOf<HTMLImageElement>>("images", value); }
        // [Export("implementation")]
        // public DOMImplementation Implementation => GetProperty<DOMImplementation>("implementation");
        [Export("inputEncoding")]
        public string InputEncoding => GetProperty<string>("inputEncoding");
        [Export("lastModified")]
        public string LastModified => GetProperty<string>("lastModified");
        [Export("linkColor")]
        public string LinkColor { get => GetProperty<string>("linkColor"); set => SetProperty<string>("linkColor", value); }
        //[Export("links")]
        //public HTMLCollectionOf<HTMLAnchorElement | HTMLAreaElement> Links { get => GetProperty < HTMLCollectionOf < HTMLAnchorElement | HTMLAreaElement >> ("links"); set => SetProperty < HTMLCollectionOf < HTMLAnchorElement | HTMLAreaElement >> ("links", value); }
        [Export("location")]
        public Location Location => GetProperty<Location>("location");
        [Export("msCapsLockWarningOff")]
        public bool MsCapsLockWarningOff { get => GetProperty<bool>("msCapsLockWarningOff"); set => SetProperty<bool>("msCapsLockWarningOff", value); }
        [Export("msCSSOMElementFloatMetrics")]
        public bool MsCssomElementFloatMetrics { get => GetProperty<bool>("msCSSOMElementFloatMetrics"); set => SetProperty<bool>("msCSSOMElementFloatMetrics", value); }
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
        public event DOMEventHandler OnBeforedeactivate
        {
            add => AddEventListener("beforedeactivate", value, false);
            remove => RemoveEventListener("beforedeactivate", value, false);
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
        public event DOMEventHandler OnDragEnd
        {
            add => AddEventListener("dragend", value, false);
            remove => RemoveEventListener("dragend", value, false);
        }
        public event DOMEventHandler OnDragEnter
        {
            add => AddEventListener("dragenter", value, false);
            remove => RemoveEventListener("dragenter", value, false);
        }
        public event DOMEventHandler OnDragLeave
        {
            add => AddEventListener("dragleave", value, false);
            remove => RemoveEventListener("dragleave", value, false);
        }
        public event DOMEventHandler OnDragOver
        {
            add => AddEventListener("dragover", value, false);
            remove => RemoveEventListener("dragover", value, false);
        }
        public event DOMEventHandler OnDragStart
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
        public event DOMEventHandler OnFullscreenchange
        {
            add => AddEventListener("fullscreenchange", value, false);
            remove => RemoveEventListener("fullscreenchange", value, false);
        }
        public event DOMEventHandler OnFullscreenerror
        {
            add => AddEventListener("fullscreenerror", value, false);
            remove => RemoveEventListener("fullscreenerror", value, false);
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
        public event DOMEventHandler OnMsgesturechange
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
        public event DOMEventHandler OnMsmanipulationstatechanged
        {
            add => AddEventListener("msmanipulationstatechanged", value, false);
            remove => RemoveEventListener("msmanipulationstatechanged", value, false);
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
        public event DOMEventHandler OnMssitemodejumplistitemremoved
        {
            add => AddEventListener("mssitemodejumplistitemremoved", value, false);
            remove => RemoveEventListener("mssitemodejumplistitemremoved", value, false);
        }
        public event DOMEventHandler OnMsthumbnailclick
        {
            add => AddEventListener("msthumbnailclick", value, false);
            remove => RemoveEventListener("msthumbnailclick", value, false);
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
        public event DOMEventHandler OnPointerlockchange
        {
            add => AddEventListener("pointerlockchange", value, false);
            remove => RemoveEventListener("pointerlockchange", value, false);
        }
        public event DOMEventHandler OnPointerlockerror
        {
            add => AddEventListener("pointerlockerror", value, false);
            remove => RemoveEventListener("pointerlockerror", value, false);
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
        public event DOMEventHandler OnReadystatechange
        {
            add => AddEventListener("readystatechange", value, false);
            remove => RemoveEventListener("readystatechange", value, false);
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
        public event DOMEventHandler OnSelectionchange
        {
            add => AddEventListener("selectionchange", value, false);
            remove => RemoveEventListener("selectionchange", value, false);
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
        public event DOMEventHandler OnStop
        {
            add => AddEventListener("stop", value, false);
            remove => RemoveEventListener("stop", value, false);
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
        public event DOMEventHandler OnWebkitfullscreenchange
        {
            add => AddEventListener("webkitfullscreenchange", value, false);
            remove => RemoveEventListener("webkitfullscreenchange", value, false);
        }
        public event DOMEventHandler OnWebkitfullscreenerror
        {
            add => AddEventListener("webkitfullscreenerror", value, false);
            remove => RemoveEventListener("webkitfullscreenerror", value, false);
        }
        // [Export("plugins")]
        // public HTMLCollectionOf<HTMLEmbedElement> Plugins { get => GetProperty<HTMLCollectionOf<HTMLEmbedElement>>("plugins"); set => SetProperty<HTMLCollectionOf<HTMLEmbedElement>>("plugins", value); }
        [Export("pointerLockElement")]
        public Element PointerLockElement => GetProperty<Element>("pointerLockElement");
        [Export("readyState")]
        public string ReadyState => GetProperty<string>("readyState");
        [Export("referrer")]
        public string Referrer => GetProperty<string>("referrer");
        // [Export("rootElement")]
        // public SVGSVGElement RootElement => GetProperty<SVGSVGElement>("rootElement");
        // [Export("scripts")]
        // public HTMLCollectionOf<HTMLScriptElement> Scripts { get => GetProperty<HTMLCollectionOf<HTMLScriptElement>>("scripts"); set => SetProperty<HTMLCollectionOf<HTMLScriptElement>>("scripts", value); }
        [Export("scrollingElement")]
        public Element ScrollingElement => GetProperty<Element>("scrollingElement");
        // [Export("styleSheets")]
        // public StyleSheetList StyleSheets => GetProperty<StyleSheetList>("styleSheets");
        [Export("title")]
        public string Title { get => GetProperty<string>("title"); set => SetProperty<string>("title", value); }
        [Export("URL")]
        public string Url => GetProperty<string>("URL");
        [Export("URLUnencoded")]
        public string UrlUnencoded => GetProperty<string>("URLUnencoded");
        [Export("visibilityState")]
        public VisibilityState VisibilityState => GetProperty<VisibilityState>("visibilityState");
        [Export("vlinkColor")]
        public string VlinkColor { get => GetProperty<string>("vlinkColor"); set => SetProperty<string>("vlinkColor", value); }
        [Export("webkitCurrentFullScreenElement")]
        public Element WebkitCurrentFullScreenElement => GetProperty<Element>("webkitCurrentFullScreenElement");
        [Export("webkitFullscreenElement")]
        public Element WebkitFullscreenElement => GetProperty<Element>("webkitFullscreenElement");
        [Export("webkitFullscreenEnabled")]
        public bool WebkitFullscreenEnabled => GetProperty<bool>("webkitFullscreenEnabled");
        [Export("webkitIsFullScreen")]
        public bool WebkitIsFullScreen => GetProperty<bool>("webkitIsFullScreen");
        [Export("xmlEncoding")]
        public string XmlEncoding => GetProperty<string>("xmlEncoding");
        [Export("xmlStandalone")]
        public bool XmlStandalone { get => GetProperty<bool>("xmlStandalone"); set => SetProperty<bool>("xmlStandalone", value); }
        [Export("xmlVersion")]
        public string XmlVersion { get => GetProperty<string>("xmlVersion"); set => SetProperty<string>("xmlVersion", value); }
        //[Export("ownerDocument")]
        //public Document OwnerDocument => GetProperty<Document>("ownerDocument");
        [Export("parentElement")]
        public new HTMLElement ParentElement => GetProperty<HTMLElement>("parentElement");
        [Export("parentNode")]
        public Node IParentNode => GetProperty<Node>("parentNode");
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
        [Export("children")]
        public HTMLCollection Children => GetProperty<HTMLCollection>("children");
        [Export("firstElementChild")]
        public Element FirstElementChild => GetProperty<Element>("firstElementChild");
        [Export("lastElementChild")]
        public Element LastElementChild => GetProperty<Element>("lastElementChild");
        [Export("childElementCount")]
        public double ChildElementCount => GetProperty<double>("childElementCount");
        // [Export("stylesheets")]
        // public StyleSheetList Stylesheets => GetProperty<StyleSheetList>("stylesheets");
        [Export("captureEvents")]
        public void CaptureEvents()
        {
            InvokeMethod<object>("captureEvents");
        }
        // [Export("caretRangeFromPoint")]
        // public Range CaretRangeFromPoint(double x, double y)
        // {
        //     return InvokeMethod<Range>("caretRangeFromPoint", x, y);
        // }
        [Export("clear")]
        public void Clear()
        {
            InvokeMethod<object>("clear");
        }
        [Export("close")]
        public void Close()
        {
            InvokeMethod<object>("close");
        }
        [Export("createAttribute")]
        public Attr CreateAttribute(string name)
        {
            return InvokeMethod<Attr>("createAttribute", name);
        }
        [Export("createAttributeNS")]
        public Attr CreateAttributeNs(string namespaceURI, string qualifiedName)
        {
            return InvokeMethod<Attr>("createAttributeNS", namespaceURI, qualifiedName);
        }
        [Export("createCDATASection")]
        public CDATASection CreateCdataSection(string data)
        {
            return InvokeMethod<CDATASection>("createCDATASection", data);
        }
        [Export("createComment")]
        public Comment CreateComment(string data)
        {
            return InvokeMethod<Comment>("createComment", data);
        }
        [Export("createDocumentFragment")]
        public DocumentFragment CreateDocumentFragment()
        {
            return InvokeMethod<DocumentFragment>("createDocumentFragment");
        }
        [Export("createElementNS")]
        public HTMLElement CreateElementNs(string namespaceURI, string qualifiedName)
        {
            return InvokeMethod<HTMLElement>("createElementNS", namespaceURI, qualifiedName);
        }

        // [Export("createExpression")]
        // public XPathExpression CreateExpression(string expression, XPathNSResolver resolver)
        // {
        //     return InvokeMethod<XPathExpression>("createExpression", expression, resolver);
        // }
        // [Export("createNodeIterator")]
        // public NodeIterator CreateNodeIterator(INode root, double whatToShow, NodeFilter filter, bool entityReferenceExpansion)
        // {
        //     return InvokeMethod<NodeIterator>("createNodeIterator", root, whatToShow, filter, entityReferenceExpansion);
        // }
        // [Export("createNSResolver")]
        // public XPathNSResolver CreateNsResolver(INode nodeResolver)
        // {
        //     return InvokeMethod<XPathNSResolver>("createNSResolver", nodeResolver);
        // }
        // [Export("createProcessingInstruction")]
        // public ProcessingInstruction CreateProcessingInstruction(string target, string data)
        // {
        //     return InvokeMethod<ProcessingInstruction>("createProcessingInstruction", target, data);
        // }
        // [Export("createRange")]
        // public Range CreateRange()
        // {
        //     return InvokeMethod<Range>("createRange");
        // }
         [Export("createTextNode")]
         public Text CreateTextNode(string data)
         {
             return InvokeMethod<Text>("createTextNode", data);
         }
        // [Export("createTouch")]
        // public Touch CreateTouch(Window view, EventTarget target, double identifier, double pageX, double pageY, double screenX, double screenY)
        // {
        //     return InvokeMethod<Touch>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY);
        // }
        // [Export("createTouchList")]
        // public TouchList CreateTouchList(params Touch[] touches)
        // {
        //     return InvokeMethod<TouchList>("createTouchList", touches);
        // }
        // [Export("createTreeWalker")]
        // public TreeWalker CreateTreeWalker(INode root, double whatToShow, NodeFilter filter, bool entityReferenceExpansion)
        // {
        //     return InvokeMethod<TreeWalker>("createTreeWalker", root, whatToShow, filter, entityReferenceExpansion);
        // }
        [Export("elementFromPoint")]
        public Element ElementFromPoint(double x, double y)
        {
            return InvokeMethod<Element>("elementFromPoint", x, y);
        }
        // [Export("evaluate")]
        // public XPathResult Evaluate(string expression, INode contextNode, XPathNSResolver resolver, double type, XPathResult result)
        // {
        //     return InvokeMethod<XPathResult>("evaluate", expression, contextNode, resolver, type, result);
        // }
        [Export("execCommand")]
        public bool ExecCommand(string commandId, bool showUI, Object value)
        {
            return InvokeMethod<bool>("execCommand", commandId, showUI, value);
        }
        [Export("execCommandShowHelp")]
        public bool ExecCommandShowHelp(string commandId)
        {
            return InvokeMethod<bool>("execCommandShowHelp", commandId);
        }
        [Export("exitFullscreen")]
        public void ExitFullscreen()
        {
            InvokeMethod<object>("exitFullscreen");
        }
        [Export("exitPointerLock")]
        public void ExitPointerLock()
        {
            InvokeMethod<object>("exitPointerLock");
        }
        [Export("focus")]
        public void Focus()
        {
            InvokeMethod<object>("focus");
        }
         [Export("getElementById")]
         public HTMLElement GetElementById(string elementId)
         {
             return InvokeMethod<HTMLElement>("getElementById", elementId);
         }
         [Export("getElementsByClassName")]
         public HTMLCollectionOf<Element> GetElementsByClassName(string classNames)
         {
             return InvokeMethod<HTMLCollectionOf<Element>>("getElementsByClassName", classNames);
         }
         [Export("getElementsByName")]
         public NodeListOf<HTMLElement> GetElementsByName(string elementName)
         {
             return InvokeMethod<NodeListOf<HTMLElement>>("getElementsByName", elementName);
         }
        [Export("getElementsByTagNameNS")]
        public HTMLCollectionOf<HTMLElement> GetElementsByTagNameNs(string namespaceURI, string localName)
        {
            return InvokeMethod<HTMLCollectionOf<HTMLElement>>("getElementsByTagNameNS", namespaceURI, localName);
        }
        [Export("getElementsByTagName")]
        public NodeListOf<Element> GetElementsByTagName(string name)
        {
            return InvokeMethod<NodeListOf<Element>>("getElementsByTagName", name);
        }
        [Export("querySelectorAll")]
        public NodeListOf<T> QuerySelectorAll<T>(string selectors)
        {
            return InvokeMethod<NodeListOf<T>>("querySelectorAll", selectors);
        }

        [Export("querySelectorAll")]
        public NodeListOf<Element> QuerySelectorAll(string selectors)
        {
            return InvokeMethod<NodeListOf<Element>>("querySelectorAll", selectors);
        }
        [Export("querySelector")]
        public T QuerySelector<T>(string selectors)
        {
            return InvokeMethod<T>("querySelector", selectors);
        }
        [Export("querySelector")]
        public Element QuerySelector(string selectors)
        {
            return InvokeMethod<Element>("querySelector", selectors);
        }
        // [Export("getSelection")]
        // public Selection GetSelection()
        // {
        //     return InvokeMethod<Selection>("getSelection");
        // }
        [Export("hasFocus")]
        public bool HasFocus()
        {
            return InvokeMethod<bool>("hasFocus");
        }
        [Export("importNode")]
        public T ImportNode<T>(T importedNode, bool deep) where T : Node
        {
            return InvokeMethod<T>("importNode", importedNode, deep);
        }
         [Export("msElementsFromPoint")]
         public NodeListOf<Element> MsElementsFromPoint(double x, double y)
         {
             return InvokeMethod<NodeListOf<Element>>("msElementsFromPoint", x, y);
         }
         [Export("msElementsFromRect")]
         public NodeListOf<Element> MsElementsFromRect(double left, double top, double width, double height)
         {
             return InvokeMethod<NodeListOf<Element>>("msElementsFromRect", left, top, width, height);
         }
        [Export("open")]
        public Document Open(string url, string name, string features, bool replace)
        {
            return InvokeMethod<Document>("open", url, name, features, replace);
        }
        [Export("queryCommandEnabled")]
        public bool QueryCommandEnabled(string commandId)
        {
            return InvokeMethod<bool>("queryCommandEnabled", commandId);
        }
        [Export("queryCommandIndeterm")]
        public bool QueryCommandIndeterm(string commandId)
        {
            return InvokeMethod<bool>("queryCommandIndeterm", commandId);
        }
        [Export("queryCommandState")]
        public bool QueryCommandState(string commandId)
        {
            return InvokeMethod<bool>("queryCommandState", commandId);
        }
        [Export("queryCommandSupported")]
        public bool QueryCommandSupported(string commandId)
        {
            return InvokeMethod<bool>("queryCommandSupported", commandId);
        }
        [Export("queryCommandText")]
        public string QueryCommandText(string commandId)
        {
            return InvokeMethod<string>("queryCommandText", commandId);
        }
        [Export("queryCommandValue")]
        public string QueryCommandValue(string commandId)
        {
            return InvokeMethod<string>("queryCommandValue", commandId);
        }
        [Export("releaseEvents")]
        public void ReleaseEvents()
        {
            InvokeMethod<object>("releaseEvents");
        }
        [Export("updateSettings")]
        public void UpdateSettings()
        {
            InvokeMethod<object>("updateSettings");
        }
        [Export("webkitCancelFullScreen")]
        public void WebkitCancelFullScreen()
        {
            InvokeMethod<object>("webkitCancelFullScreen");
        }
        [Export("webkitExitFullscreen")]
        public void WebkitExitFullscreen()
        {
            InvokeMethod<object>("webkitExitFullscreen");
        }
        [Export("write")]
        public void Write(params string[] content)
        {
            InvokeMethod<object>("write", content);
        }
        [Export("writeln")]
        public void Writeln(params string[] content)
        {
            InvokeMethod<object>("writeln", content);
        }
        [Export("elementsFromPoint")]
        public Element[] ElementsFromPoint(double x, double y)
        {
            return InvokeMethod<Element[]>("elementsFromPoint", x, y);
        }
    }
}