using Blazor.Extensions.MergeStyles.Extensions;
using Blazor.Extensions.MergeStyles.Transforms;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public class RuleSet : Dictionary<string, object>
    {
        public List<string> __order { get; set; } = new List<string>();

    }

  }