using Mono.WebAssembly;
using Mono.WebAssembly.Browser.DOM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling
{

    public class LoadThemeStyle : ILoadThemeStyle
    {
        /// <summary>
        /// Matches theming tokens. For example, "[theme: themeSlotName, default: #FFF]" (including the quotes).
        /// </summary>
        static Regex _themeTokenRegex = new Regex(@"[\'\""]\[theme:\s*(\w+)\s*(?:\,\s*default:\s*([\\""\']?[\.\,\(\)\#\-\s\w]*[\.\,\(\)\#\-\w][\""\']?))?\s*\][\'\""]", RegexOptions.Compiled);

        /// <summary>
        /// Maximum style text length, for supporting IE style restrictions.
        /// </summary>
        const int MAX_STYLE_CONTENT_SIZE = 10000;

        static Lazy<ThemeState> lazyThemeState = new Lazy<ThemeState>(() => new ThemeState());
        static ThemeState themeState => lazyThemeState.Value;
        public static void ConfigureLoadStyles(Action<string, IEnumerable<ThemingInstruction>> action)
        {
            themeState.LoadAction = action;
        }
        //bool _injectStylesWithCssText;

        bool shouldUseCssText()
        {
            var useCSSText = false;


            var emptyStyle = HTMLPage.Document.CreateElement<HTMLStyleElement>();

            emptyStyle.Type = "text/css";
            var sheet = emptyStyle.GetAttributeNode("styleSheet");
            sheet.ConvertTo<Element>();

            var useCssText = emptyStyle.GetAttribute("styleSheet");
            ;


            return useCSSText;
        }

        public void LoadTheme(Theme theme)
        {
            themeState.Theme = theme;
            reloadStyles();


        }

        private string detokenize(string styles)
        {
            if (!string.IsNullOrEmpty(styles))
            {
                styles = resolveThemableArray(splitStyles(styles)).styleString;
            }
            return styles;
        }

        /// <summary>
        /// Reloads styles.
        /// </summary>
        private void reloadStyles()
        {
            if (themeState.Theme != null)
            {
                var themableStyles = new List<ICollection<ThemingInstruction>>();
                foreach (var styleRecord in themeState.RegisteredThemableStyles)
                {
                    themableStyles.Add(styleRecord.ThemableStyle);
                }
                if (themableStyles.Count > 0)
                {
                    clearStyles(ClearStyleOptions.OnlyThemable);
                    applyThemableStyles(themableStyles.SelectMany(s => s).ToList());
                }
            }
        }

        private void clearStyles(ClearStyleOptions option = ClearStyleOptions.All)
        {
            if (option == ClearStyleOptions.All || option == ClearStyleOptions.OnlyNonThemable)
            {
                clearStylesInternal(themeState.RegisteredStyles);
                themeState.RegisteredStyles = new List<StyleRecord>();
            }
            if (option == ClearStyleOptions.All || option == ClearStyleOptions.OnlyThemable)
            {
                clearStylesInternal(themeState.RegisteredThemableStyles);
                themeState.RegisteredThemableStyles = new List<StyleRecord>();
            }
        }

        private void clearStylesInternal(ICollection<StyleRecord> records)
        {
            foreach (var styleRecord in records)
            {
                var styleElement = styleRecord.StyleElement as HTMLStyleElement;
                if (styleElement?.ParentElement != null)
                {
                    styleElement.ParentElement.RemoveChild(styleElement);
                }
            };
        }


        /// <summary>
        ///  Split tokenized CSS into an array of strings and theme specification objects
        /// </summary>
        private ICollection<ThemingInstruction> splitStyles(string styles)
        {
            var result = new List<ThemingInstruction>();

            if (string.IsNullOrEmpty(styles))
            {
                var pos = 0; // Current position in styles.

                var matches = _themeTokenRegex.Matches(styles);
                for (int i = 0; i < matches.Count; i++)
                {

                    var match = matches[i];
                    var matchIndex = match.Index;
                    if (matchIndex > pos)
                    {
                        result.Add(new ThemingInstruction()
                        {
                            RawString = styles.Substring(pos, match.Length)
                        });
                    }

                    result.Add(new ThemingInstruction
                    {
                        Theme = match.Groups[1].Value,
                        DefaultValue = match.Groups[2].Value
                    });
                    // index of the first character after the current match
                    pos = match.Index;
                }
                // Push the rest of the string after the last match.
                result.Add(new ThemingInstruction
                {
                    RawString = styles.Substring(pos)
                });
            }
            return result;

        }

        /// <summary>
        /// Loads a set of style text. If it is registered too early, we will register it when the window.load
        /// event is fired.
        /// </summary>
        /// <param name="styles">Themable style text to register.</param>
        /// <param name="loadAsync">When true, always load styles in async mode, irrespective of current sync mode</param>
        public void LoadStyles(string styles, bool loadAsync = false)
        {
            this.LoadStyles(splitStyles(styles), loadAsync);
        }

        public void LoadStyles(ICollection<ThemingInstruction> styles, bool loadSync = false)
        {
            Measure(() =>
            {
                (var mode, var flushTimer, var buffer) = themeState.RunState;
                if (loadSync || mode == Mode.Async)
                {
                    buffer.Add(styles.ToList());
                    if (flushTimer.HasValue)
                    {
                        throw new NotImplementedException();
                        //this.themeState.RunState.FlushTimer = a
                    }
                }
                else
                {
                    applyThemableStyles(styles);
                }


            });
        }

        private static void applyThemableStyles(ICollection<ThemingInstruction> styles, StyleRecord styleRecord = null)
        {

            if (themeState.LoadStyle(resolveThemableArray(styles).styleString, styles))
            {
                registerStyles(styles);
            }


        }

        static void registerStyles(ICollection<ThemingInstruction> styleArray)
        {
            var document = HTMLPage.Document;
            var head = document.GetElementsByTagName("head")[0];
            var styleElement = document.CreateElement<HTMLStyleElement>();

            (string styleString, bool themable) = resolveThemableArray(styleArray);

            styleElement.Type = "text/css";

            styleElement.AppendChild(document.CreateTextNode(styleString));
            themeState.Performance.Count++;
            head.AppendChild(styleElement);

            var record = new StyleRecord()
            {
                StyleElement = styleElement,
                ThemableStyle = styleArray,
            };
            if (themable)
            {
                themeState.RegisteredThemableStyles.Add(record);
            }
            else
            {
                themeState.RegisteredStyles.Add(record);
            }
        }

        static (string styleString, bool themable) resolveThemableArray(IEnumerable<ThemingInstruction> splitStyleArray)
        {
            var theme = themeState.Theme;
            var themable = false;
            var resolvedArray = splitStyleArray.Select(currentValue =>
           {
               var themeSlot = currentValue.Theme;
               if (!string.IsNullOrWhiteSpace(themeSlot))
               {
                   themable = true;
                   var themedValue = theme.Any() ? theme[themeSlot] : null;
                   var defaultValue = currentValue.DefaultValue ?? "inherit";
                   return themedValue ?? defaultValue;
               }
               else
               {
                   return currentValue.RawString;
               }
           });

            return (resolvedArray.Join(""), themable);
        }


        private static void Measure(Action action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action.Invoke();
            stopwatch.Stop();

            themeState.Performance.Duration += stopwatch.ElapsedMilliseconds;
        }
    }
}