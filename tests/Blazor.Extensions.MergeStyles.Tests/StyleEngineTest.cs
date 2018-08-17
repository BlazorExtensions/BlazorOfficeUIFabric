using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    [TestClass]
    public partial class StyleEngineTest : BaseTest
    {
        public StyleEngineTest()
        {
            Initialize();
        }
        private static Stylesheet stylesheet;

        [ClassInitialize]
        public static async Task ClassInit(TestContext context)
        {

            stylesheet = await Stylesheet.GetInstance();
        }

        [TestInitialize]
        public void InitTest()
        {
            stylesheet.Reset();
        }

        [TestMethod]
        [Description("can extract classes and objects")]
        public async Task CanExtractClassesAndObjects()
        {
            var styleLeft1 = new Style { Left = 1 };
            var styleLeft2 = new Style { Left = 2 };
            var styleLeft3 = new Style { Left = 3 };
            (List<string> classes, List<Style> objects) = await StyleEngine.ExtractStyleParts("a", "b", new string[] { "c", "d" }, styleLeft1, new Style[] { "e", styleLeft2, styleLeft3 });

            CollectionAssert.AreEqual(new[] { "a", "b", "c", "d", "e" }, classes);
            CollectionAssert.AreEqual(new Style[] { new Style { Left = 1 }, styleLeft2, styleLeft3 }, objects);
        }

        [TestMethod]
        [Description("can expand previously registered rules")]
        public async Task CanExpandPreviouslyRegisteredRules()
        {
            var className = await StyleEngine.MergeStyle(new Style { Left = 1 });

            (List<string> classes, List<Style> objects) = await StyleEngine.ExtractStyleParts(className, new Style { Left = 2 });

            CollectionAssert.AreEqual(new List<string>(), classes);
            CollectionAssert.AreEqual(new Style[] { new Style { Left = 1 }, new Style { Left = 2 } }, objects);
        }


        [TestMethod]
        [Description("can concat style sets")]
        public void CanConcatStylesSets()
        {
            var result = StyleEngine.ConcatStyleSet(new StyleSetFake
            {
                Root = new Style
                {
                    Background = "red"
                },
                A = new Style
                {
                    Background = "green"
                }
            }, new StyleSetFake
            {
                A = new Style
                {
                    Background = "white",
                },
                B = new Style
                {
                    Background = "blue"
                }
            }, new StyleSetFake
            {
                Root = new Style
                {
                    Selectors =
                    {
                        [":hover"] = new Style{ Background = "yellow"}
                    }

                }
            });
            var expected = new StyleSetFake
            {
                Root = new Style[]
                {
                   new Style { Background  = "red" },
                   new Style {Selectors =
                       {
                           [":hover"] = new Style{ Background = "yellow" }
                       }
                   }
                },
                A = new Style[]
                {
                  new Style{  Background = "green" },
                  new Style{  Background = "white"}
                },
                B = new Style
                {
                    Background = "blue"
                }
            };
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [Description("can concat mixed style sets with style functions on both ends")]
        public void CanConcatMixedStyleSetsWithStyleFunctionsOnBothEnds()
        {
            Func<object, StyleSetFake> fn1 = (prop) =>
             {
                 return new StyleSetFake()
                 {
                     Root = new Style { Background = "yellow" },
                 };
             };

            Func<object, StyleSetFake> fn2 = (porps) =>
            {
                return new StyleSetFake
                {
                    Root = new Style
                    {
                        Background = "yellow",
                        Color = "pink"
                    }
                };
            };
            var result = StyleEngine.ConcatStyleSet(new StyleSetFake
            {

                Root = new Style { Background = "red" },
                A = new Style { Background = "green" },
                SubComponentStyles =
                {
                    ["A"] = fn1
                },

            }, new StyleSetFake
            {
                A = new Style { Background = "white" },
                B = new Style { Background = "blue" },
                SubComponentStyles =
                {
                    ["A"] = fn2
                }
            }, new StyleSetFake
            {
                Root = new Style
                {
                    Selectors =
                    {
                        [":hover"] = new Style{ Background = "yellow" }
                    }
                }
            });

            Assert.AreEqual(new Style[] {
             new Style{ Background = "red" },
             new Style{
                 Selectors =
                 {
                     [":hover"] = new Style {Background = "yellow"}
                 }
             }
            }, result.Root);

            Assert.AreEqual(new Style { Background = "blue" }, result.B);
            Assert.AreEqual(new Style[] { new Style { Background = "green" }, new Style { Background = "white" } }, result.A);
            if (result.SubComponentStyles["A"] is Func<object, StyleSetFake> function)
            {
                var aExpanded = function(new StyleSetFake { });
                Assert.AreEqual(new StyleSetFake
                {
                    Root = new Style[] { new Style { Background = "green", FontSize = 12, }, new Style { Background = "yellow", Color = "pink" } }
                }, aExpanded);

            }
            else
            {
                Assert.IsTrue(false, "The subcompoment must be a function");

            }

        }

        [TestMethod]
        [Description("can handle falsy values and sub component styles that has objects")]
        public void CanHandleFalsyValuesAndSubComponentStylesThatHasObjects()
        {
            Func<object, StyleSetFake> fn1 = (props) => new StyleSetFake { Root = new Style { Background = "green", FontSize = 12 } };

            Func<object, StyleSetFake> fn2 = (props) => new StyleSetFake { Root = new Style { Background = "yellow", Color = "pink" } };

            var result = StyleEngine.ConcatStyleSet(false, new StyleSetFake
            {
                SubComponentStyles =
                {
                    ["A"] = fn1
                }
            }, new StyleSetFake
            {
                SubComponentStyles =
                {
                   ["A"] = fn2
                }
            },
            null,
            null,
            false,
            new StyleSetFake
            {
                SubComponentStyles =
                {
                    ["A"] = new StyleSetFake
                    {
                        Root = new Style
                        {
                            FontSize = 14
                        }
                    }
                }
            });

            Assert.IsTrue(result.ContainsKey(("sub-component-styles", "SubComponentStyles")));
            if (result.SubComponentStyles["A"] is Func<object, StyleSetFake> function)
            {
                var aExpanded = function(new StyleSetFake { });
                Assert.AreEqual(new StyleSetFake
                {
                    Root = new Style[] { new Style { Background = "green", FontSize = 12, }, new Style { Background = "yellow", Color = "pink" }, new Style { FontSize = 14 } }
                }, aExpanded);

            }
            else
            {
                Assert.IsTrue(false, "The subcompoment must be a function");

            }

        }
    }
}
