using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("NodeList", typeof(Mono.WebAssembly.JSObject))]
    public sealed class NodeListOf<T> : JSObject, IEnumerable<T>, IEnumerable
    {
        public NodeListOf(int handle) : base(handle) { }

        public NodeListOf() { }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("item")]
        public T Item(double index)
        {
            return InvokeMethod<T>("item", index);
        }
        [IndexerName("TheItem")]
        public T this[double index] { get => Item(index); set => throw new NotImplementedException(); }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new NodeListOf<T>.NodeEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }


        private sealed class NodeEnumerator<U> : IEnumerator<U>, IDisposable, IEnumerator
        {
            private NodeListOf<U> nodeListCollection;

            private int nodeListIndex;

            private double nodeListCount;

            public U Current
            {
                get
                {
                    if (this.nodeListCollection == null)
                    {
                        throw new ObjectDisposedException("NodeListEnumerator is disposed");
                    }
                    return this.nodeListCollection[this.nodeListIndex];
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

            public NodeEnumerator(NodeListOf<U> collection)
            {
                this.nodeListCollection = collection;
                this.nodeListCount = this.nodeListCollection.Length;
                this.nodeListIndex = -1;
            }

            void IDisposable.Dispose()
            {
                this.nodeListCollection = null;
            }

            bool IEnumerator.MoveNext()
            {
                this.nodeListIndex++;
                return this.nodeListIndex < this.nodeListCount;
            }

            void IEnumerator.Reset()
            {
                this.nodeListIndex = -1;
            }
        }

    }

}