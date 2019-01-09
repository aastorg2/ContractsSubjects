using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Stack.Utility
{
    public class StackEqualityComparer : EqualityComparer<Stack<int>>
    {
        /*ToArray method cause some problem in Pex producing less tests*/
       /* public override bool Equals(Stack<int> s1, Stack<int> s2)
        {
            int[] s1Array = s1.ToArray();
            int[] s2Array = s2.ToArray();
            
            if (s1Array.Length != s2Array.Length)
                return false;

            for (int i = 0; i < s1Array.Length; i++)
            {
                if (s1Array[i] != s2Array[i])
                    return false;
            }

            return true;
        }*/
        public override bool Equals(Stack.Stack<int> s1, Stack.Stack<int> s2)
        {
            if (s1 == null || s2 == null)
                return false;

            return s1.ToStringForInts().Equals(s2.ToStringForInts());
        }

        public override int GetHashCode(Stack.Stack<int> s)
        {
            int hash = 0;
            int[] sArray = s.ToArray();
            for (int i = 0; i < sArray.Length; i++)
            {
                hash += i * sArray[i];
            }

            return hash;

        }
	

    }
}
