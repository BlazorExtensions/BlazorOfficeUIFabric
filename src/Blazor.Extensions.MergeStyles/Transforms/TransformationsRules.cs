using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Blazor.Extensions.MergeStyles.Extensions;
namespace Blazor.Extensions.MergeStyles.Transforms
{

    public static class TransformationsRules
    {
        const string GET_RTL = "BlazorExtensions.MergeStyles.GetRTL";
        const string LEFT = "left";
        const string RIGHT = "right";
        const string NO_FLIP = "@noflip";
        private static string[] _NON_PIXEL_NUMBER_PROPS = new string[] {
            "column-count",
            "font-weight",
            "flex-basis",
            "flex",
            "flex-grow",
            "flex-shrink",
            "fill-opacity",
            "opacity",
            "order",
            "z-index",
            "zoom"
        };

        private static Dictionary<CssValue, int> _autoPrefixNames;
        public static Dictionary<CssValue, int> AutoPrefixNames => _autoPrefixNames ?? (_autoPrefixNames = new Dictionary<CssValue, int>()
        {
            ["user-select"] = 1
        });

        public static Dictionary<string, string> NAME_REPLACEMENTS = _nameReplacements ?? (_nameReplacements = new Dictionary<string, string>()
        {
            [LEFT] = RIGHT,
            [RIGHT] = LEFT,
        });

        public static Dictionary<CssValue, CssValue> VALUE_REPLACEMENTS = _valueReplacements ?? (_valueReplacements = new Dictionary<CssValue, CssValue>()
        {
            ["w-resize"] = "e-resize",
            ["sw-resize"] = "se-resize",
            ["nw-resize"] = "ne-resize"
        });
        private static Dictionary<CssValue, CssValue> _valueReplacements;
        private static Dictionary<string, string> _nameReplacements;

        public static void KebabRules(CssValue[] rules, int index)
        {
            var value = ((string)rules.ElementAt(index));
            rules[index] = Regex
                .Replace(value, @"([A-Z])", "-$1", RegexOptions.Compiled)
                .Trim()
                .ToLower(); ;

        }

        public static async Task PrefixRules(ICollection<CssValue> rules, int index)
        {
            var vendorSettings = await VendorSettings.GetCurrentAsync();

            var name = rules.ElementAt(index);

            if (AutoPrefixNames.ContainsKey(name))
            {
                var value = rules.ElementAt(index + 1);

                if (vendorSettings.IsWebKit)
                {
                    rules.Add("-webkit-" + name, value);
                }
                if (vendorSettings.IsMoz)
                {
                    rules.Add("-moz-" + name, value);
                }
                if (vendorSettings.IsMs)
                {
                    rules.Add("-ms-" + name, value);
                }
                if (vendorSettings.IsOpera)
                {
                    rules.Add("-o-" + name, value);
                }
            }
        }

        public static void ProvideUnits(CssValue[] rulePairs, int index)
        {
            var name = rulePairs[index];
            var value = rulePairs[index + 1];

            if (value.IsNumber)
            {
                var exist = _NON_PIXEL_NUMBER_PROPS.Contains(name.ToString());

                var unit = exist ? "" : "px";
                rulePairs[index + 1] = $"{value}{unit}";
            }
        }

        private static bool? _isRTL = false;


        /// <summary>
        /// Sets the current RTL value.
        /// </summary>
        /// <param name="isRTL"></param>
        /// <returns></returns>
        public static async Task SetRTL(bool isRTL)
        {
            if (_isRTL != isRTL)
            {
                var instance = await Stylesheet.GetInstance();
                
                instance?.Reset();
                _isRTL = isRTL;
            }
        }

        /// <summary>
        ///  Gets the current RTL value.
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> GetRTL()
        {
            if (_isRTL == null)
            {
                _isRTL = await JSRuntime.Current?.InvokeAsync<bool>(GET_RTL);

            }
            return _isRTL.Value;
        }

        public static async Task RtlifyRules(CssValue[] rulePairs, int index)
        {
            if (await GetRTL())
            {
                var name = (string)rulePairs[index];

                if (string.IsNullOrEmpty(name))
                {
                    return;
                }

                var value = rulePairs[index + 1];

                if (!value.IsNumber && ((string)value).IndexOf(NO_FLIP) >= 0)
                {
                    rulePairs[index + 1] = ((string)value).Replace(new Regex(@"s*(?:\/\*\s*)?\@noflip\b(?:\s*\*\/)?\s*?", RegexOptions.Compiled), "").Trim();
                }
                else if (name.IndexOf(LEFT) >= 0)
                {
                    rulePairs[index] = name.Replace(LEFT, RIGHT);
                }
                else if (name.IndexOf(RIGHT) >= 0)
                {
                    rulePairs[index] = name.Replace(RIGHT, LEFT);
                }
                else if (value.ToString().IndexOf(LEFT) >= 0)
                {
                    rulePairs[index + 1] = value.Replace(LEFT, RIGHT);
                }
                else if (value.ToString().IndexOf(RIGHT) >= 0)
                {
                    rulePairs[index + 1] = value.Replace(RIGHT, LEFT);
                }
                else if (NAME_REPLACEMENTS.ContainsKey(name))
                {
                    rulePairs[index] = NAME_REPLACEMENTS[name];
                }
                else if (VALUE_REPLACEMENTS.ContainsKey(value))
                {
                    rulePairs[index + 1] = VALUE_REPLACEMENTS[value];
                }
                else
                {
                    switch (name)
                    {
                        case "margin":
                        case "padding":
                            rulePairs[index + 1] = flipQuad(value);
                            break;
                        case "box-shadow":
                            rulePairs[index + 1] = negateNum(value.ToString(), 0);
                            break;
                    }
                }
            }
        }


        private static string negateNum(string value, int partIndex)
        {
            var parts = value.Split(' ');
            var numberVal = parts[partIndex].ParseInt();

            parts[0] = parts[0].Replace(numberVal.ToString(), (numberVal * -1).ToString());

            return parts.Join(" ");
        }


        /// <summary>
        /// Given a string quad, flips the left and right values.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static CssValue flipQuad(CssValue value)
        {
            if (!value.IsNumber)
            {
                var parts = value.ToString().Split(' ');

                if (parts.Length == 4)
                {
                    return $"{parts[0]} {parts[3]} { parts[2]} { parts[1]}";
                }
            }

            return value;
        }

    }
}
