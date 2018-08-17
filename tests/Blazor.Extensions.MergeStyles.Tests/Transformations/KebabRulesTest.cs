using Blazor.Extensions.MergeStyles.Transforms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests.Transformations
{
    [TestClass]
    [TestCategory("rules")]
    
    public class KebabRulesTest
    {
        [TestMethod]
        [Description("Can kebab the names")]
        public void CanKebanNames()
        {
            var rules = new CssValue[] { "backgroundColor", "#cAcAcA" };
            TransformationsRules.KebabRules(rules, 0);
            CollectionAssert.AreEqual(rules, new CssValue[] { "background-color", "#cAcAcA" });
        }

        [TestMethod]
        [Description("Can kebeb webkit prefix")]
        public void CanKebebWebkitPrefix()
        {
            var rules = new CssValue[] { "WebkitFontSmoothing", "antialiased" };

            TransformationsRules.KebabRules(rules, 0);

            CollectionAssert.AreEqual(rules, new CssValue[] { "-webkit-font-smoothing", "antialiased" });

        }
    }
}
