using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLButtonElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLButtonElement : HTMLElement, IHTMLButtonElement
    {
        internal HTMLButtonElement(int handle) : base(handle) { }

        //public HTMLButtonElement() { }
        [Export("autofocus")]
        public bool Autofocus { get => GetProperty<bool>("autofocus"); set => SetProperty<bool>("autofocus", value); }
        [Export("disabled")]
        public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
        //[Export("form")]
        //public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
        [Export("formAction")]
        public string FormAction { get => GetProperty<string>("formAction"); set => SetProperty<string>("formAction", value); }
        [Export("formEnctype")]
        public string FormEnctype { get => GetProperty<string>("formEnctype"); set => SetProperty<string>("formEnctype", value); }
        [Export("formMethod")]
        public string FormMethod { get => GetProperty<string>("formMethod"); set => SetProperty<string>("formMethod", value); }
        [Export("formNoValidate")]
        public string FormNoValidate { get => GetProperty<string>("formNoValidate"); set => SetProperty<string>("formNoValidate", value); }
        [Export("formTarget")]
        public string FormTarget { get => GetProperty<string>("formTarget"); set => SetProperty<string>("formTarget", value); }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("status")]
        public Object Status { get => GetProperty<Object>("status"); set => SetProperty<Object>("status", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("validationMessage")]
        public string ValidationMessage => GetProperty<string>("validationMessage");
        //[Export("validity")]
        //public ValidityState Validity => GetProperty<ValidityState>("validity");
        [Export("value")]
        public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
        [Export("willValidate")]
        public bool WillValidate => GetProperty<bool>("willValidate");
        [Export("checkValidity")]
        public bool CheckValidity()
        {
            return InvokeMethod<bool>("checkValidity");
        }
        [Export("setCustomValidity")]
        public void SetCustomValidity(string error)
        {
            InvokeMethod<object>("setCustomValidity", error);
        }
    }
}