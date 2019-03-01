using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using DataStructures.Utility;
using PexAPIWrapper;

namespace DataStructures
{
    public class StackClient
    {
        

        public string ToBinaryStack(int n)
        {
            Stack<int>stack = new Stack<int>();
            string output = "";
            while (n > 0)
            {
                stack.Push(n % 2);
                n /= 2;
            }
            while (stack.Count > 0)
            {
                output += stack.Pop().ToString(); 
            }
            return output;
        }

        //public string ToBinaryStackSummary(int n)
        //{
        //    StackAbstract stack = new StackAbstract();

        //    string output = "";
        //    int currBit = -1;

        //    while (n > 0)
        //    {
        //        currBit = n % 2;
        //        stack.Push(currBit);
                
        //        n /= 2;
        //    }
        //    while (stack.Count > 0)
        //    {
        //        output += stack.Pop().ToString();
        //    }
        //    return output;
        //}

        public string ToBinaryStackSummary(int n)
        {
            Stack<int> stack = new Stack<int>();

            string output = "";
            int oldBit = -1;
            int currBit = -1;
            int oldCount = 0;


            while (n > 0)
            {
                currBit = n % 2;
                oldBit = currBit;
                oldCount = stack.Count;
                //stack.Push(currBit);

                PexAssert.IsTrue(true);
                PexAssume.IsTrue((stack.Count > 0 ? stack.Peek() == currBit : true) && currBit == oldBit && stack.Contains(currBit) && stack.Count == oldCount + 1);
                n /= 2;
            }
            while (stack.Count > 0)
            {
                output += stack.Pop().ToString();
            }
            return output;
        }

    }
}
