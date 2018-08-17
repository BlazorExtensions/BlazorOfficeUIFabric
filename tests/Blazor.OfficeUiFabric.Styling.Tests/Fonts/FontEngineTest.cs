using Blazor.OfficeUiFabric.Styling.Fonts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Tests.Fonts
{
    [TestClass]
    public class FontEngineTest
    {
        [DataTestMethod]
        [DataRow("en")]
        [DataRow("ar")]
        [DataRow("ja")]
        public void CreateTheCorrectFontStylesForEn(string lang)
        {
            var styles = FontEngine.CreateFontStyles(lang);
            Assert.IsNotNull(styles);
        }
    }
}
