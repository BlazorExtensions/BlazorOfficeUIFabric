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
    public class ProvideUnitsTest
    {
        [TestMethod]
        [Description("Can provide units for directional props")]
        public void CanProvideUnitForDirectionalProps()
        {
            var properties = new List<string> { "padding", "margin", "border" };
            foreach (var property in properties)
            {
                var rules = new List<CssValue>()
                {
                    property,
                    1,
                    property + "Left",
                    1,
                    property + "Right",
                    1,
                    property + "Top",
                    1,
                    property + "Bottom",
                    1
                }.ToArray();

                TransformationsRules.ProvideUnits(rules, 0);
                TransformationsRules.ProvideUnits(rules, 2);
                TransformationsRules.ProvideUnits(rules, 4);
                TransformationsRules.ProvideUnits(rules, 6);
                TransformationsRules.ProvideUnits(rules, 8);

                CollectionAssert.That.AreEqualRules(rules,
                    property,
                    "1px",
                    property + "Left",
                    "1px",
                    property + "Right",
                    "1px",
                    property + "Top",
                    "1px",
                    property + "Bottom",
                    "1px");
            }

        }
        [TestMethod]
        public void CanIgnoreOpacity()
        {
            var rules = new List<CssValue> { "opacity", 0 }.ToArray();

            TransformationsRules.ProvideUnits(rules, 0);
            CollectionAssert.That.AreEqualRules(rules, "opacity", "0");
        }

        [TestMethod]
        public void CanProvideUnits()
        {
            var properties = new List<CssValue> { "left", "right", "top", "bottom", "borderWidth" }.ToArray();
            foreach (var property in properties)
            {
                var rules = new CssValue[] { property, 1 };
                TransformationsRules.ProvideUnits(rules, 0);
                CollectionAssert.That.AreEqualRules(rules, property, "1px");
            }
        }
    }
}
