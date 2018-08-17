using Newtonsoft.Json;

namespace Blazor.Extensions.MergeStyles.Tests
{

    public class StyleSetFake : StyleSet<StyleSetFake>
    {
        private Style a;
        private Style b;
        private Style c;
        private Style cFoo;
        private Style d;

        //[JsonProperty("a",DefaultValueHandling  = DefaultValueHandling.Ignore)]
        public Style A { get => this.a; set => SetProperty(ref this.a, value); }

        //[JsonProperty("b", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Style B { get => this.b; set => SetProperty(ref this.b, value); }

        //[JsonProperty("c", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Style C { get => this.c; set => SetProperty(ref this.c, value); }

        public Style CFoo { get => this.cFoo; set => SetProperty(ref this.cFoo, value); }

        public Style D { get => this.d; set => SetProperty(ref this.d, value); }
    }

}
