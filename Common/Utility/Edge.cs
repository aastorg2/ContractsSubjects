using System;

namespace Common.Utility
{
    [Serializable]
    public class Edge<TVertex> : IEdge<TVertex>
    {
        private readonly TVertex source;
        private readonly TVertex target;

        public Edge(TVertex source, TVertex target)
        {
            //GraphContracts.AssumeNotNull(source, "source");
            //GraphContracts.AssumeNotNull(target, "target");

            this.source = source;
            this.target = target;
        }

        public static Type VertexType
        {
            get { return typeof(TVertex); }
        }

        public TVertex Source
        {
            get { return this.source; }
        }

        public TVertex Target
        {
            get { return this.target; }
        }

        public override string ToString()
        {
            return String.Format("{0}->{1}", this.Source, this.Target);
        }

        public override bool Equals(object obj)
        {
            EdgeEqualityComparer eq = new EdgeEqualityComparer();
            Edge<int> otherEdge = obj as Edge<int>;
            Edge<int> thisEdge = this as Edge<int>;
            if(otherEdge == null|| thisEdge == null)
                return false;
            
            return eq.Equals(thisEdge,otherEdge);
        }

        public override int  GetHashCode()
        {
            EdgeEqualityComparer eq = new EdgeEqualityComparer();
            Edge<int> thisEdge = this as Edge<int>;
            if (thisEdge == null)
                throw new ArgumentException("only int edges");

            return eq.GetHashCode(thisEdge);
        }
    }
}
