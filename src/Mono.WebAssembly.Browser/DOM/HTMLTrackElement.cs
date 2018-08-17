using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("HTMLTrackElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTrackElement : HTMLElement, IHTMLTrackElement
    {
        internal HTMLTrackElement(int handle) : base(handle) { }

        //public HTMLTrackElement () { }
        [Export("ERROR")]
        public double Error => GetProperty<double>("ERROR");
        [Export("LOADED")]
        public double Loaded => GetProperty<double>("LOADED");
        [Export("LOADING")]
        public double Loading => GetProperty<double>("LOADING");
        [Export("NONE")]
        public double None => GetProperty<double>("NONE");
        [Export("default")]
        public bool Default { get => GetProperty<bool>("default"); set => SetProperty<bool>("default", value); }
        [Export("kind")]
        public string Kind { get => GetProperty<string>("kind"); set => SetProperty<string>("kind", value); }
        [Export("label")]
        public string Label { get => GetProperty<string>("label"); set => SetProperty<string>("label", value); }
        [Export("readyState")]
        public double ReadyState => GetProperty<double>("readyState");
        [Export("src")]
        public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
        [Export("srclang")]
        public string Srclang { get => GetProperty<string>("srclang"); set => SetProperty<string>("srclang", value); }
        //[Export("track")]
        //public TextTrack Track => GetProperty<TextTrack>("track");
    }
}