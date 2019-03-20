using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IEdgeSet<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        bool IsEdgesEmpty { get; }
        int EdgeCount { get; }
        IEnumerable<TEdge> Edges { get; }
        bool ContainsEdge(TEdge edge);
    }
}
