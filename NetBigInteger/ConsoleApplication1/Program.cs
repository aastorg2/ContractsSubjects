using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool num = true;

            Console.WriteLine(BitConverter.GetBytes(num).Length);
            
            //NetBigInteger.NetBigInteger bigI = new NetBigInteger.NetBigInteger(1, BitConverter.GetBytes(num), 0, BitConverter.GetBytes(num).Length);
            NetBigInteger.NetBigInteger bigI = new NetBigInteger.NetBigInteger(BitConverter.GetBytes(num), 0, BitConverter.GetBytes(num).Length);
            Console.WriteLine(bigI.SignValue);
            Console.WriteLine(bigI.IntValue);
        }
    }
}
