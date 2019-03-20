using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Utility
{
    public class EdgeEqualityComparer : EqualityComparer<Edge<int>>
    {
        public EdgeEqualityComparer(){

        }

        public override bool Equals(Edge<int> e1, Edge<int> e2)
        {
            if (e1 == null || e2 == null)
            {
                return false;
            }
            else
            {
                if ((e1.Target == (e2.Target) && e1.Source == (e2.Source)) ||(e1.Target == (e2.Source) && e1.Source ==(e2.Target)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode(Edge<int> e)
        {
            int hash = 0;

            if (e != null)
            {
                hash += e.Source *  e.Target;
            }

            return hash;
        }
    }
}
