using System.Collections.Generic;

namespace Blazor.Extensions.MergeStyles
{
    public partial class Registration
    {
        public Style[] Args { get; set; }
        public string ClassName { get; set; }
        public string Key { get; set; }
        public List<string> RulesToInsert { get; set; }

    }
}