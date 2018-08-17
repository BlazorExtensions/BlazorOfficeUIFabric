using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{


[Export("HTMLEmbedElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLEmbedElement : HTMLElement, IHTMLEmbedElement {
    internal HTMLEmbedElement  (int handle) : base (handle) {}

    //public HTMLEmbedElement () { }
    [Export("height")]
    public string Height { get => GetProperty<string>("height"); set => SetProperty<string>("height", value); }
    //[Export("hidden")]
    //public Object Hidden { get => GetProperty<Object>("hidden"); set => SetProperty<Object>("hidden", value); }
    [Export("msPlayToDisabled")]
    public bool MsPlayToDisabled { get => GetProperty<bool>("msPlayToDisabled"); set => SetProperty<bool>("msPlayToDisabled", value); }
    [Export("msPlayToPreferredSourceUri")]
    public string MsPlayToPreferredSourceUri { get => GetProperty<string>("msPlayToPreferredSourceUri"); set => SetProperty<string>("msPlayToPreferredSourceUri", value); }
    [Export("msPlayToPrimary")]
    public bool MsPlayToPrimary { get => GetProperty<bool>("msPlayToPrimary"); set => SetProperty<bool>("msPlayToPrimary", value); }
    //[Export("msPlayToSource")]
    //public Object MsPlayToSource => GetProperty<Object>("msPlayToSource");
    [Export("name")]
    public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
    [Export("palette")]
    public string Palette => GetProperty<string>("palette");
    [Export("pluginspage")]
    public string Pluginspage => GetProperty<string>("pluginspage");
    [Export("readyState")]
    public string ReadyState => GetProperty<string>("readyState");
    [Export("src")]
    public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
    [Export("units")]
    public string Units { get => GetProperty<string>("units"); set => SetProperty<string>("units", value); }
    [Export("width")]
    public string Width { get => GetProperty<string>("width"); set => SetProperty<string>("width", value); }
    [Export("getSVGDocument")]
    public Document GetSvgDocument()
    {
    	return InvokeMethod<Document>("getSVGDocument");
    }
}
}