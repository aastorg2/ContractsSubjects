using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IEdge<TVertex>
    {
        TVertex Source { get; }
        TVertex Target { get; }
    }
}
