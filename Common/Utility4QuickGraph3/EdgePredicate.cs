using System;
using System.Diagnostics.Contracts;

namespace Common.Utility4QuickGraph3
{
    [Pure]
    public delegate bool EdgePredicate<TVertex, TEdge>(TEdge e)
        where TEdge : IEdge<TVertex>;
}
