using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("ValidityState", typeof(Mono.WebAssembly.JSObject))]
    public sealed class ValidityState : JSObject
    {
        internal ValidityState(int handle) : base(handle) { }

        //public ValidityState() { }
        [Export("badInput")]
        public bool BadInput => GetProperty<bool>("badInput");
        [Export("customError")]
        public bool CustomError => GetProperty<bool>("customError");
        [Export("patternMismatch")]
        public bool PatternMismatch => GetProperty<bool>("patternMismatch");
        [Export("rangeOverflow")]
        public bool RangeOverflow => GetProperty<bool>("rangeOverflow");
        [Export("rangeUnderflow")]
        public bool RangeUnderflow => GetProperty<bool>("rangeUnderflow");
        [Export("stepMismatch")]
        public bool StepMismatch => GetProperty<bool>("stepMismatch");
        [Export("tooLong")]
        public bool TooLong => GetProperty<bool>("tooLong");
        [Export("typeMismatch")]
        public bool TypeMismatch => GetProperty<bool>("typeMismatch");
        [Export("valid")]
        public bool Valid => GetProperty<bool>("valid");
        [Export("valueMissing")]
        public bool ValueMissing => GetProperty<bool>("valueMissing");
        [Export("tooShort")]
        public bool TooShort => GetProperty<bool>("tooShort");
    }
}