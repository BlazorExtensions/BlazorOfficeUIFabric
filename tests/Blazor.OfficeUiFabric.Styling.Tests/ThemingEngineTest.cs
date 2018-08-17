using Blazor.Extensions.MergeStyles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Tests
{
    [TestClass]
    public class StylingEngineTest
    {
        private static Mock<ILoadThemeStyle> loadSylteMock;
        private ThemingEngine engine;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            loadSylteMock = new Mock<ILoadThemeStyle>();

        }

        [TestInitialize]
        public void Init()
        {
            this.engine = new ThemingEngine(loadSylteMock.Object);
        }

        #region GetGlobalClassNames

        [TestMethod]
        [Description("returns an empty string when the global styles are disabled")]
        public void GetGlobalClassNames_RetursAnEmptyStringWhenGlobalStylesIsDisabled()
        {
            //TODO: 
            var theme = this.engine.CreateTheme(new Theme { DisableGlobalCalssNames = true });
            var classNames = this.engine.GetGlobalClassNames(new StyleSet { Root = "ms-Link" }, theme);
            Assert.AreEqual(classNames, new StyleSet() { });
        }

        [TestMethod]
        [Description("returns the correct classNames when global classes are enabled")]
        public void ReturnsTheCorrectClassNamesWhenGlobalClassesAreEnabled()
        {
            //TODO: 
            var theme = this.engine.CreateTheme(new Theme { DisableGlobalCalssNames = false });
            var classNames = this.engine.GetGlobalClassNames(new StyleSet { Root = "ms-Link" }, theme);
            Assert.AreEqual(classNames, new StyleSet() { Root = "ms-Link" });
        }

        [TestMethod]
        [Description("Work for multiple global classes")]
        public void WorkForMultipleGloablCassses()
        {
            //TODO: 
            var theme = this.engine.CreateTheme(new Theme { DisableGlobalCalssNames = false });
            var classNames = this.engine.GetGlobalClassNames(new StyleSet { Root = "ms-Link my-other-global" }, theme);
            Assert.AreEqual(classNames, new StyleSet() { Root = "ms-Link my-other-global" });
        }

     
        #endregion
    }
}
