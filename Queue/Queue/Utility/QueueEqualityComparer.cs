using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue.Utility
{
    public class QueueEqualityComparer : EqualityComparer<Queue<int>>
    {

        public override bool Equals(Queue.Queue<int> q1, Queue.Queue<int> q2)
        {
            if (q1 == null || q2 == null)
                return false;

            return q1.ToStringForInts().Equals(q2.ToStringForInts());
        }

        public override int GetHashCode(Queue.Queue<int> q)
        {
            int hash = 0;
            int[] qArray = q.ToArray();
            for (int i = 0; i < qArray.Length; i++)
            {
                hash += i * qArray[i];
            }

            return hash;

        }


    }
}
