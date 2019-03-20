using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IVertexListGraph<TVertex, TEdge> :
        IIncidenceGraph<TVertex, TEdge>,
        IVertexSet<TVertex>
        where TEdge : IEdge<TVertex>
    {
    }
}
