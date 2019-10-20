using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Common.Utility4QuickGraph3.Contracts;

namespace Common.Utility4QuickGraph3
{
    [ContractClass(typeof(IImplicitUndirectedGraphContract<,>))]
    public interface IImplicitUndirectedGraph<TVertex, TEdge>
        : IImplicitVertexSet<TVertex>
        , IGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        [Pure]
        EdgeEqualityComparer<TVertex, TEdge> EdgeEqualityComparer { get; }

        [Pure]
        IEnumerable<TEdge> AdjacentEdges(TVertex v);

        [Pure]
        int AdjacentDegree(TVertex v);

        [Pure]
        bool IsAdjacentEdgesEmpty(TVertex v);

        [Pure]
        TEdge AdjacentEdge(TVertex v, int index);

        [Pure]
        bool TryGetEdge(TVertex source, TVertex target, out TEdge edge);

        [Pure]
        bool ContainsEdge(TVertex source, TVertex target);
    }
}
