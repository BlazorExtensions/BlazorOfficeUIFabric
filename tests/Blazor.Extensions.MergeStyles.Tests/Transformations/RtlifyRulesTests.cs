using Blazor.Extensions.MergeStyles.Transforms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests.Transformations
{
    [TestClass]
    public class RtlifyRulesTests : BaseTest
    {

        [TestInitialize]
        public async Task TestInit()
        {
            base.Init();
            await TransformationsRules.SetRTL(true);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await TransformationsRules.SetRTL(false);
        }

        [TestMethod]
        [Description("Can auto flip or avoid autoflipping with noflip")]
        public async Task CanAutoFlipAutoflippingWithNoflip()
        {
            var properties = JsonConvert.DeserializeObject<ICollection<CssValue[][]>>(await File.ReadAllTextAsync(@"Transformations/rtlfyrulesdata.json"), RawConverter.Settings);
            foreach (var test in properties)
            {
                var rules = test[0];
                await TransformationsRules.RtlifyRules(rules, 0);
                CollectionAssert.That.AreEqualRules(rules, test[1]);
            }
        }
    }
}