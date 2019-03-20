using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IIncidenceGraph<TVertex, TEdge> : IImplicitGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        bool ContainsEdge(TVertex source, TVertex target);
        bool TryGetEdges(
            TVertex source,
            TVertex target,
            out IEnumerable<TEdge> edges);
        bool TryGetEdge(
            TVertex source,
            TVertex target,
            out TEdge edge);
    }
}
