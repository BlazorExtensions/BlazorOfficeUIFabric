using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

    [Export("Element", typeof(Mono.WebAssembly.JSObject))]
    public partial class Element : Node
    {
        public Element(int handle) : base(handle) { }

        public Element() { }
        [Export("classList")]
        public DOMTokenList ClassList => GetProperty<DOMTokenList>("classList");
        [Export("className")]
        public string ClassName { get => GetProperty<string>("className"); set => SetProperty<string>("className", value); }
        [Export("clientHeight")]
        public double ClientHeight => GetProperty<double>("clientHeight");
        [Export("clientLeft")]
        public double ClientLeft => GetProperty<double>("clientLeft");
        [Export("clientTop")]
        public double ClientTop => GetProperty<double>("clientTop");
        [Export("clientWidth")]
        public double ClientWidth => GetProperty<double>("clientWidth");
        [Export("id")]
        public string Id { get => GetProperty<string>("id"); set => SetProperty<string>("id", value); }
        [Export("innerHTML")]
        public string InnerHtml { get => GetProperty<string>("innerHTML"); set => SetProperty<string>("innerHTML", value); }
        [Export("msContentZoomFactor")]
        public double MsContentZoomFactor { get => GetProperty<double>("msContentZoomFactor"); set => SetProperty<double>("msContentZoomFactor", value); }
        [Export("msRegionOverflow")]
        public string MsRegionOverflow => GetProperty<string>("msRegionOverflow");
        public event DOMEventHandler OnAriarequest
        {
            add => AddEventListener("ariarequest", value, false);
            remove => RemoveEventListener("ariarequest", value, false);
        }
        public event DOMEventHandler OnCommand
        {
            add => AddEventListener("command", value, false);
            remove => RemoveEventListener("command", value, false);
        }
        public event DOMEventHandler OnGotpointercapture
        {
            add => AddEventListener("gotpointercapture", value, false);
            remove => RemoveEventListener("gotpointercapture", value, false);
        }
        public event DOMEventHandler OnLostpointercapture
        {
            add => AddEventListener("lostpointercapture", value, false);
            remove => RemoveEventListener("lostpointercapture", value, false);
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
        public event DOMEventHandler OnMsgotpointercapture
        {
            add => AddEventListener("msgotpointercapture", value, false);
            remove => RemoveEventListener("msgotpointercapture", value, false);
        }
        public event DOMEventHandler OnMsinertiastart
        {
            add => AddEventListener("msinertiastart", value, false);
            remove => RemoveEventListener("msinertiastart", value, false);
        }
        public event DOMEventHandler OnMslostpointercapture
        {
            add => AddEventListener("mslostpointercapture", value, false);
            remove => RemoveEventListener("mslostpointercapture", value, false);
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
        [Export("ontouchcancel")]
        public Action Ontouchcancel { get => GetProperty<Action>("ontouchcancel"); set => SetProperty<Action>("ontouchcancel", value); }
        [Export("ontouchend")]
        public Action Ontouchend { get => GetProperty<Action>("ontouchend"); set => SetProperty<Action>("ontouchend", value); }
        [Export("ontouchmove")]
        public Action Ontouchmove { get => GetProperty<Action>("ontouchmove"); set => SetProperty<Action>("ontouchmove", value); }
        [Export("ontouchstart")]
        public Action Ontouchstart { get => GetProperty<Action>("ontouchstart"); set => SetProperty<Action>("ontouchstart", value); }
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
        [Export("outerHTML")]
        public string OuterHtml { get => GetProperty<string>("outerHTML"); set => SetProperty<string>("outerHTML", value); }
        [Export("prefix")]
        public string Prefix => GetProperty<string>("prefix");
        [Export("scrollHeight")]
        public double ScrollHeight => GetProperty<double>("scrollHeight");
        [Export("scrollLeft")]
        public double ScrollLeft { get => GetProperty<double>("scrollLeft"); set => SetProperty<double>("scrollLeft", value); }
        [Export("scrollTop")]
        public double ScrollTop { get => GetProperty<double>("scrollTop"); set => SetProperty<double>("scrollTop", value); }
        [Export("scrollWidth")]
        public double ScrollWidth => GetProperty<double>("scrollWidth");
        [Export("tagName")]
        public string TagName => GetProperty<string>("tagName");
        //[Export("assignedSlot")]
        //public HTMLSlotElement AssignedSlot => GetProperty<HTMLSlotElement>("assignedSlot");
        [Export("slot")]
        public string Slot { get => GetProperty<string>("slot"); set => SetProperty<string>("slot", value); }
        //[Export("shadowRoot")]
        //public ShadowRoot ShadowRoot => GetProperty<ShadowRoot>("shadowRoot");
        //[Export("parentElement")]
        //public HTMLElement ParentElement => GetProperty<HTMLElement>("parentElement");
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
        [Export("childElementCount")]
        public double ChildElementCount => GetProperty<double>("childElementCount");
        [Export("firstElementChild")]
        public Element FirstElementChild => GetProperty<Element>("firstElementChild");
        [Export("lastElementChild")]
        public Element LastElementChild => GetProperty<Element>("lastElementChild");
        [Export("nextElementSibling")]
        public Element NextElementSibling => GetProperty<Element>("nextElementSibling");
        [Export("previousElementSibling")]
        public Element PreviousElementSibling => GetProperty<Element>("previousElementSibling");
        [Export("children")]
        public HTMLCollection Children => GetProperty<HTMLCollection>("children");
        [Export("getAttributeNode")]
        public Attr GetAttributeNode(string name)
        {
            return InvokeMethod<Attr>("getAttributeNode", name);
        }
        [Export("getAttributeNodeNS")]
        public Attr GetAttributeNodeNs(string namespaceURI, string localName)
        {
            return InvokeMethod<Attr>("getAttributeNodeNS", namespaceURI, localName);
        }
        [Export("getAttributeNS")]
        public string GetAttributeNs(string namespaceURI, string localName)
        {
            return InvokeMethod<string>("getAttributeNS", namespaceURI, localName);
        }
        [Export("getBoundingClientRect")]
        public object GetBoundingClientRect()
        {
            return InvokeMethod<object>("getBoundingClientRect");
        }
        [Export("getClientRects")]
        public object GetClientRects()
        {
            return InvokeMethod<object>("getClientRects");
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
        public NodeListOf<Element> QuerySelectorAll(string selectors)
        {
            return InvokeMethod<NodeListOf<Element>>("querySelectorAll", selectors);
        }
        [Export("querySelector")]
        public Element QuerySelector(string selectors)
        {
            return InvokeMethod<Element>("querySelector", selectors);
        }
        [Export("hasAttribute")]
        public bool HasAttribute(string name)
        {
            return InvokeMethod<bool>("hasAttribute", name);
        }
        [Export("hasAttributeNS")]
        public bool HasAttributeNs(string namespaceURI, string localName)
        {
            return InvokeMethod<bool>("hasAttributeNS", namespaceURI, localName);
        }
        //[Export("msGetRegionContent")]
        //public MSRangeCollection MsGetRegionContent()
        //{
        //    return InvokeMethod<MSRangeCollection>("msGetRegionContent");
        //}
        //[Export("msGetUntransformedBounds")]
        //public ClientRect MsGetUntransformedBounds()
        //{
        //    return InvokeMethod<ClientRect>("msGetUntransformedBounds");
        //}
        [Export("msMatchesSelector")]
        public bool MsMatchesSelector(string selectors)
        {
            return InvokeMethod<bool>("msMatchesSelector", selectors);
        }
        [Export("msReleasePointerCapture")]
        public void MsReleasePointerCapture(double pointerId)
        {
            InvokeMethod<object>("msReleasePointerCapture", pointerId);
        }
        [Export("msSetPointerCapture")]
        public void MsSetPointerCapture(double pointerId)
        {
            InvokeMethod<object>("msSetPointerCapture", pointerId);
        }
        //[Export("msZoomTo")]
        //public void MsZoomTo(MsZoomToOptions args)
        //{
        //    InvokeMethod<object>("msZoomTo", args);
        //}
        [Export("releasePointerCapture")]
        public void ReleasePointerCapture(double pointerId)
        {
            InvokeMethod<object>("releasePointerCapture", pointerId);
        }
        [Export("removeAttributeNode")]
        public Attr RemoveAttributeNode(Attr oldAttr)
        {
            return InvokeMethod<Attr>("removeAttributeNode", oldAttr);
        }
        [Export("removeAttributeNS")]
        public void RemoveAttributeNs(string namespaceURI, string localName)
        {
            InvokeMethod<object>("removeAttributeNS", namespaceURI, localName);
        }
        [Export("requestFullscreen")]
        public void RequestFullscreen()
        {
            InvokeMethod<object>("requestFullscreen");
        }
        [Export("requestPointerLock")]
        public void RequestPointerLock()
        {
            InvokeMethod<object>("requestPointerLock");
        }
        [Export("setAttributeNode")]
        public Attr SetAttributeNode(Attr newAttr)
        {
            return InvokeMethod<Attr>("setAttributeNode", newAttr);
        }
        [Export("setAttributeNodeNS")]
        public Attr SetAttributeNodeNs(Attr newAttr)
        {
            return InvokeMethod<Attr>("setAttributeNodeNS", newAttr);
        }
        [Export("setAttributeNS")]
        public void SetAttributeNs(string namespaceURI, string qualifiedName, string value)
        {
            InvokeMethod<object>("setAttributeNS", namespaceURI, qualifiedName, value);
        }
        [Export("setPointerCapture")]
        public void SetPointerCapture(double pointerId)
        {
            InvokeMethod<object>("setPointerCapture", pointerId);
        }
        [Export("webkitMatchesSelector")]
        public bool WebkitMatchesSelector(string selectors)
        {
            return InvokeMethod<bool>("webkitMatchesSelector", selectors);
        }
        [Export("webkitRequestFullscreen")]
        public void WebkitRequestFullscreen()
        {
            InvokeMethod<object>("webkitRequestFullscreen");
        }
        [Export("webkitRequestFullScreen")]
        public void WebkitRequestFullScreen()
        {
            InvokeMethod<object>("webkitRequestFullScreen");
        }
        [Export("getElementsByClassName")]
        public NodeListOf<Element> GetElementsByClassName(string classNames)
        {
            return InvokeMethod<NodeListOf<Element>>("getElementsByClassName", classNames);
        }
        [Export("matches")]
        public bool Matches(string selector)
        {
            return InvokeMethod<bool>("matches", selector);
        }
        [Export("closest")]
        public Element Closest(string selector)
        {
            return InvokeMethod<Element>("closest", selector);
        }
        //[Export("scrollIntoView")]
        //public void ScrollIntoView(object arg)
        //{
        //    InvokeMethod<object>("scrollIntoView", arg);
        //}
        //[Export("scroll")]
        //public void Scroll(ScrollToOptions options)
        //{
        //    InvokeMethod<object>("scroll", options);
        //}
        //[Export("scrollTo")]
        //public void ScrollTo(ScrollToOptions options)
        //{
        //    InvokeMethod<object>("scrollTo", options);
        //}
        //[Export("scrollBy")]
        //public void ScrollBy(ScrollToOptions options)
        //{
        //    InvokeMethod<object>("scrollBy", options);
        //}
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
        [Export("insertAdjacentElement")]
        public Element InsertAdjacentElement(InsertPosition position, Element insertedElement)
        {
            return InvokeMethod<Element>("insertAdjacentElement", position, insertedElement);
        }
        [Export("insertAdjacentHTML")]
        public void InsertAdjacentHtml(InsertPosition where, string html)
        {
            InvokeMethod<object>("insertAdjacentHTML", where, html);
        }
        [Export("insertAdjacentText")]
        public void InsertAdjacentText(InsertPosition where, string text)
        {
            InvokeMethod<object>("insertAdjacentText", where, text);
        }
        //[Export("attachShadow")]
        //public ShadowRoot AttachShadow(ShadowRootInit shadowRootInitDict)
        //{
        //    return InvokeMethod<ShadowRoot>("attachShadow", shadowRootInitDict);
        //}
        [Export("remove")]
        public void Remove()
        {
            InvokeMethod<object>("remove");
        }

    }


}