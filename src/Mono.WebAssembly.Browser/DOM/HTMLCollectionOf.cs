using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;

using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLCollection", typeof(Mono.WebAssembly.JSObject))]
    public class HTMLCollectionOf<T> : JSObject, IEnumerable<T>, IEnumerable 
    {

        public HTMLCollectionOf(int handle) : base(handle) { }

        public HTMLCollectionOf() { }

        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("namedItem")]
        public T NamedItem(string name)
        {
            return InvokeMethod<T>("namedItem", name);
        }
        [Export("item")]
        public T Item(double index)
        {
            return InvokeMethod<T>("item", index);
        }
        [IndexerName("TheItem")]
        public T this[double index] { get => Item(index); set => throw new NotImplementedException(); }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new HTMLCollectionOf<T>.ElementEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }


        private sealed class ElementEnumerator<U> : IEnumerator<U>, IDisposable, IEnumerator
        {
            private HTMLCollectionOf<U> htmlCollectionCollection;

            private int htmlCollectionIndex;

            private double htmlCollectionCount;

            public U Current
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

            U IEnumerator<U>.Current
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

            public ElementEnumerator(HTMLCollectionOf<U> collection)
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