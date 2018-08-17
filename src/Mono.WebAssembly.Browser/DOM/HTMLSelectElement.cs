using System;
using System.Runtime.CompilerServices;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLSelectElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLSelectElement : HTMLElement {
    internal HTMLSelectElement  (int handle) : base (handle) {}

    //public HTMLSelectElement () { }
    [Export("autofocus")]
    public bool Autofocus { get => GetProperty<bool>("autofocus"); set => SetProperty<bool>("autofocus", value); }
    [Export("disabled")]
    public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
    [Export("form")]
    public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
    [Export("length")]
    public double Length { get => GetProperty<double>("length"); set => SetProperty<double>("length", value); }
    [Export("multiple")]
    public bool Multiple { get => GetProperty<bool>("multiple"); set => SetProperty<bool>("multiple", value); }
    [Export("name")]
    public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
    [Export("options")]
    public HTMLOptionsCollection Options => GetProperty<HTMLOptionsCollection>("options");
    [Export("required")]
    public bool Required { get => GetProperty<bool>("required"); set => SetProperty<bool>("required", value); }
    [Export("selectedIndex")]
    public double SelectedIndex { get => GetProperty<double>("selectedIndex"); set => SetProperty<double>("selectedIndex", value); }
    [Export("selectedOptions")]
    public HTMLCollectionOf<HTMLOptionElement> SelectedOptions { get => GetProperty<HTMLCollectionOf<HTMLOptionElement>>("selectedOptions"); set => SetProperty<HTMLCollectionOf<HTMLOptionElement>>("selectedOptions", value); }
    [Export("size")]
    public double Size { get => GetProperty<double>("size"); set => SetProperty<double>("size", value); }
    [Export("type")]
    public string Type => GetProperty<string>("type");
    [Export("validationMessage")]
    public string ValidationMessage => GetProperty<string>("validationMessage");
    [Export("validity")]
    public ValidityState Validity => GetProperty<ValidityState>("validity");
    [Export("value")]
    public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
    [Export("willValidate")]
    public bool WillValidate => GetProperty<bool>("willValidate");
    [Export("add")]
    public void Add(HTMLElement element, object before)
    {
    	InvokeMethod<object>("add", element, before);
    }
    [Export("checkValidity")]
    public bool CheckValidity()
    {
    	return InvokeMethod<bool>("checkValidity");
    }
    [Export("item")]
    public Object Item(Object name, Object index)
    {
    	return InvokeMethod<Object>("item", name, index);
    }
    [Export("namedItem")]
    public Object NamedItem(string name)
    {
    	return InvokeMethod<Object>("namedItem", name);
    }
    [Export("remove")]
    public void Remove(double index)
    {
    	InvokeMethod<object>("remove", index);
    }
    [Export("setCustomValidity")]
    public void SetCustomValidity(string error)
    {
    	InvokeMethod<object>("setCustomValidity", error);
    }
    [IndexerName("TheItem")]
    public Object this[string name] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
}