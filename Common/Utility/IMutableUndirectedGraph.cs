using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IMutableUndirectedGraph<TVertex, TEdge> :
        IMutableEdgeListGraph<TVertex, TEdge>,
        IUndirectedGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        int RemoveAdjacentEdgeIf(TVertex vertex, EdgePredicate<TVertex, TEdge> predicate);
        void ClearAdjacentEdges(TVertex vertex);
    }
}
