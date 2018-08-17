using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public class Stylesheet
    {
        private const string INJECT_RULE = "BlazorExtensions.MergeStyles.InjectRule";
        private StyleSheetConfig _styleSheetConfig;
        private int _counter;
        private ICollection<string> _preservedRules = new List<string>();
        private ICollection<string> _rules = new List<string>();
        private ICollection<string> _rulesToInsert = new List<string>();

        private Dictionary<string, string> _keyToClassName = new Dictionary<string, string>();
        private Dictionary<string, Tuple<Style[], string[]>> _classNamesToArgs = new Dictionary<string, Tuple<Style[], string[]>>();
        private static Stylesheet _instance;
        private readonly IJSRuntime _runtime;

        public Stylesheet(StyleSheetConfig styleSheetConfig = null, IJSRuntime runtime = null)
        {
            this._styleSheetConfig = styleSheetConfig;
            if (this._styleSheetConfig == null)
            {
                this._styleSheetConfig = new StyleSheetConfig
                {
                    InjectionMode = InjectionMode.InsertNode,
                    DefaultPrefix = "css",
                };
            }

            this._runtime = runtime;
        }

        public static async Task<Stylesheet> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Stylesheet();
            }
            if (JSRuntime.Current is JSRuntimeBase rt)
            {
                await JSRuntime.Current.InvokeAsync<object>("Init", new DotNetObjectRef(_instance));
            }
            return _instance;
        }


        /// <summary>
        /// Configures the stylesheet.
        /// </summary>
        /// <param name="styleSheetConfig">StyleSeetConfig options</param>
        ///
        [JSInvokable]
        public void SetConfig(StyleSheetConfig styleSheetConfig)
        {
            this._styleSheetConfig = styleSheetConfig;
        }

        [JSInvokable]
        public DotNetObjectRef GetConfig()
        {
            return new DotNetObjectRef(this._styleSheetConfig);
        }



        /// <summary>
        /// Will be called when the Stylesheet is reset
        /// </summary>
        public event EventHandler<EventArgs> OnReset;

        /// <summary>
        /// Generates a unique classname.
        /// </summary>
        /// <param name="displayName">Optional value to use as a prefix</param>
        /// <returns></returns>
        public string GetClassName(string displayName = null)
        {
            var (defaultName, model, defaultPrefix) = this._styleSheetConfig;

            var prefix = displayName ?? defaultPrefix;
            var name = defaultName is null ? "" : defaultName + "-";
            return $"{name}{prefix}-{this._counter++}";
        }
        /// <summary>
        /// Used internally to cache information about a class which was
        /// registered with the stylesheet.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="key"></param>
        /// <param name="styles"></param>
        /// <param name="rules"></param>
        public void CacheClassName(string className, string key, Style[] styles, string[] rules)
        {
            this._keyToClassName[key] = className;
            this._classNamesToArgs[className] = new Tuple<Style[], string[]>(styles, rules);
        }


        /// <summary>
        /// Gets the appropriate classname given a key which was previously
        /// registered using cacheClassName.
        /// </summary>
        /// <param name="key">The key value</param>
        /// <returns></returns>
        public string GetClassNameFromKey(string key)
        {
            string value = null;
            this._keyToClassName.TryGetValue(key, out value);
            return value;
        }
        /// <summary>
        /// Gets the arguments associated with a given classname which was
        /// previously registered using cacheClassName.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public bool TryGetStylesFromClassName(string className, out Style[] styles)
        {
            styles = null;

            Tuple<Style[], string[]> value = null;
            if (this._classNamesToArgs.TryGetValue(className, out value))
            {
                styles = value.Item1;
                return true;
            }
            return false;
        }

        public Style[] GetArgsFromclassName(string className)
        {
            Tuple<Style[], string[]> value = null;
            if (this._classNamesToArgs.TryGetValue(className, out value))
            {
                return value.Item1;

            }
            return null;

        }

        /// <summary>
        /// Gets the arguments associated with a given classname which was
        /// previously registered using cacheClassName.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public string[] InsertedRulesFromClassName(string className)
        {
            var entry = this._classNamesToArgs[className];

            return entry.Item2;
        }
        /// <summary>
        ///  Inserts a css rule into the stylesheet.
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="preserve">reserves the rule beyond a reset boundary.</param>
        public void InsertRule(string rule, bool preserve = false)
        {
            if (preserve)
            {
                this._preservedRules.Add(rule);
            }


            if (this._styleSheetConfig.InjectionMode != InjectionMode.None)
            {
                this._runtime?.InvokeAsync<object>(INJECT_RULE, rule, this._styleSheetConfig.InjectionMode, preserve);
            }
            else
            {
                this._rules.Add(rule);

            }


            RuleInserted?.Invoke(this, new StyleRuleInsertEventArgs(rule));
        }

        private object getStyleElement()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///   Gets all rules registered with the stylesheet; only valid when
        /// using InsertionMode.none.
        /// </summary>
        /// <param name="includePreservedRules"></param>
        /// <returns></returns>
        public string GetRules(bool includePreservedRules = false)
        {
            return (includePreservedRules ? this._preservedRules.Join("") : "") + this._rules.Join("") + this._rulesToInsert.Join("");
        }

        public void Reset()
        {
            this._rules = new List<string>();
            this._rulesToInsert = new List<string>();
            this._counter = 0;
            this._classNamesToArgs = new Dictionary<string, Tuple<Style[], string[]>>();
            this._keyToClassName = new Dictionary<string, string>();

            OnReset?.Invoke(this, new EventArgs());
        }

        /// <summary>
        ///Forces the regeneration of incoming styles without totally resetting the stylesheet.
        /// </summary>
        public void ResetKeys()
        {
            this._keyToClassName = new Dictionary<string, string>();
        }

        public event EventHandler<StyleRuleInsertEventArgs> RuleInserted;

    }
}
