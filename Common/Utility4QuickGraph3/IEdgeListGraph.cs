using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Common.Utility4QuickGraph3.Contracts;

namespace Common.Utility4QuickGraph3
{
    /// <summary>
    /// A graph whose edges can be enumerated
    /// </summary>
    /// <typeparam name="TVertex">type of the vertices</typeparam>
    /// <typeparam name="TEdge">type of the edges</typeparam>
    [ContractClass(typeof(IEdgeListGraphContract<,>))]
    public interface IEdgeListGraph<TVertex, TEdge> 
        : IGraph<TVertex, TEdge>
        , IEdgeSet<TVertex, TEdge>
        , IVertexSet<TVertex>
        where TEdge : IEdge<TVertex>
    {}
}
