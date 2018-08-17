using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public interface IStyleEngine
    {
        Task ApplyRegistration(Registration registration, IDictionary<string, string> classMap = null);
        T ConcatStyleSet<T>(params StyleSet<T>[] args) where T : StyleSet<T>, new();
        Task<RuleSet> ExtractRules(Style[] args, RuleSet rules = null, string currentSelector = "&");
        Task<(List<string>, List<Style>)> ExtractStyleParts(params Style[] args);
        string GetDisplayName(Dictionary<string, object> rules);
        string Keyframes(Keyframes timeline);
        Task<string> MergeStyle(params Style[] args);
        T MergeStyleSets<T>(params StyleSet<T>[] styleSets) where T : StyleSet<T>, new();
        (string html, string css) RenderStatic(Func<string> onRender, string @namespace = null);
        Task<string> SerializeRuleEntries(IDictionary<string, object> ruleEntries);
        Task<string> StyleToClassName(params Style[] args);
        Task<Registration> StyleToRegistration(params Style[] args);
    }
}