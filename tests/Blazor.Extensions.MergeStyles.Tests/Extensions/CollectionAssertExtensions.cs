using Blazor.Extensions.MergeStyles;
using Blazor.Extensions.MergeStyles.Transforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public static class CollectionAssertExtensions
    {
        public static void AreEqualRules(this CollectionAssert that, IEnumerable<CssValue> expected, params CssValue[] actual)
        {
            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray(), $"The rules are not equals expected {string.Join(":", expected)} actual: {string.Join(":", actual)}", expected, actual);
        }
    }
}
