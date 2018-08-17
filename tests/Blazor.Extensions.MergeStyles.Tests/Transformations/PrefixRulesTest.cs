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
    public class PrefixRulesTest
    {
        private CssValue[] _AUTO_TRANSLATED_RULES = new CssValue[] { "user-select" };
        [TestCleanup]
        public void TestCleanup()
        {
            VendorSettings.SetCurrent(null);
        }

        [TestMethod]
        [Description("Can provide translate webkit rules")]
        public async Task CanProvideTranslateWebkitRules()
        {
            foreach (var rule in this._AUTO_TRANSLATED_RULES)
            {
                var rules = new List<CssValue> { rule, "none" };

                VendorSettings.SetCurrent(new VendorSettings { IsWebKit = true });
                await TransformationsRules.PrefixRules(rules, 0);

                CollectionAssert.That.AreEqualRules(rules, rule, "none", "-webkit-" + rule, "none");

            }
        }

        [TestMethod]
        [Description("can provide translate moz rules")]
        public async Task CanProvideTranslateMozRules()
        {
            foreach (var rule in this._AUTO_TRANSLATED_RULES)
            {
                var rules = new List<CssValue> { rule, "none" };
                VendorSettings.SetCurrent(new VendorSettings { IsMoz = true });
                await TransformationsRules.PrefixRules(rules, 0);

                CollectionAssert.That.AreEqualRules(rules, rule, "none", "-moz-" + rule, "none");
            }
        }

        [TestMethod]
        [Description("can provide translate ms rules")]
        public async Task CanProvideTranslateMsRules()
        {
            foreach (var rule in this._AUTO_TRANSLATED_RULES)
            {
                var rules = new List<CssValue> { rule, "none" };
                VendorSettings.SetCurrent(new VendorSettings { IsMs = true });
                await TransformationsRules.PrefixRules(rules, 0);

                CollectionAssert.That.AreEqualRules(rules, rule, "none", "-ms-" + rule, "none");
            }
        }

        [TestMethod]
        [Description("Can provide translate opera rules")]
        public async Task CanProvideTranslateOperaRules()
        {
            foreach (var rule in this._AUTO_TRANSLATED_RULES)
            {
                var rules = new List<CssValue> { rule, "none" };
                VendorSettings.SetCurrent(new VendorSettings { IsOpera = true });
                await TransformationsRules.PrefixRules(rules, 0);

                CollectionAssert.That.AreEqualRules(rules, rule, "none", "-o-" + rule, "none");
            }
        }


    }
}
