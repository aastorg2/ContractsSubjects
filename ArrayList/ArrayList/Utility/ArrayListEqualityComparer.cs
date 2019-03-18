using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ArrayList.Utility
{
    
    public class ArrayListEqualityComparer : EqualityComparer<ArrayList>
    {

        public override bool Equals(ArrayList q1, ArrayList q2)
        {
            // handle null cases first
            if (q1 == null)
            {
                return (q2 == null);
            }
            else if (q2 == null)
            {
                // set1 != null
                return false;
            }
            else if (q1.Count != q2.Count)
                return false;

            for (int i = 0; i < q1.Count; i++)
            {
                if (!q1[i].Equals(q2[i]))
                    return false;

            }
            return true;
        }
        /* Angello's code: Only works for ints*/
        public override int GetHashCode(ArrayList q)
        {
            int hash = 0;
            for (int i = 0; i < q.Count; i++)
            {
                hash += q[i].GetHashCode();
            }

            return hash;

        }


    }
}
