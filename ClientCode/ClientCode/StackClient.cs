using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientAPI;
using Stack;
using PexAPIWrapper;

namespace ClientAPI
{
    public class StackClient
    {
        AbstractStack stack;

        public StackClient()
        {
            this.stack = new AbstractStack(-1, 0, false);
        }
    
        public StackClient(AbstractStack stack)
        {
            if (stack == null)
                this.stack = new AbstractStack(-1, 0, false);
            else
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
            int currbit = -2;
            while (n > 0)
            {
                currbit = n % 2;
                stack.Push(currbit);
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
