using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.BuildTools.Models
{
    /// <summary>
    /// Represent a regex transformation rule
    /// </summary>
    public class TransformationRule
    {
        /// <summary>
        /// The regex expression patther
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// The value to be replaced
        /// </summary>
        public string Value { get; set; }

        public override string ToString()
        {
            return $"pattern = {this.Pattern}, value = {this.Value}";
        }
    }
}
