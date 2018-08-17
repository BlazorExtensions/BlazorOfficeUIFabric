using Blazor.Extensions.MergeStyles.Extensions;
using Blazor.Extensions.MergeStyles.Transforms;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public partial class StyleEngine : IStyleEngine
    {
        public static string DISPLAY_NAME = "displayName";

        public static string GetDisplayName(Dictionary<string, object> rules)
        {
            object value = null;
            if (rules?.TryGetValue("&", out value) == true && value is IDictionary<string, object> dic)
            {
                object displayName = null;
                dic.TryGetValue(DISPLAY_NAME, out displayName);
                return displayName?.ToString();
            }
            return null;
        }


        public static async Task<RuleSet> ExtractRules(Style[] args, RuleSet rules = null, string currentSelector = "&")
        {
            if (rules is null)
            {
                rules = new RuleSet();
            }
            var stylesheet = await Stylesheet.GetInstance();
            object value = null;

            Dictionary<string, object> currentRules;
            if (!rules.TryGetValue(currentSelector, out value))
            {
                currentRules = new Dictionary<string, object>();
                rules[currentSelector] = currentRules;
                rules.__order.Add(currentSelector);
            }
            else
            {
                currentRules = (Dictionary<string, object>)value;
            }


            foreach (var arg in args)
            {
                // If the arg is a string, we need to look up the class map and merge.
                if (arg?.IsString == true)
                {

                    Style[] expandedRules;
                    if (stylesheet.TryGetStylesFromClassName((string)arg, out expandedRules))
                    {
                        await ExtractRules(expandedRules, rules, currentSelector);
                    }
                    // Else if the arg is an array, we need to recurse in.
                }
                else if (arg?.IsArray == true)
                {
                    await ExtractRules(arg.Array, rules, currentSelector);
                }
                else if (arg != null)
                {
                    // tslint:disable-next-line:no-any
                    foreach (var prop in arg?.Keys)
                    {
                        if (prop == "Selectors" || prop == "selectors")
                        {
                            var selectors = arg.Selectors;
                            foreach (var key in selectors.Keys)
                            {
                                var newSelector = key;
                                if (selectors.ContainsKey(newSelector))
                                {
                                    var selectorValue = selectors[newSelector];

                                    if (newSelector.IndexOf(":global(") == 0)
                                    {
                                        newSelector = newSelector.Replace(new Regex(@":global\(|\)$", RegexOptions.Compiled), "");
                                    }
                                    else if (newSelector.IndexOf("@media") == 0)
                                    {
                                        newSelector = newSelector + "{" + currentSelector;
                                    }
                                    else if (newSelector.IndexOf(":") == 0)
                                    {
                                        newSelector = currentSelector + newSelector;
                                    }
                                    else if (newSelector.IndexOf("&") < 0)
                                    {
                                        newSelector = currentSelector + " " + newSelector;
                                    }

                                    await ExtractRules(new Style[] { selectorValue }, rules, newSelector);
                                }
                            }
                        }
                        else
                        {
                            // Else, add the rule to the currentSelector.
                            if (prop == "Margin" || prop == "Padding")
                            {

                                // tslint:disable-next-line:no-any
                                expandQuads(currentRules, prop, arg[prop]?.ToString());
                            }
                            else
                            {
                                // tslint:disable-next-line:no-any

                                currentRules[prop] = arg[prop];
                            }
                        }
                    }
                }
            }

            return rules;
        }

        private static void expandQuads(Dictionary<string, object> currentRules, string name, string value)
        {
            var parts = value is string ? value.Split(' ') : new string[] { value };

            var partZero = parts.Length == 0 ? null : parts[0];

            var partOne = parts.Length > 1 ? parts[1] : null;

            var partTwo = parts.Length > 2 ? parts[2] : null;

            var partTree = parts.Length > 3 ? parts[3] : null;

            currentRules[name + "Top"] = partZero;

            currentRules[name + "Right"] = partOne ?? partZero;
            if (parts.Length > 2)
                currentRules[name + "Bottom"] = partTwo ?? partZero;
            currentRules[name + "Left"] = partTree ?? partOne ?? partZero;
        }

        public static async Task<string> SerializeRuleEntries(IDictionary<string, object> ruleEntries)
        {
            if (ruleEntries?.Any() != true)
            {
                return "";
            }

            var allEntries = new List<CssValue>();

            foreach (var entry in ruleEntries.Keys)
            {
                object rule;

                if (entry is string str && str != DISPLAY_NAME && ruleEntries.TryGetValue(entry, out rule) && rule != null)
                {
                    allEntries.Add(str);
                    var entryValue = ruleEntries[entry];

                    CssValue value = new CssValue();
                    switch (entryValue)
                    {
                        case CssValue css:
                            value = css;
                            break;
                        case bool bo:
                            value = bo;
                            break;
                        case int @int:
                            value = @int;
                            break;
                        case string strg:
                            value = strg;
                            break;
                        default:
                            value = JsonConvert.SerializeObject(entryValue, Formatting.None, RawConverter.Settings);
                            break;

                    }

                    allEntries.Add(value);
                }
            }
            var arrayRules = allEntries.ToArray();

            // Apply transforms.
            for (var i = 0; i < arrayRules.Length; i += 2)
            {
                TransformationsRules.KebabRules(arrayRules, i);
                TransformationsRules.ProvideUnits(arrayRules, i);
                await TransformationsRules.RtlifyRules(arrayRules, i);
                await TransformationsRules.PrefixRules(arrayRules, i);
            }
            var rules = arrayRules.ToList();
            // Apply punctuation.
            for (var i = 1; i < rules.Count; i += 4)
            {

                rules.Splice(i, 1, ":", rules[i], ";");
            }

            return string.Join("", rules);
        }

        public static async Task<Registration> StyleToRegistration(params Style[] args)
        {
            var rules = await ExtractRules(args);
            string key = getKeyForRules(rules);

            if (key != null)
            {
                var stylesheet = await Stylesheet.GetInstance();
                var registration = new Registration
                {
                    ClassName = stylesheet.GetClassNameFromKey(key),
                    Key = key,
                    Args = args
                };

                if (registration.ClassName is null)
                {
                    registration.ClassName = stylesheet.GetClassName(GetDisplayName(rules));
                    var rulesToInsert = new List<string>();

                    foreach (var selector in rules.__order)
                    {
                        rulesToInsert.Add(selector);
                        rulesToInsert.Add(await SerializeRuleEntries((Dictionary<string, object>)rules[selector]));
                    }
                    registration.RulesToInsert = rulesToInsert;
                }

                return registration;
            }
            return null;
        }

        private static string getKeyForRules(RuleSet rules)
        {
            var serialized = new List<object>();
            var hasProps = false;

            foreach (var selector in rules.__order)
            {
                serialized.Add(selector);
                var rulesForSelector = (IDictionary)rules[selector];

                foreach (var prop in rulesForSelector.Keys)
                {


                    object value = rulesForSelector[prop];


                    if (value != null)
                    {
                        hasProps = true;

                        serialized.Add(prop.ToString());
                        serialized.Add(value);
                    }
                }
            }

            return hasProps ? string.Join("", serialized) : null;
        }


        public static async Task ApplyRegistration(Registration registration, IDictionary<string, string> classMap = null)
        {
            var stylesheet = await Stylesheet.GetInstance();

            if (registration.RulesToInsert?.Any() == true)
            {
                // rulesToInsert is an ordered array of selector/rule pairs.
                for (var i = 0; i < registration.RulesToInsert.Count; i += 2)
                {
                    var rules = registration.RulesToInsert[i + 1];
                    if (!string.IsNullOrWhiteSpace(rules))
                    {
                        var selector = registration.RulesToInsert[i];

                        selector = Regex.Replace(selector, @"(&)|\$([\w-]+)\b", (match) =>
                        {
                            var amp = match.Groups[1];
                            var cn = match.Groups[2];

                            if (amp.Success)
                            {
                                return "." + registration.ClassName;
                            }
                            else if (cn.Success)
                            {
                                string value = null;
                                var success = classMap?.TryGetValue(cn.Value, out value);
                                return "." + (success == true ? value : cn.Value);
                            }
                            return "";
                        }, RegexOptions.Compiled);
                        // Fix selector using map.



                        // Insert. Note if a media query, we must close the query with a final bracket.
                        var processedRule = string.Format("{0}{1}{2}", selector, "{" + rules + "}", selector.IndexOf("@media") == 0 ? "}" : "");

                        stylesheet.InsertRule(processedRule);
                    }
                }
                stylesheet.CacheClassName(registration.ClassName, registration.Key, registration.Args, registration.RulesToInsert.ToArray());
            }
        }


        public static async Task<string> StyleToClassName(params Style[] args)
        {
            var registration = await StyleToRegistration(args);
            if (registration != null)
            {
                await ApplyRegistration(registration);
                return registration.ClassName;
            }

            return "";
        }

        /// <summary>
        /// Combine a set of styles together (but does not register css classes).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args">One or more stylesets to be merged (each param can also be falsy).</param>
        /// <returns></returns>
        public static T ConcatStyleSet<T>(params StyleSet<T>[] args)
            where T : StyleSet<T>, new()
        {
            var mergedSet = new T();
            var workingSubcomponentStyles = new Dictionary<string, List<object>>();
            foreach (var currentSet in args)
            {
                if (currentSet?.Any() == true || (currentSet?.IsBool == true && currentSet.Bolean.Value))
                {
                    foreach (var pair in currentSet)
                    {
                        var prop = pair.Key.properertyName;
                        if (prop == "SubComponentStyles")
                        {
                            // subcomponent styles - style functions or objects
                            var currentComponentStyles = (IDictionary<string, object>)pair.Value;
                            foreach (var subCompProp in currentComponentStyles)
                            {
                                if (workingSubcomponentStyles.ContainsKey(subCompProp.Key))
                                {
                                    workingSubcomponentStyles[subCompProp.Key].Add(currentComponentStyles[subCompProp.Key]);
                                }
                                else
                                {
                                    workingSubcomponentStyles[subCompProp.Key] = new List<object> { currentComponentStyles[subCompProp.Key] };
                                }
                            }
                            continue;
                        }

                        // the as any casts below is a workaround for ts 2.8.
                        // todo: remove cast to any in ts 2.9.
                        object value;
                        var currentValue = (Style)pair.Value;

                        if (!mergedSet.TryGetValue(pair.Key, out value))
                        {
                            ((IStyleSet<T>)mergedSet).AddStyle(prop, currentValue);
                        }
                        else if (value is Style mergedValue)
                        {
                            var styleSet = ((IStyleSet<T>)mergedSet);
                            var mvalues = mergedValue.IsArray ? mergedValue.Array : new[] { mergedValue };
                            var values = mvalues.Concat(currentValue.IsArray ? currentValue.Array : new[] { currentValue }).ToArray();
                            styleSet.AddStyle(prop, values);
                        }
                    }
                }
            }

            if (workingSubcomponentStyles.Any())
            {
                mergedSet.SubComponentStyles = new Dictionary<string, object>();
                var mergedSubStyles = mergedSet.SubComponentStyles;
                // now we process the subcomponent styles if there are any
                foreach (var subCompProp in workingSubcomponentStyles)
                {
                    var workinSet = workingSubcomponentStyles[subCompProp.Key];
                    Func<object, T> subComponentStyle = (styleProps) =>
                    {
                        var result = workinSet.Select(styleFunctionOrObject => styleFunctionOrObject is Func<object, T> function ? function(styleProps) : (T)styleFunctionOrObject).ToArray();
                        return ConcatStyleSet(result);
                    };

                    mergedSubStyles[subCompProp.Key] = subComponentStyle;
                }
            }
            return mergedSet;
        }

        /// <summary>
        /// Separates the classes and style objects. Any classes that are pre-registered
        /// args are auto expanded into objects.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<(List<string>, List<Style>)> ExtractStyleParts(params Style[] args)
        {
            var classes = new List<string>();
            var objects = new List<Style>();
            var stylesheet = await Stylesheet.GetInstance();

            void _processArgs(params Style[] argsList)
            {
                foreach (var arg in argsList)
                {
                    if (arg != null)
                    {
                        if (arg.IsString)
                        {
                            if (arg.String.IndexOf(" ") >= 0)
                            {
                                _processArgs(arg.String.Split(' '));
                            }
                            else
                            {
                                Style[] styles;
                                if (stylesheet.TryGetStylesFromClassName(arg.String, out styles))
                                {
                                    _processArgs(styles);
                                }
                                else
                                {
                                    // Avoid adding the same class twice.
                                    if (classes.IndexOf(arg.String) == -1)
                                    {
                                        classes.Add(arg.String);
                                    }
                                }
                            }
                        }
                        else if (arg.IsArray)
                        {
                            _processArgs(arg.Array);
                        }
                        else
                        {
                            objects.Add(arg);
                        }

                    }
                }
            };

            _processArgs(args);
            return (classes, objects);
        }

        /// <summary>
        /// Concatination helper, which can merge class names together. Skips over falsey values.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<string> MergeStyle(params Style[] args)
        {
            (List<string> classes, List<Style> objects) = await ExtractStyleParts(args);
            if (objects.Any())
            {
                classes.Add(await StyleToClassName(objects.ToArray()));
            }
            return classes.Join(" ");
        }

        /// <summary>
        /// Registers keyframe definitions.
        /// </summary>
        /// <param name="timeline"></param>
        /// <returns></returns>
        public static string Keyframes(Keyframes timeline)
        {
            var stylesheet = Stylesheet.GetInstance().GetAwaiter().GetResult();
            var name = stylesheet.GetClassName();
            var rulesArray = new List<string>();
            foreach (var pair in timeline)
            {
                rulesArray.Add(pair.Key, "{", SerializeRuleEntries(pair.Value).GetAwaiter().GetResult(), "}");
            }
            var rules = rulesArray.Join("");
            stylesheet.InsertRule($"@keyframes {name}{{{rules}}}", true);
            stylesheet.CacheClassName(name, rules, new Style[] { }, new string[] { "keyframes", rules });
            return name;
        }

        /// <summary>
        ///  Renders a given string and returns both html and css needed for the html.
        /// </summary>
        /// <param name="onRender">Function that returns a string</param>
        /// <param name="namespace">Optional namespace to prepend to css classnames to avoid collisions</param>
        /// <returns></returns>
        public static (string html, string css) RenderStatic(Func<string> onRender, string @namespace = null)
        {
            var stylesheet = Stylesheet.GetInstance().ConfigureAwait(false).GetAwaiter().GetResult();
            stylesheet.SetConfig(new StyleSheetConfig() { InjectionMode = InjectionMode.None, Namespace = @namespace });
            stylesheet.Reset();

            return (onRender(), stylesheet.GetRules());
        }

        public static T MergeStyleSets<T>(params StyleSet<T>[] styleSets)
            where T : StyleSet<T>, new()
        {
            var classNameSet = new T();
            var classMap = new Dictionary<string, string>();

            if (!styleSets.Any())
                return new T();

            var styleSet = styleSets[0];
            StyleSet<T> concatenatedStyleSet = styleSet;
            if (styleSets.Any())
            {
                concatenatedStyleSet = ConcatStyleSet(styleSets);
            }

            var registrations = new List<Registration>();
            foreach (var styleSetArea in concatenatedStyleSet)
            {
                var subCompKey = nameof(concatenatedStyleSet.SubComponentStyles);
                if (styleSetArea.Key.properertyName == subCompKey)
                {
                    classNameSet.SubComponentStyles = concatenatedStyleSet.ContainsKey(styleSetArea.Key) ? concatenatedStyleSet.SubComponentStyles : new Dictionary<string, object>();
                    continue;
                }

                var styles = (Style)styleSetArea.Value;
                (var classes, var objects) = ExtractStyleParts(styles).GetAwaiter().GetResult();

                var displayName = styleSetArea.Key.key;

                var registration = StyleToRegistration(new Style { DisplayName = displayName }, objects.ToArray()).GetAwaiter().GetResult();

                registrations.Add(registration);
                if (registration != null)
                {
                    classMap[styleSetArea.Key.key] = registration.ClassName;
                    var value = classes.Concat(new string[] { registration.ClassName }).Join(" ");
                    ((IStyleSet<T>)classNameSet).AddStyle(styleSetArea.Key.properertyName, value);
                }
            }

            foreach (var registration in registrations)
            {
                if (registration != null)
                {
                    ApplyRegistration(registration, classMap).GetAwaiter().GetResult();
                }
            }

            return classNameSet;

        }

        public static void InsertFontFace(FontFace font)
        {
            Stylesheet.GetInstance().GetAwaiter().GetResult().InsertRule($"@font-face{{{SerializeRuleEntries(font)}}}", true);
        }

        Task IStyleEngine.ApplyRegistration(Registration registration, IDictionary<string, string> classMap)
        {
            return ApplyRegistration(registration, classMap);
        }

        T IStyleEngine.ConcatStyleSet<T>(params StyleSet<T>[] args)
        {
            return ConcatStyleSet(args);
        }

        Task<RuleSet> IStyleEngine.ExtractRules(Style[] args, RuleSet rules, string currentSelector)
        {
            return ExtractRules(args, rules, currentSelector);
        }

        Task<(List<string>, List<Style>)> IStyleEngine.ExtractStyleParts(params Style[] args)
        {
            return ExtractStyleParts(args);
        }

        string IStyleEngine.GetDisplayName(Dictionary<string, object> rules)
        {
            return GetDisplayName(rules);
        }

        string IStyleEngine.Keyframes(Keyframes timeline)
        {
            return Keyframes(timeline);
        }

        Task<string> IStyleEngine.MergeStyle(params Style[] args)
        {
            return MergeStyle(args);
        }

        T IStyleEngine.MergeStyleSets<T>(params StyleSet<T>[] styleSets)
        {
            return MergeStyleSets<T>(styleSets);
        }

        (string html, string css) IStyleEngine.RenderStatic(Func<string> onRender, string @namespace)
        {
            return RenderStatic(onRender, @namespace);
        }

        Task<string> IStyleEngine.SerializeRuleEntries(IDictionary<string, object> ruleEntries)
        {
            return SerializeRuleEntries(ruleEntries);
        }

        Task<string> IStyleEngine.StyleToClassName(params Style[] args)
        {
            return StyleToClassName(args);
        }

        Task<Registration> IStyleEngine.StyleToRegistration(params Style[] args)
        {
            return StyleToRegistration(args);
        }
    }
}
