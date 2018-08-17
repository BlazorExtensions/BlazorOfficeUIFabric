using System;
using System.Runtime.CompilerServices;

using System.Collections;
using System.Collections.Generic;


using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLAreasCollection", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLAreasCollection : JSObject, IEnumerable<HTMLAreaElement>, IEnumerable
    {
        internal HTMLAreasCollection(int handle) : base(handle) { }

        //public HTMLAreasCollection() { }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("item")]
        public HTMLAreaElement Item(double index)
        {
            return InvokeMethod<HTMLAreaElement>("item", index);
        }
        [IndexerName("TheItem")]
        public HTMLAreaElement this[double index] { get => Item(index); set => throw new NotImplementedException(); }

        IEnumerator<HTMLAreaElement> IEnumerable<HTMLAreaElement>.GetEnumerator()
        {
            return new HTMLAreasCollection.AreaEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<JSObject>)this).GetEnumerator();
        }


        private sealed class AreaEnumerator : IEnumerator<HTMLAreaElement>, IDisposable, IEnumerator
        {
            private HTMLAreasCollection areasCollection;

            private int areaCollectionIndex;

            private double areaCollectionCount;

            public HTMLAreaElement Current
            {
                get
                {
                    if (this.areasCollection == null)
                    {
                        throw new ObjectDisposedException("HTMLAreasCollectionEnumerator is disposed");
                    }
                    return this.areasCollection[this.areaCollectionIndex];
                }
            }

            HTMLAreaElement IEnumerator<HTMLAreaElement>.Current
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

            public AreaEnumerator(HTMLAreasCollection collection)
            {
                this.areasCollection = collection;
                this.areaCollectionCount = this.areasCollection.Length;
                this.areaCollectionIndex = -1;
            }

            void IDisposable.Dispose()
            {
                this.areasCollection = null;
            }

            bool IEnumerator.MoveNext()
            {
                this.areaCollectionIndex++;
                return this.areaCollectionIndex < this.areaCollectionCount;
            }

            void IEnumerator.Reset()
            {
                this.areaCollectionIndex = -1;
            }
        }
    }
}