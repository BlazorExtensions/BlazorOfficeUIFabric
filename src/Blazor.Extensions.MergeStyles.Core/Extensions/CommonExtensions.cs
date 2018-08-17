using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Extensions
{
    public static class CommonExtensions
    {
        public static string Replace(this string target, Regex pattern, string value) => pattern.Replace(target, value);
        public static int ParseInt(this string input)
        {
            foreach (Match match in Regex.Matches(input, @"^(-?\d+)", RegexOptions.Compiled))
            {
                return int.Parse(match.Value);
            }

            throw new InvalidOperationException($"The string {input} is not and integer or not contains any integer part");
        }

        public static string ToCamelCase(this string value) => char.ToLowerInvariant(value[0]) + value.Substring(1);

        public static string FirstUpper(this string value)  => char.ToUpperInvariant(value[0]) + value.Substring(1);


        public static string Kebab(this string value)
        {
            return Regex
                     .Replace(value.ToCamelCase(), @"([A-Z])", "-$1", RegexOptions.Compiled)
                     .Trim()
                     .ToLower();
        }
    }
}
