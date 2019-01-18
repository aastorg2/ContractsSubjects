// <copyright file="StackContractTest.PUT_PopContract.g.cs">Copyright �  2019</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Stack;
using Stack.Test.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Stack.Test
{
    public partial class StackContractTest
    {
[TestMethod]
[PexGeneratedBy(typeof(StackContractTest))]
public void PUT_PopContract775()
{
    Stack<int> stack;
    int[] ints = new int[1];
    ints[0] = 10;
    stack = StackFactory.Create(ints);
    this.PUT_PopContract(stack);
    Assert.IsNotNull((object)stack);
    Assert.AreEqual<int>(0, stack.Count);
}
    }
}
