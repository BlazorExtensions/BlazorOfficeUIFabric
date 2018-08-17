using Microsoft.JSInterop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    [TestClass]
    public class StylesheetTest : BaseTest
    {
        private static Stylesheet _stylessheet;

        [ClassInitialize]
        public static async Task Initialize(TestContext context)
        {
            Initialize();
            _stylessheet = await Stylesheet.GetInstance();

            _stylessheet.Reset();
        }

        [TestCleanup]
        public void ClassClean()
        {
            _stylessheet.SetConfig(new StyleSheetConfig { InjectionMode = InjectionMode.None, DefaultPrefix = "css" });
        }

        [TestInitialize]
        public void TestInit()
        {
            _stylessheet.SetConfig(new StyleSheetConfig { InjectionMode = InjectionMode.None, DefaultPrefix = "myCss" });
            _stylessheet.Reset();
            Initialize();
        }

        [TestMethod]
        [Description("supports overriding the default prefix")]
        public async Task SupportOverridingTheDefaultPrefix()
        {
            var className = await StyleEngine.StyleToClassName(new Style { Background = "red" });

            Assert.AreEqual(className, "myCss-0");
            Assert.AreEqual(".myCss-0{background:red;}", _stylessheet.GetRules());
        }

        [TestMethod]
        [Description("recreates a new instance when global mismatches")]
        public void RecreatesNewInstanceWhenGlobalMismatches()
        {
            //TODO: Interop with the browser to check when to recreate it
        }

    }
}

