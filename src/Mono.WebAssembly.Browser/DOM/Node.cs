using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("Node", typeof(Mono.WebAssembly.JSObject))]
    public class Node : EventTarget
    {
        public Node(int handle) : base(handle) { }
        
        protected Node(string globalName) : this(GetGlobal(globalName)) { }

        public Node() { }
        [Export("ATTRIBUTE_NODE")]
        public double AttributeNode => GetProperty<double>("ATTRIBUTE_NODE");
        [Export("CDATA_SECTION_NODE")]
        public double CdataSectionNode => GetProperty<double>("CDATA_SECTION_NODE");
        [Export("COMMENT_NODE")]
        public double CommentNode => GetProperty<double>("COMMENT_NODE");
        [Export("DOCUMENT_FRAGMENT_NODE")]
        public double DocumentFragmentNode => GetProperty<double>("DOCUMENT_FRAGMENT_NODE");
        [Export("DOCUMENT_NODE")]
        public double DocumentNode => GetProperty<double>("DOCUMENT_NODE");
        [Export("DOCUMENT_POSITION_CONTAINED_BY")]
        public double DocumentPositionContainedBy => GetProperty<double>("DOCUMENT_POSITION_CONTAINED_BY");
        [Export("DOCUMENT_POSITION_CONTAINS")]
        public double DocumentPositionContains => GetProperty<double>("DOCUMENT_POSITION_CONTAINS");
        [Export("DOCUMENT_POSITION_DISCONNECTED")]
        public double DocumentPositionDisconnected => GetProperty<double>("DOCUMENT_POSITION_DISCONNECTED");
        [Export("DOCUMENT_POSITION_FOLLOWING")]
        public double DocumentPositionFollowing => GetProperty<double>("DOCUMENT_POSITION_FOLLOWING");
        [Export("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC")]
        public double DocumentPositionImplementationSpecific => GetProperty<double>("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC");
        [Export("DOCUMENT_POSITION_PRECEDING")]
        public double DocumentPositionPreceding => GetProperty<double>("DOCUMENT_POSITION_PRECEDING");
        [Export("DOCUMENT_TYPE_NODE")]
        public double DocumentTypeNode => GetProperty<double>("DOCUMENT_TYPE_NODE");
        [Export("ELEMENT_NODE")]
        public double ElementNode => GetProperty<double>("ELEMENT_NODE");
        [Export("ENTITY_NODE")]
        public double EntityNode => GetProperty<double>("ENTITY_NODE");
        [Export("ENTITY_REFERENCE_NODE")]
        public double EntityReferenceNode => GetProperty<double>("ENTITY_REFERENCE_NODE");
        [Export("NOTATION_NODE")]
        public double NotationNode => GetProperty<double>("NOTATION_NODE");
        [Export("PROCESSING_INSTRUCTION_NODE")]
        public double ProcessingInstructionNode => GetProperty<double>("PROCESSING_INSTRUCTION_NODE");
        [Export("TEXT_NODE")]
        public double TextNode => GetProperty<double>("TEXT_NODE");
        [Export("attributes")]
        public NamedNodeMap Attributes => GetProperty<NamedNodeMap>("attributes");
        [Export("baseURI")]
        public string BaseUri => GetProperty<string>("baseURI");
        [Export("childNodes")]
        public NodeList ChildNodes => GetProperty<NodeList>("childNodes");
        [Export("firstChild")]
        public Node FirstChild => GetProperty<Node>("firstChild");
        [Export("lastChild")]
        public Node LastChild => GetProperty<Node>("lastChild");
        [Export("localName")]
        public string LocalName => GetProperty<string>("localName");
        [Export("namespaceURI")]
        public string NamespaceUri => GetProperty<string>("namespaceURI");
        [Export("nextSibling")]
        public Node NextSibling => GetProperty<Node>("nextSibling");
        [Export("nodeName")]
        public string NodeName => GetProperty<string>("nodeName");
        [Export("nodeType")]
        public double NodeType => GetProperty<double>("nodeType");
        [Export("nodeValue")]
        public string NodeValue { get => GetProperty<string>("nodeValue"); set => SetProperty<string>("nodeValue", value); }
        [Export("ownerDocument")]
        public Document OwnerDocument => GetProperty<Document>("ownerDocument");
        [Export("parentElement")]
        public HTMLElement ParentElement => GetProperty<HTMLElement>("parentElement");
        [Export("parentNode")]
        public Node ParentNode => GetProperty<Node>("parentNode");
        [Export("previousSibling")]
        public Node PreviousSibling => GetProperty<Node>("previousSibling");
        [Export("textContent")]
        public string TextContent { get => GetProperty<string>("textContent"); set => SetProperty<string>("textContent", value); }
        [Export("appendChild")]
        public T AppendChild<T>(T newChild) where T : Node
        {
            return InvokeMethod<T>("appendChild", newChild);
        }
        [Export("cloneNode")]
        public Node CloneNode(bool deep)
        {
            return InvokeMethod<Node>("cloneNode", deep);
        }
        [Export("compareDocumentPosition")]
        public double CompareDocumentPosition(Node other)
        {
            return InvokeMethod<double>("compareDocumentPosition", other);
        }
        [Export("contains")]
        public bool Contains(Node child)
        {
            return InvokeMethod<bool>("contains", child);
        }
        [Export("hasAttributes")]
        public bool HasAttributes()
        {
            return InvokeMethod<bool>("hasAttributes");
        }
        [Export("hasChildNodes")]
        public bool HasChildNodes()
        {
            return InvokeMethod<bool>("hasChildNodes");
        }

        [Export("insertBefore")]
        public T InsertBefore<T>(T newChild, Node refChild) where T : Node
        {
            return InvokeMethod<T>("insertBefore", newChild, refChild);
        }

        [Export("isDefaultNamespace")]
        public bool IsDefaultNamespace(string namespaceURI)
        {
            return InvokeMethod<bool>("isDefaultNamespace", namespaceURI);
        }
        [Export("isEqualNode")]
        public bool IsEqualNode(Node arg)
        {
            return InvokeMethod<bool>("isEqualNode", arg);
        }
        [Export("isSameNode")]
        public bool IsSameNode(Node other)
        {
            return InvokeMethod<bool>("isSameNode", other);
        }
        [Export("lookupNamespaceURI")]
        public string LookupNamespaceUri(string prefix)
        {
            return InvokeMethod<string>("lookupNamespaceURI", prefix);
        }
        [Export("lookupPrefix")]
        public string LookupPrefix(string namespaceURI)
        {
            return InvokeMethod<string>("lookupPrefix", namespaceURI);
        }
        [Export("normalize")]
        public void Normalize()
        {
            InvokeMethod<object>("normalize");
        }

        [Export("removeChild")]
        public T RemoveChild<T>(T oldChild) where T : Node
        {
            return InvokeMethod<T>("removeChild", oldChild);
        }
        [Export("replaceChild")]
        public T ReplaceChild<T>(T newChild, Node oldChile) where T : Node
        {
            return InvokeMethod<T>("replaceChild", newChild, oldChile);
        }
        [Export("toString")]
        public override string ToString()
        {
            return InvokeMethod<string>("toString");
        }
    }

}