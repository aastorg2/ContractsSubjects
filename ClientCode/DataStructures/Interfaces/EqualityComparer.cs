using System;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security;

namespace DataStructures.Interfaces
{
    public abstract partial class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
    {
        protected EqualityComparer() { }
        public static EqualityComparer<T> Default { get { throw null; } }
        public abstract bool Equals(T x, T y);
        public abstract int GetHashCode(T obj);
        bool IEqualityComparer.Equals(object x, object y) { throw null; }
        int IEqualityComparer.GetHashCode(object obj) { throw null; }
    }
    
}
