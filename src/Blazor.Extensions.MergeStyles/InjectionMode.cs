using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{

    /// <summary>
    ///  Injection mode for the stylesheet.
    /// </summary>
    public enum InjectionMode
    {
        /// <summary>
        /// Avoids style injection, use getRules() to read the styles.
        /// </summary>
        None,
        /// <summary>
        /// Inserts rules using the insertRule api.
        /// </summary>
        InsertNode,
        /// <summary>
        /// Appends rules using appendChild.
        /// </summary>
        AppendChild
    }
}
