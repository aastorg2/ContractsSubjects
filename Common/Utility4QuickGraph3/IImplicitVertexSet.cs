using System;
using System.Diagnostics.Contracts;
using Common.Utility4QuickGraph3.Contracts;

namespace Common.Utility4QuickGraph3
{
    /// <summary>
    /// An implicit set of vertices
    /// </summary>
    /// <typeparam name="TVertex">type of the vertices</typeparam>
    [ContractClass(typeof(IImplicitVertexSetContract<>))]
    public interface IImplicitVertexSet<TVertex>
    {
        /// <summary>
        /// Determines whether the specified vertex contains vertex.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// 	<c>true</c> if the specified vertex contains vertex; otherwise, <c>false</c>.
        /// </returns>
        [Pure]
        bool ContainsVertex(TVertex vertex);
    }
}
