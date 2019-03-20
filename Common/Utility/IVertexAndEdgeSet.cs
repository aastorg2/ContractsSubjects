using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IVertexAndEdgeSet<TVertex, TEdge> :
        IVertexSet<TVertex>,
        IEdgeListGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
    }
}
