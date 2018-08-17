using System;

namespace Blazor.Extensions.MergeStyles
{
    public class StyleRuleInsertEventArgs : EventArgs
    {
        public string Rule { get; }
        public StyleRuleInsertEventArgs(string rule)
        {
            this.Rule = rule;
        }
    }
}