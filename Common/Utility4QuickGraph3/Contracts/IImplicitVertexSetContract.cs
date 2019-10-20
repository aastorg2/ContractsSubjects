using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace Common.Utility4QuickGraph3.Contracts
{
    [ContractClassFor(typeof(IImplicitVertexSet<>))]
    abstract class IImplicitVertexSetContract<TVertex>
        : IImplicitVertexSet<TVertex>
    {
        [Pure]
        bool IImplicitVertexSet<TVertex>.ContainsVertex(TVertex vertex)
        {
            IImplicitVertexSet<TVertex> ithis = this;
            Contract.Requires(vertex != null);

            return default(bool);
        }
    }
}
