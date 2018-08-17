using Blazor.Extensions.MergeStyles.Transforms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    [TestClass]
    public class StylesheetUtilTest : BaseTest
    {
        public StylesheetUtilTest()
        {
            this.Init();
        }

        private static Stylesheet _stylesheet;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext context)
        {
            _stylesheet = await Stylesheet.GetInstance();
            _stylesheet.Reset();
            _stylesheet.SetConfig(new StyleSheetConfig() { InjectionMode = InjectionMode.None });
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _stylesheet.Reset();
        }

        [TestMethod]
        [Description("can register classes and avoid re-registering")]
        public async Task CanRegisterClassesAndAvoidReRegistering()
        {
            var className = await StyleEngine.StyleToClassName(new Style { Background = "red" });

            Assert.AreEqual("css-0", className, $"Bad generated class name, expected css-0 and get {className}");
            Assert.AreEqual(".css-0{background:red;}", _stylesheet.GetRules());

            className = await StyleEngine.StyleToClassName(new Style { Background = "red" });

            Assert.AreEqual("css-0", className, $"Bad generated class name, expected css-0 and get {className}");
            Assert.AreEqual(".css-0{background:red;}", _stylesheet.GetRules());

            className = await StyleEngine.StyleToClassName(new Style { Background = "green" });

            Assert.AreEqual("css-1", className, $"Bad generated class name, expected css-0 and get {className}");
            Assert.AreEqual(".css-0{background:red;}.css-1{background:green;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can have child selectors")]
        public async Task CanHaveChildSelector()
        {
            var className = await StyleEngine.StyleToClassName(new Style
            {
                Selectors =
                {
                    [".foo"] = new Style { Background = "red" }
                }
            });

            Assert.AreEqual(".css-0 .foo{background:red;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can have same element class selectors")]
        public async Task CanHaveSameElementClassSelector()
        {
            var className = await StyleEngine.StyleToClassName(new Style
            {
                Selectors =
                {
                    ["&.foo"] = new Style[] { new Style { Background = "red" } }
                }
            });
            Assert.AreEqual(".css-0.foo{background:red;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can register pseudo selectors")]
        public async Task CanRegisterPseduoSelectors()
        {
            var className = await StyleEngine.StyleToClassName(new Style
            {
                Selectors = new Dictionary<string, Style>
                {
                    [":hover"] = new Style { Background = "red" }
                }
            });

            Assert.AreEqual("css-0", className, $"Bad generated class name, expected css-0 and get {className}");

            Assert.AreEqual(".css-0:hover{background:red;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can register parent and sibling selectors")]
        public async Task CanRegisterParentAndSiblinSelectors()
        {
            var style = new Style
            {
                Selectors = new Dictionary<string, Style>
                {
                    ["& .child"] = new Style { Background = "red" },
                    [".parent &"] = new Style { Background = "green" }
                }
            };
            var className = await StyleEngine.StyleToClassName(style);

            Assert.AreEqual("css-0", className, $"Bad generated class name, expected css-0 and get {className}");
            Assert.AreEqual(".css-0 .child{background:red;}.parent .css-0{background:green;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can merge rules")]
        public async Task CanMergeTools()
        {
            var className = await StyleEngine.StyleToClassName(
                 null,
                 false,
                 null,
                 new Style { BackgroundColor = "red", Color = "white" },
                 new Style { BackgroundColor = "green" });

            Assert.AreEqual("css-0", className, $"Bad generated class name, expected css-0 and get {className}");
            Assert.AreEqual(".css-0{background-color:green;color:white;}", _stylesheet.GetRules());

            className = await StyleEngine.StyleToClassName(new Style { BackgroundColor = "green", Color = "white" });
            Assert.AreEqual("css-0", className, $"Bad generated class name, expected css-0 and get {className}");
        }

        [TestMethod]
        [Description("returns blank string with no input")]
        public async Task ReturnBlankStringWithNoInput()
        {
            var className = await StyleEngine.StyleToClassName();
            Assert.AreEqual(className, "");
        }

        [TestMethod]
        [Description("does not emit a rule which has an undefined value")]
        public async Task DoesNotEmitRuleWhichHasAnUndefinedValue()
        {
            var className = await StyleEngine.StyleToClassName(new Style() { FontFamily = null });
            Assert.AreEqual(string.Empty, className);
            Assert.AreEqual("", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("returns the same class name for a rule that only has a displayName")]
        public async Task SameClassNameForOnlyDysplayNameRule()
        {
            var className = await StyleEngine.StyleToClassName(new Style() { DisplayName = "foo" });
            Assert.AreEqual("foo-0", className);
            className = await StyleEngine.StyleToClassName(new Style() { DisplayName = "foo" });
            Assert.AreEqual("foo-0", className);
            Assert.AreEqual("", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can preserve displayName in names")]
        public async Task CanPreserveDisplayNameInNames()
        {
            var className = await StyleEngine.StyleToClassName(new Style() { DisplayName = "foo" });
            Assert.AreEqual("foo-0", className);
            className = await StyleEngine.StyleToClassName(new Style() { DisplayName = "foo" });
            Assert.AreEqual("foo-0", className);
            Assert.AreEqual("", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can flip rtl and add units")]
        public async Task CanFlipRTLAndAddUnits()
        {
            await TransformationsRules.SetRTL(true);
            var style = new Style() { Left = 40 };
            var className = await StyleEngine.StyleToClassName(style);
            Assert.AreEqual(".css-0{right:40px;}", _stylesheet.GetRules());
            await TransformationsRules.SetRTL(false);
        }

        [TestMethod]
        [Description("can prefix webkit specific things")]
        public async Task CanPrefixWebkitSpecificThings()
        {
            VendorSettings.SetCurrent(new VendorSettings { IsWebKit = true });
            var style = new Style() { WebkitFontSmoothing = FontSmoothing.None };
            var className = await StyleEngine.StyleToClassName(style);
            Assert.AreEqual(".css-0{-webkit-font-smoothing:none;}", _stylesheet.GetRules());
            VendorSettings.SetCurrent(null);

        }

        [TestMethod]
        [Description("can expand previously defined rules")]
        public async Task CanExpandPreviusDfinedRules()
        {
            var style = new Style() { Background = "red" };
            var className = await StyleEngine.StyleToClassName(style);
            var newClassName = await StyleEngine.StyleToClassName(className, new Style { Color = "white" });
            Assert.AreEqual("css-1", newClassName);

            Assert.AreEqual(".css-0{background:red;}.css-1{background:red;color:white;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can expand previously defined rules in selectors")]
        public async Task CanExpandPreviouslyDefinedRulesInSelectors()
        {
            var className = await StyleEngine.StyleToClassName(new Style
            {
                Background = "red"
            });
            var newClassName = await StyleEngine.StyleToClassName(new Style()
            {
                Selectors = {
                    ["& > *"] = className
                }
            });
            Assert.AreEqual("css-1", newClassName);
            Assert.AreEqual(".css-0{background:red;}.css-1 > *{background:red;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can register global selectors")]
        public async Task CanRegisterGlobalSelectors()
        {
            var className = await StyleEngine.StyleToClassName(new Style()
            {
                Selectors =
                {
                    [":global(button)"] = new Style{ Background = "red"}
                }
            });

            Assert.AreEqual("css-0", className);
            Assert.AreEqual("button{background:red;}", _stylesheet.GetRules());

        }

        [TestMethod]
        [Description("can expand an array of rules")]
        public async Task CanExpandAnArrayOfRules()
        {

            await StyleEngine.StyleToClassName(new Style[] { new Style { Background = "red" }, new Style { Background = "white" } });
            Assert.AreEqual(".css-0{background:white;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can expand increased specificity rules")]
        public async Task CanExpandIncreasedSpecificityRules()
        {
            await StyleEngine.StyleToClassName(new Style
            {
                Selectors =
                {
                    ["&&&"] = new Style {
                        Background = "red"
                    }
                }
            });
            Assert.AreEqual(".css-0.css-0.css-0{background:red;}", _stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can apply media queries")]
        public async Task CanApplyMediaQueries()
        {
            await StyleEngine.StyleToClassName(new Style
            {
                Background = "blue",
                Selectors =
                {
                    ["@media(min-width: 300px)"] = new Style
                    {
                        Background = "red",
                        Selectors =
                        {
                            [":hover"] = new Style
                            {
                                Background = "green"
                            }
                        }
                    }
                }
            });

            var expect = ".css-0{background:blue;}" +
                "@media(min-width: 300px){" +
                ".css-0{background:red;}" +
                "}" +
                "@media(min-width: 300px){" +
                ".css-0:hover{background:green;}" +
                "}";
            Assert.AreEqual(expect, _stylesheet.GetRules());
        }

    }
}