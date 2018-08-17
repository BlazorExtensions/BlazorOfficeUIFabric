using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.BuildTools.Models
{
    public class TransformOptions
    {
        public TransformOptions()
        {
            this.Files = new List<TransformFile>();
            this.Rules = new List<TransformationRule>();
        }
        [JsonProperty("src", Required = Required.DisallowNull)]
        public string Source { get; set; }

        [JsonProperty("namespace", Required = Required.DisallowNull)]
        public string Namespace { get; set; }

        public ICollection<TransformFile> Files { get; set; }

        public ICollection<TransformationRule> Rules { get; set; }
    }
}
