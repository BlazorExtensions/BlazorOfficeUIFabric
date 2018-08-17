using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLOutputElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLOutputElement : HTMLElement, IHTMLOutputElement
    {
        internal HTMLOutputElement(int handle) : base(handle) { }

        //public HTMLOutputElement () { }
        [Export("defaultValue")]
        public string DefaultValue { get => GetProperty<string>("defaultValue"); set => SetProperty<string>("defaultValue", value); }
        [Export("form")]
        public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
        [Export("htmlFor")]
        public DOMSettableTokenList HtmlFor => GetProperty<DOMSettableTokenList>("htmlFor");
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
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
        [Export("checkValidity")]
        public bool CheckValidity()
        {
            return InvokeMethod<bool>("checkValidity");
        }
        [Export("reportValidity")]
        public bool ReportValidity()
        {
            return InvokeMethod<bool>("reportValidity");
        }
        [Export("setCustomValidity")]
        public void SetCustomValidity(string error)
        {
            InvokeMethod<object>("setCustomValidity", error);
        }
    }
}