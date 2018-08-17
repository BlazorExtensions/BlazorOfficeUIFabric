using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    [TestClass]
    public class StyleTest
    {
        [TestMethod]
        public void CanCacheProperties()
        {
            var style = new Style()
            {
                Background = "",
            };
            Assert.AreEqual(style.Count, 1);
            Assert.AreEqual(style.Background, "");

        }
    }
}
