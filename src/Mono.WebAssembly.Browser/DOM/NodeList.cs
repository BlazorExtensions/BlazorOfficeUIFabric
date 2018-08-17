using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("NodeList", typeof(Mono.WebAssembly.JSObject))]
    public sealed class NodeList : JSObject, IEnumerable<Node>, IEnumerable
    {
        public NodeList(int handle) : base(handle) { }

        public NodeList() { }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("item")]
        public Node Item(double index)
        {
            return InvokeMethod<Node>("item", index);
        }
        [IndexerName("TheItem")]
        public Node this[double index] { get => Item(index); set => throw new NotImplementedException(); }

        IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
        {
            return new NodeList.NodeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<JSObject>)this).GetEnumerator();
        }


        private sealed class NodeEnumerator : IEnumerator<Node>, IDisposable, IEnumerator
        {
            private NodeList nodeListCollection;

            private int nodeListIndex;

            private double nodeListCount;

            public Node Current
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

            Node IEnumerator<Node>.Current
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

            public NodeEnumerator(NodeList collection)
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