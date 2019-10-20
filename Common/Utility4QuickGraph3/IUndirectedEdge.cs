using System;
using System.Diagnostics.Contracts;
using Common.Utility4QuickGraph3.Contracts;

namespace Common.Utility4QuickGraph3
{
    /// <summary>
    /// An undirected edge. 
    /// </summary>
    /// <remarks>
    /// Invariant: source must be less or equal to target (using the default comparer)
    /// </remarks>
    /// <typeparam name="TVertex">type of the vertices</typeparam>
    [ContractClass(typeof(IUndirectedEdgeContract<>))]
    public interface IUndirectedEdge<TVertex>
        : IEdge<TVertex>
    {
    }
}
