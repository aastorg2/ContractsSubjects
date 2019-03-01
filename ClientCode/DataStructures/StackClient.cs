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
        public StackAbstract stack;

        public StackClient()
        {
            this.stack = new StackAbstract();
        }
    
        public StackClient(StackAbstract stack)
        {
            this.stack = stack;
        }

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

        public string ToBinaryStackSummary(int n)
        {
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

    }
}
