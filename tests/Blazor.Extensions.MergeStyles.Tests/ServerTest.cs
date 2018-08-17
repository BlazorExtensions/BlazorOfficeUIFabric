using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    [TestClass]
    public class ServerTest : BaseTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Initialize();
        }

        [TestMethod]
        [Description("can render content")]
        public void CanRenderContent()
        {
            (var html, var css) = StyleEngine.RenderStatic(() =>
            {
                var classNames = StyleEngine.MergeStyleSets(new StyleSetFake
                {
                    Root = new Style
                    {
                        Background = "red"
                    }
                });

                return $"<div class=\"{classNames.Root}\">Hello!</div>";
            });
            Assert.AreEqual("<div class=\"root-0\">Hello!</div>", html);
            Assert.AreEqual(".root-0{background:red;}", css);
        }

        [TestMethod]
        [Description("can namespace things")]
        public async Task CanNamespaceThings()
        {

            (var html, var css) = StyleEngine.RenderStatic(() =>
            {
                var classNames = StyleEngine.MergeStyleSets(new StyleSetFake
                {
                    Root = new Style
                    {
                        Background = "red"
                    }
                });

                return $"<div class=\"{classNames.Root}\">Hello!</div>";
            }, "test");
            var sheet = await Stylesheet.GetInstance();
            sheet.SetConfig(new StyleSheetConfig { InjectionMode = InjectionMode.None, Namespace = null, DefaultPrefix = "css" });
            Assert.AreEqual("<div class=\"test-root-0\">Hello!</div>", html);
            Assert.AreEqual(".test-root-0{background:red;}", css);


        }

    }
}
