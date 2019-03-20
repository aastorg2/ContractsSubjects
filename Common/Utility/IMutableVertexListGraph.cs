using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public delegate bool EdgePredicate<TVertex, TEdge>(TEdge e)
        where TEdge : IEdge<TVertex>;

    public delegate bool VertexPredicate<TVertex>(TVertex v);

    public interface IMutableVertexListGraph<TVertex, TEdge> :
        IMutableIncidenceGraph<TVertex, TEdge>,
        IVertexListGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        event VertexEventHandler<TVertex> VertexAdded;
        void AddVertex(TVertex v);
        void AddVertexRange(IEnumerable<TVertex> vertices);

        event VertexEventHandler<TVertex> VertexRemoved;
        bool RemoveVertex(TVertex v);
        int RemoveVertexIf(VertexPredicate<TVertex> pred);
    }
}
