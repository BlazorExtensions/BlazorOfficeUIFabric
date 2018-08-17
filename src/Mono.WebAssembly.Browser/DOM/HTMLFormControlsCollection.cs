using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;

using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

    [Export("HTMLFormControlsCollection", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLFormControlsCollection : JSObject, IEnumerable<Element>, IEnumerable
    {
        internal HTMLFormControlsCollection(int handle) : base(handle) { }

        //public HTMLFormControlsCollection() { }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("namedItem")]
        public Element NamedItem(string name)
        {
            return InvokeMethod<Element>("namedItem", name);
        }
        [Export("item")]
        public Element Item(double index)
        {
            return InvokeMethod<Element>("item", index);
        }
        [IndexerName("TheItem")]
        public Element this[double index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IEnumerator<Element> IEnumerable<Element>.GetEnumerator()
        {
            return new HTMLFormControlsCollection.ElementEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<JSObject>)this).GetEnumerator();
        }


        private sealed class ElementEnumerator : IEnumerator<Element>, IDisposable, IEnumerator
        {
            private HTMLFormControlsCollection htmlCollectionCollection;

            private int htmlCollectionIndex;

            private double htmlCollectionCount;

            public Element Current
            {
                get
                {
                    if (this.htmlCollectionCollection == null)
                    {
                        throw new ObjectDisposedException("HTMLCollectionEnumerator is disposed");
                    }
                    return this.htmlCollectionCollection[this.htmlCollectionIndex];
                }
            }

            Element IEnumerator<Element>.Current
            {
                get
                {
                    return this.Current;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public ElementEnumerator(HTMLFormControlsCollection collection)
            {
                this.htmlCollectionCollection = collection;
                this.htmlCollectionCount = this.htmlCollectionCollection.Length;
                this.htmlCollectionIndex = -1;
            }

            void IDisposable.Dispose()
            {
                this.htmlCollectionCollection = null;
            }

            bool IEnumerator.MoveNext()
            {
                this.htmlCollectionIndex++;
                return this.htmlCollectionIndex < this.htmlCollectionCount;
            }

            void IEnumerator.Reset()
            {
                this.htmlCollectionIndex = -1;
            }
        }
    }


}