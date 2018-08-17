using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling
{
    public static class SerializeExtensons
    {
        public static string ToJson(this AnimationStyles self) => JsonConvert.SerializeObject(self, Blazor.Extensions.MergeStyles.RawConverter.Settings);
        public static string ToJson(this AnimationVariables self) => JsonConvert.SerializeObject(self, Blazor.Extensions.MergeStyles.RawConverter.Settings);

    }
}
