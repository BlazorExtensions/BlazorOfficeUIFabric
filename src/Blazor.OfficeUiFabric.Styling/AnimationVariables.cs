
using Newtonsoft.Json;

namespace Blazor.OfficeUiFabric.Styling
{

    public partial class AnimationVariables
    {
        [JsonProperty("durationValue1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DurationValue1 { get; set; }

        [JsonProperty("durationValue2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DurationValue2 { get; set; }

        [JsonProperty("durationValue3", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DurationValue3 { get; set; }

        [JsonProperty("durationValue4", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DurationValue4 { get; set; }

        [JsonProperty("easeFunction1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EaseFunction1 { get; set; }

        [JsonProperty("easeFunction2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EaseFunction2 { get; set; }
    }
}
