using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IEdgeListGraph<TVertex, TEdge> :
        IGraph<TVertex, TEdge>,
        IEdgeSet<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {}
}
