//LAST ACTION: Stack.Test.StackContractTest.Void PUT_PeekContract(Stack.Stack`1[System.Int32])
//EXCEPTION: Microsoft.Pex.Framework.Exceptions.PexAssumeFailedException
using Stack.Test;
using Stack.Test.Factories;
using System;
public class RandoopTest4281
{
  public static int Main()
  {
    try
    {
      //BEGIN TEST
      Stack.Test.StackContractTest v0 =  new Stack.Test.StackContractTest();
      System.Int32 v2 = (System.Int32)(-1);
      System.Int32 v3 = (System.Int32)1;
      System.Int32 v4 = (System.Int32)(-10);
      System.Int32[] v5 =  new System.Int32[] {v2 , v3 , v4};
      Stack.Stack<System.Int32> v6 = Stack.Test.Factories.StackFactory.Create((System.Int32[])v5) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v6);

      System.Int32 v7 = (System.Int32)(-2);
      ((Stack.Test.StackContractTest)v0).PUT_ContainsContract((Stack.Stack<System.Int32>)v6, (System.Int32)v7) ;
      System.Int32 v10 = (System.Int32)0;
      System.Int32 v11 = (System.Int32)(-10);
      System.Int32 v12 = (System.Int32)(-1);
      System.Int32 v13 = (System.Int32)10;
      System.Int32[] v14 =  new System.Int32[] {v10 , v11 , v12 , v13};
      Stack.Stack<System.Int32> v15 = Stack.Test.Factories.StackFactory.Create((System.Int32[])v14) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v15);

      ((Stack.Test.StackContractTest)v0).PUT_PopContract((Stack.Stack<System.Int32>)v15) ;
      System.Int32 v18 = (System.Int32)2;
      System.Int32 v19 = (System.Int32)(-10);
      System.Int32 v20 = (System.Int32)(-3);
      System.Int32 v21 = (System.Int32)(-2);
      System.Int32[] v22 =  new System.Int32[] {v18 , v19 , v20 , v21};
      Stack.Stack<System.Int32> v23 = Stack.Test.Factories.StackFactory.Create((System.Int32[])v22) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v23);

      ((Stack.Test.StackContractTest)v0).PUT_PeekContract((Stack.Stack<System.Int32>)v23) ;
      System.Int32[] v26 =  new System.Int32[] {};
      Stack.Stack<System.Int32> v27 = Stack.Test.Factories.StackFactory.Create((System.Int32[])v26) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v27);

      ((Stack.Test.StackContractTest)v0).PUT_PeekContract((Stack.Stack<System.Int32>)v27) ;
      /*
      plan 103 transformer=Stack.Test.StackContractTest constructor Void .ctor() parents=[ ], inputs=[ ]
plan 331 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 31 transformer=(System.Int32)1 parents=[ ], inputs=[ ]
plan 25 transformer=(System.Int32)(-10) parents=[ ], inputs=[ ]
plan 332 transformer=array of System.Int32 of length 3 parents=[ 29 31 25 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 333 transformer=Stack.Test.Factories.StackFactory.Stack.Stack`1[System.Int32] Create(Int32[]) parents=[ 331 332 ], inputs=[ (0 0) (1 0) ]
plan 28 transformer=(System.Int32)(-2) parents=[ ], inputs=[ ]
plan 401 transformer=Stack.Test.StackContractTest.Void PUT_ContainsContract(Stack.Stack`1[System.Int32], Int32) parents=[ 103 333 28 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 249 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 26 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 25 transformer=(System.Int32)(-10) parents=[ ], inputs=[ ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 250 transformer=array of System.Int32 of length 4 parents=[ 26 25 29 34 ], inputs=[ (0 0) (1 0) (2 0) (3 0) ]
plan 251 transformer=Stack.Test.Factories.StackFactory.Stack.Stack`1[System.Int32] Create(Int32[]) parents=[ 249 250 ], inputs=[ (0 0) (1 0) ]
plan 1072 transformer=Stack.Test.StackContractTest.Void PUT_PopContract(Stack.Stack`1[System.Int32]) parents=[ 401 251 ], inputs=[ (0 0) (1 1) ]
plan 1637 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 32 transformer=(System.Int32)2 parents=[ ], inputs=[ ]
plan 25 transformer=(System.Int32)(-10) parents=[ ], inputs=[ ]
plan 27 transformer=(System.Int32)(-3) parents=[ ], inputs=[ ]
plan 28 transformer=(System.Int32)(-2) parents=[ ], inputs=[ ]
plan 1638 transformer=array of System.Int32 of length 4 parents=[ 32 25 27 28 ], inputs=[ (0 0) (1 0) (2 0) (3 0) ]
plan 1639 transformer=Stack.Test.Factories.StackFactory.Stack.Stack`1[System.Int32] Create(Int32[]) parents=[ 1637 1638 ], inputs=[ (0 0) (1 0) ]
plan 1840 transformer=Stack.Test.StackContractTest.Void PUT_PeekContract(Stack.Stack`1[System.Int32]) parents=[ 1072 1639 ], inputs=[ (0 0) (1 1) ]
plan 255 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 256 transformer=array of System.Int32 of length 0 parents=[ ], inputs=[ ]
plan 257 transformer=Stack.Test.Factories.StackFactory.Stack.Stack`1[System.Int32] Create(Int32[]) parents=[ 255 256 ], inputs=[ (0 0) (1 0) ]
plan 4281 transformer=Stack.Test.StackContractTest.Void PUT_PeekContract(Stack.Stack`1[System.Int32]) parents=[ 1840 257 ], inputs=[ (0 0) (1 1) ]
      */
      //END TEST
      System.Console.WriteLine("This was unexpected behavior (expected an exception). Will exit with code 99.");
      return 99;
    }
    catch (Microsoft.Pex.Framework.Exceptions.PexAssumeFailedException e)
    {
      System.Console.WriteLine("//EXCEPTION:" + e.GetType().FullName);
      System.Console.WriteLine("This was expected behavior. Will exit with code 100.");
      return 100;
    }
    catch (System.Exception e)
    {
      System.Console.WriteLine("//EXCEPTION:" + e.GetType().FullName);
      System.Console.WriteLine("//STACK TRACE:");
      System.Console.WriteLine(e.StackTrace);
      System.Console.WriteLine();
      System.Console.WriteLine("This was unexpected behavior. Will exit with code 99.");
      return 99;
    }
  }
}
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\Stack.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\Stack.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\Stack.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\Stack.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Users\AhmadDinkins\LearningContracts\ContractsSubjects\Stack\StackTest\bin\Debug\StackTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
