using Blazor.Extensions.MergeStyles.Transforms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    [TestClass]
    public class KeyframesTest : BaseTest
    {
        private static Stylesheet stylesheet;

        [ClassInitialize]
        public static async Task InitClass(TestContext context)
        {
            Initialize();
            stylesheet = await Stylesheet.GetInstance();
            stylesheet.SetConfig(new StyleSheetConfig { InjectionMode = InjectionMode.None });
        }

        [TestInitialize]
        public void TestInit()
        {
            Initialize();
            stylesheet.Reset();
        }

        [TestCleanup]
        public void TestEnd()
        {
            TransformationsRules.SetRTL(false).GetAwaiter().GetResult();
        }

        [TestMethod]
        [Description("can register from/to keyframes")]
        public void CanRegisterFromToKeyFrames()
        {
            StyleEngine.Keyframes(new Keyframes
            {
                From = new Style
                {
                    Opacity = 0,
                },
                To = new Style
                {
                    Opacity = 1
                }
            });
            Assert.AreEqual("@keyframes css-0{from{opacity:0;}to{opacity:1;}}", stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can register from/to keyframes in rtl")]
        public void CanRegisterFromToKeyframesInRTL()
        {
            TransformationsRules.SetRTL(true).GetAwaiter().GetResult();
            StyleEngine.Keyframes(new Keyframes {
                From = new Style
                {
                    Opacity = 0
                },
                To = new Style
                {
                    Opacity = 1
                }
            });
            Assert.AreEqual("@keyframes css-0{from{opacity:0;}to{opacity:1;}}", stylesheet.GetRules());
        }

        [TestMethod]
        [Description("can register percentage keyframes")]
        public void CanRegisterPercentageKeyFrames()
        {
            StyleEngine.Keyframes(new Keyframes
            {
                ["0%"] = new Style
                {
                    Opacity = 0
                },
                ["50%"] = new Style
                {
                    Opacity = 0.8
                },
                ["100%"]= new Style
                {
                    Opacity = 1
                }
            });
            Assert.AreEqual("@keyframes css-0{0%{opacity:0;}50%{opacity:0.8;}100%{opacity:1;}}", stylesheet.GetRules());
        }
    }
}
