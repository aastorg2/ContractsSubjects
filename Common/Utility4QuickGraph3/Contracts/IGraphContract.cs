using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Common.Utility4QuickGraph3.Contracts
{
    [ContractClassFor(typeof(IGraph<,>))]
    abstract class IGraphContract<TVertex, TEdge>
        : IGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        bool IGraph<TVertex, TEdge>.IsDirected
        {
            get { return default(bool); }
        }

        bool IGraph<TVertex, TEdge>.AllowParallelEdges
        {
            get { return default(bool); }
        }
    }
}
