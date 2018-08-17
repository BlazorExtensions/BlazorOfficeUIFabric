using System;
namespace Mono.WebAssembly.Browser.DOM
{
    public partial class Element
    {
        // Special Attribute and Style methods
        #region Attribute and Style methods

        [Export("getAttribute")]
        public string GetAttribute(string qualifiedName)
        {
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentNullException(nameof(qualifiedName));

            var getAttributeFor = "MonoWasmBrowserAPI.mono_wasm_get_attribute(" + this.Handle + ",\"" + qualifiedName + "\")";
            return Runtime.ExecuteJavaScript(getAttributeFor);

        }

        [Export("setAttribute")]
        public void SetAttribute(string qualifiedName, string value)
        {

            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentNullException(nameof(qualifiedName));

            var setAttributeFor = "MonoWasmBrowserAPI.mono_wasm_set_attribute(" + this.Handle + ",\"" + qualifiedName + "\", \"" + value + "\")";
            Runtime.ExecuteJavaScript(setAttributeFor);

        }

        [Export("removeAttribute")]
        public void RemoveAttribute(string qualifiedName)
        {

            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentNullException(nameof(qualifiedName));

            var removeAttributeFor = "MonoWasmBrowserAPI.mono_wasm_set_attribute(" + this.Handle + ",\"" + qualifiedName + "\")";
            Runtime.ExecuteJavaScript(removeAttributeFor);
        }

        public void SetStyleAttribute(string qualifiedName, string value)
        {

            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentNullException(nameof(qualifiedName));

            var setStyleFor = "MonoWasmBrowserAPI.mono_wasm_set_style_attribute(" + this.Handle + ",\"" + qualifiedName + "\", \"" + value + "\")";
            Runtime.ExecuteJavaScript(setStyleFor);

        }


        public string GetStyleAttribute(string qualifiedName)
        {
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentNullException(nameof(qualifiedName));


            var getStyleFor = "MonoWasmBrowserAPI.mono_wasm_get_style_attribute(" + this.Handle + ",\"" + qualifiedName + "\")";
            return Runtime.ExecuteJavaScript(getStyleFor);

        }


        public void RemoveStyleAttribute(string qualifiedName)
        {
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentNullException(nameof(qualifiedName));

            var removeAttributeFor = "MonoWasmBrowserAPI.mono_wasm_set_style_attribute(" + this.Handle + ",\"" + qualifiedName + "\")";
            Runtime.ExecuteJavaScript(removeAttributeFor);
        }


        #endregion
    }
}
