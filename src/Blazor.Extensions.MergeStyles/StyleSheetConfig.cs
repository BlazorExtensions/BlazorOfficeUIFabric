using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    /// <summary>
    /// Stylesheet config.
    /// </summary>
    public partial class StyleSheetConfig
    {

         /// <summary>
        /// Default 'displayName' to use for a className.
        /// </summary>
        public string DefaultPrefix { [JSInvokable] get; set; } = "css";

        /// <summary>
        /// Injection mode for how rules are inserted.
        /// </summary>
        public InjectionMode InjectionMode { [JSInvokable]get; set; } = MergeStyles.InjectionMode.InsertNode;

        /// <summary>
        /// Default 'namespace' to attach before the className.
        /// </summary>
        public string Namespace { [JSInvokable]get; set; }


        public void Deconstruct(out string name, out InjectionMode injectionMode, out string defaultPrefix)
        {
            injectionMode = this.InjectionMode;
            name = this.Namespace;
            defaultPrefix = this.DefaultPrefix;
        }
        public void Deconstruct(out string name, out InjectionMode injectionMode)
        {
            injectionMode = this.InjectionMode;
            name =this.Namespace;
        }
        public void Deconstruct(out string name)
        {
            name = this.Namespace;
        }
        public void Deconstruct(out InjectionMode injectionMode)
        {
            injectionMode = this.InjectionMode;
        }
    }
}
