using Blazor.Extensions.MergeStyles.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public class Keyframes : Dictionary<string, Style>
    {
        public Keyframes()
        {
            
        }
        public Style From
        {
            get
            {
                Style value;
                this.TryGetValue("from", out value);
                return value;
            }
            set
            {
    
                this["from"] = value;
            }
        }

        public Style To
        {
            get
            {
                Style value;
                this.TryGetValue("to", out value);
                return value;
            }
            set
            {
                this["to"] = value;
            }
        }

    }
}
