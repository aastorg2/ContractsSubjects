using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Common.Utility4QuickGraph3;

namespace BinaryHeap.Utility
{
    public class BinaryHeapEqualityComparer : EqualityComparer<BinaryHeap<int ,int>>
    {
        public override bool Equals(BinaryHeap<int, int> bh1, BinaryHeap<int, int> bh2)
        {
            if (bh1 == null && bh2 == null)
            {
                return true;
            }
            else if (bh1 == null || bh2 == null)
            {
                return false;
            }
            else
            {
                if (bh1.Count != bh2.Count)
                {
                    return false;
                }

                if (bh1.Capacity != bh2.Capacity)
                {
                    return false;
                }
            }

            return bh1.ToStringForInts().Equals(bh2.ToStringForInts());
        }

        public override int GetHashCode(BinaryHeap<int, int> bh)
        {
            int hash = 0;

            foreach (KeyValuePair<int, int> pair in bh)
            {
                hash += pair.Key * pair.Value;
            }

            return hash;
        }
    }
}
