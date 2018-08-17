using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.BuildTools.Models
{
    public class TransformFile
    {
        public TransformFile()
        {
            this.Rules = new List<TransformationRule>();
        }
        /// <summary>
        /// The relative source path
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        /// A collection of TransformationRules to be executed
        /// </summary>
        public ICollection<TransformationRule> Rules { get; set; }

        /// <summary>
        /// The ouput name for the Class.cs
        /// </summary>
        /// 
        [JsonProperty("className")]
        public string Name { get; set; }

        public string Density { get; set; } = "normal";

        public int CsharpVersion { get; set; } = 6;

        public string ArrayType { get; set; } = "list";

        public string Features { get; set; } = "complete";

        public string ClassName => this.Name ?? this.Src.Replace(".ts", ".cs");

        public string SchemaPath => this.Src.Replace(".ts", ".json");

        public bool Validate()
        {
            return this.ClassName.EndsWith(".cs");
        }
    }
}
