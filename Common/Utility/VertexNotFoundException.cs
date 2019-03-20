using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    [Serializable]
    public class VertexNotFoundException : ApplicationException
    {
        public VertexNotFoundException() { }
        public VertexNotFoundException(string message) : base(message) { }
        public VertexNotFoundException(string message, System.Exception inner) : base(message, inner) { }
        public VertexNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
