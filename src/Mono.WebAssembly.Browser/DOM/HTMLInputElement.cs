using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLInputElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLInputElement : HTMLElement, IHTMLInputElement
    {
        internal HTMLInputElement(int handle) : base(handle) { }

        //public HTMLInputElement () { }
        [Export("accept")]
        public string Accept { get => GetProperty<string>("accept"); set => SetProperty<string>("accept", value); }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("alt")]
        public string Alt { get => GetProperty<string>("alt"); set => SetProperty<string>("alt", value); }
        [Export("autocomplete")]
        public string Autocomplete { get => GetProperty<string>("autocomplete"); set => SetProperty<string>("autocomplete", value); }
        [Export("autofocus")]
        public bool Autofocus { get => GetProperty<bool>("autofocus"); set => SetProperty<bool>("autofocus", value); }
        [Export("border")]
        public string Border { get => GetProperty<string>("border"); set => SetProperty<string>("border", value); }
        [Export("checked")]
        public bool Checked { get => GetProperty<bool>("checked"); set => SetProperty<bool>("checked", value); }
        [Export("complete")]
        public bool Complete => GetProperty<bool>("complete");
        [Export("defaultChecked")]
        public bool DefaultChecked { get => GetProperty<bool>("defaultChecked"); set => SetProperty<bool>("defaultChecked", value); }
        [Export("defaultValue")]
        public string DefaultValue { get => GetProperty<string>("defaultValue"); set => SetProperty<string>("defaultValue", value); }
        [Export("disabled")]
        public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
        //[Export("files")]
        //public FileList Files => GetProperty<FileList>("files");
        [Export("form")]
        public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
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
        [Export("height")]
        public string Height { get => GetProperty<string>("height"); set => SetProperty<string>("height", value); }
        [Export("hspace")]
        public double Hspace { get => GetProperty<double>("hspace"); set => SetProperty<double>("hspace", value); }
        [Export("indeterminate")]
        public bool Indeterminate { get => GetProperty<bool>("indeterminate"); set => SetProperty<bool>("indeterminate", value); }
        [Export("list")]
        public HTMLElement List => GetProperty<HTMLElement>("list");
        [Export("max")]
        public string Max { get => GetProperty<string>("max"); set => SetProperty<string>("max", value); }
        [Export("maxLength")]
        public double MaxLength { get => GetProperty<double>("maxLength"); set => SetProperty<double>("maxLength", value); }
        [Export("min")]
        public string Min { get => GetProperty<string>("min"); set => SetProperty<string>("min", value); }
        [Export("multiple")]
        public bool Multiple { get => GetProperty<bool>("multiple"); set => SetProperty<bool>("multiple", value); }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("pattern")]
        public string Pattern { get => GetProperty<string>("pattern"); set => SetProperty<string>("pattern", value); }
        [Export("placeholder")]
        public string Placeholder { get => GetProperty<string>("placeholder"); set => SetProperty<string>("placeholder", value); }
        [Export("readOnly")]
        public bool ReadOnly { get => GetProperty<bool>("readOnly"); set => SetProperty<bool>("readOnly", value); }
        [Export("required")]
        public bool Required { get => GetProperty<bool>("required"); set => SetProperty<bool>("required", value); }
        [Export("selectionDirection")]
        public string SelectionDirection { get => GetProperty<string>("selectionDirection"); set => SetProperty<string>("selectionDirection", value); }
        [Export("selectionEnd")]
        public double SelectionEnd { get => GetProperty<double>("selectionEnd"); set => SetProperty<double>("selectionEnd", value); }
        [Export("selectionStart")]
        public double SelectionStart { get => GetProperty<double>("selectionStart"); set => SetProperty<double>("selectionStart", value); }
        [Export("size")]
        public double Size { get => GetProperty<double>("size"); set => SetProperty<double>("size", value); }
        [Export("src")]
        public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
        [Export("status")]
        public bool Status { get => GetProperty<bool>("status"); set => SetProperty<bool>("status", value); }
        [Export("step")]
        public string Step { get => GetProperty<string>("step"); set => SetProperty<string>("step", value); }
        [Export("type")]
        public InputElementType Type { get => GetProperty<InputElementType>("type"); set => SetProperty<InputElementType>("type", value); }
        [Export("useMap")]
        public string UseMap { get => GetProperty<string>("useMap"); set => SetProperty<string>("useMap", value); }
        [Export("validationMessage")]
        public string ValidationMessage => GetProperty<string>("validationMessage");
        [Export("validity")]
        public ValidityState Validity => GetProperty<ValidityState>("validity");
        [Export("value")]
        public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
        //[Export("valueAsDate")]
        //public Date ValueAsDate { get => GetProperty<Date>("valueAsDate"); set => SetProperty<Date>("valueAsDate", value); }
        [Export("valueAsNumber")]
        public double ValueAsNumber { get => GetProperty<double>("valueAsNumber"); set => SetProperty<double>("valueAsNumber", value); }
        [Export("vspace")]
        public double Vspace { get => GetProperty<double>("vspace"); set => SetProperty<double>("vspace", value); }
        [Export("webkitdirectory")]
        public bool Webkitdirectory { get => GetProperty<bool>("webkitdirectory"); set => SetProperty<bool>("webkitdirectory", value); }
        [Export("width")]
        public string Width { get => GetProperty<string>("width"); set => SetProperty<string>("width", value); }
        [Export("willValidate")]
        public bool WillValidate => GetProperty<bool>("willValidate");
        [Export("minLength")]
        public double MinLength { get => GetProperty<double>("minLength"); set => SetProperty<double>("minLength", value); }
        [Export("checkValidity")]
        public bool CheckValidity()
        {
            return InvokeMethod<bool>("checkValidity");
        }
        [Export("select")]
        public void Select()
        {
            InvokeMethod<object>("select");
        }
        [Export("setCustomValidity")]
        public void SetCustomValidity(string error)
        {
            InvokeMethod<object>("setCustomValidity", error);
        }
        [Export("setSelectionRange")]
        public void SetSelectionRange(double start, double end, object direction)
        {
            InvokeMethod<object>("setSelectionRange", start, end, direction);
        }
        [Export("stepDown")]
        public void StepDown(double n)
        {
            InvokeMethod<object>("stepDown", n);
        }
        [Export("stepUp")]
        public void StepUp(double n)
        {
            InvokeMethod<object>("stepUp", n);
        }
    }
}