using System;
using System.Diagnostics.Contracts;

namespace Common.Utility4QuickGraph3
{
    [Pure]
    public delegate bool VertexPredicate<TVertex>(TVertex v);
}
