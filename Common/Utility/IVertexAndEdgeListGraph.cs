using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IVertexAndEdgeListGraph<TVertex,TEdge> :
        IVertexListGraph<TVertex,TEdge>,
        IEdgeListGraph<TVertex,TEdge>,
        IVertexAndEdgeSet<TVertex,TEdge>
        where TEdge : IEdge<TVertex>
    {}
}
