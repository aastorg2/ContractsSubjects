using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Common.Utility4QuickGraph3.Contracts;

namespace Common.Utility4QuickGraph3
{
    /// <summary>
    /// A mutable vertex set
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    [ContractClass(typeof(IMutableVertexSetContract<>))]
    public interface IMutableVertexSet<TVertex>
        : IVertexSet<TVertex>
    {
        event VertexAction<TVertex> VertexAdded;
        bool AddVertex(TVertex v);
        int AddVertexRange(IEnumerable<TVertex> vertices);

        event VertexAction<TVertex> VertexRemoved;
        bool RemoveVertex(TVertex v);
        int RemoveVertexIf(VertexPredicate<TVertex> pred);
    }
}
