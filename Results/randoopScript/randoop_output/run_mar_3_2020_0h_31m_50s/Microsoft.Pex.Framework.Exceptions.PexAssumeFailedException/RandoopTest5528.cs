//LAST ACTION: Dictionary.Test.DictionaryContractTest.Void PUT_GetContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32)
//EXCEPTION: Microsoft.Pex.Framework.Exceptions.PexAssumeFailedException
using Dictionary.Test;
using Dictionary.Test.Factories;
using System;
public class RandoopTest5528
{
  public static int Main()
  {
    try
    {
      //BEGIN TEST
      Dictionary.Test.DictionaryContractTest v0 =  new Dictionary.Test.DictionaryContractTest();
      System.Int32 v2 = (System.Int32)0;
      System.Int32 v3 = (System.Int32)(-1);
      System.Int32[] v4 =  new System.Int32[] {v2 , v3};
      System.Int32 v5 = (System.Int32)10;
      Dictionary.Dictionary<System.Int32, System.Int32> v6 = Dictionary.Test.Factories.DictionaryFactory.createDictionaryArrays((System.Int32[])v4, (System.Int32)v5) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v6);

      System.Int32 v7 = (System.Int32)(-3);
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_RemoveContract((Dictionary.Dictionary<System.Int32, System.Int32>)v6, (System.Int32)v7) ;
      System.Int32 v10 = (System.Int32)0;
      System.Int32 v11 = (System.Int32)(-1);
      System.Int32[] v12 =  new System.Int32[] {v10 , v11};
      System.Int32 v13 = (System.Int32)10;
      Dictionary.Dictionary<System.Int32, System.Int32> v14 = Dictionary.Test.Factories.DictionaryFactory.createDictionaryArrays((System.Int32[])v12, (System.Int32)v13) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v14);

      System.Int32 v15 = (System.Int32)0;
      System.Boolean v16 = ((Dictionary.Test.DictionaryContractTest)v0).testFactoryContains((Dictionary.Dictionary<System.Int32, System.Int32>)v14, (System.Int32)v15) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.AreEqual<System.Boolean>(true, v16,"Regression Failure? [1001]");

      System.Int32 v18 = (System.Int32)(-3);
      System.Int32[] v19 =  new System.Int32[] {v18};
      System.Int32 v20 = (System.Int32)10;
      Dictionary.Dictionary<System.Int32, System.Int32> v21 = Dictionary.Test.Factories.DictionaryFactory.createDictionaryArrays((System.Int32[])v19, (System.Int32)v20) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v21);

      System.Int32 v22 = (System.Int32)2;
      System.Boolean v23 = ((Dictionary.Test.DictionaryContractTest)v0).testFactoryContains((Dictionary.Dictionary<System.Int32, System.Int32>)v21, (System.Int32)v22) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.AreEqual<System.Boolean>(false, v23,"Regression Failure? [1002]");

      System.Int32 v25 = (System.Int32)0;
      System.Int32 v26 = (System.Int32)(-3);
      System.Int32 v27 = (System.Int32)2;
      System.Int32[] v28 =  new System.Int32[] {v25 , v26 , v27};
      System.Int32 v29 = (System.Int32)1;
      Dictionary.Dictionary<System.Int32, System.Int32> v30 = Dictionary.Test.Factories.DictionaryFactory.createDictionaryArrays((System.Int32[])v28, (System.Int32)v29) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v30);

      System.Int32 v31 = (System.Int32)0;
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_GetContract((Dictionary.Dictionary<System.Int32, System.Int32>)v30, (System.Int32)v31) ;
      System.Int32 v34 = (System.Int32)(-2);
      System.Int32[] v35 =  new System.Int32[] {v34};
      System.Int32 v36 = (System.Int32)10;
      Dictionary.Dictionary<System.Int32, System.Int32> v37 = Dictionary.Test.Factories.DictionaryFactory.createDictionaryArrays((System.Int32[])v35, (System.Int32)v36) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v37);

      ((Dictionary.Test.DictionaryContractTest)v0).testFactorySize((Dictionary.Dictionary<System.Int32, System.Int32>)v37) ;
      System.Int32 v40 = (System.Int32)2;
      System.Int32 v41 = (System.Int32)1;
      System.Int32 v42 = (System.Int32)10;
      System.Int32[] v43 =  new System.Int32[] {v40 , v41 , v42};
      System.Int32 v44 = (System.Int32)(-1);
      System.Int32 v45 = (System.Int32)(-2);
      System.Int32 v46 = (System.Int32)2;
      System.Int32[] v47 =  new System.Int32[] {v44 , v45 , v46};
      Dictionary.Dictionary<System.Int32, System.Int32> v48 = Dictionary.Test.Factories.DictionaryFactory.Create((System.Int32[])v43, (System.Int32[])v47) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v48);

      System.Int32 v49 = (System.Int32)(-1);
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_GetContract((Dictionary.Dictionary<System.Int32, System.Int32>)v48, (System.Int32)v49) ;
      /*
      plan 121 transformer=Dictionary.Test.DictionaryContractTest constructor Void .ctor() parents=[ ], inputs=[ ]
plan 112 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 26 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 113 transformer=array of System.Int32 of length 2 parents=[ 26 29 ], inputs=[ (0 0) (1 0) ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 114 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 112 113 34 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 27 transformer=(System.Int32)(-3) parents=[ ], inputs=[ ]
plan 132 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_RemoveContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 121 114 27 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 112 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 26 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 113 transformer=array of System.Int32 of length 2 parents=[ 26 29 ], inputs=[ (0 0) (1 0) ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 114 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 112 113 34 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 30 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 142 transformer=Dictionary.Test.DictionaryContractTest.Boolean testFactoryContains(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 132 114 30 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 549 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 27 transformer=(System.Int32)(-3) parents=[ ], inputs=[ ]
plan 550 transformer=array of System.Int32 of length 1 parents=[ 27 ], inputs=[ (0 0) ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 551 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 549 550 34 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 32 transformer=(System.Int32)2 parents=[ ], inputs=[ ]
plan 1604 transformer=Dictionary.Test.DictionaryContractTest.Boolean testFactoryContains(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 142 551 32 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 292 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 30 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 27 transformer=(System.Int32)(-3) parents=[ ], inputs=[ ]
plan 32 transformer=(System.Int32)2 parents=[ ], inputs=[ ]
plan 293 transformer=array of System.Int32 of length 3 parents=[ 30 27 32 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 31 transformer=(System.Int32)1 parents=[ ], inputs=[ ]
plan 294 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 292 293 31 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 26 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 1771 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_GetContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 1604 294 26 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 4207 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 28 transformer=(System.Int32)(-2) parents=[ ], inputs=[ ]
plan 4208 transformer=array of System.Int32 of length 1 parents=[ 28 ], inputs=[ (0 0) ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 4209 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 4207 4208 34 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 4826 transformer=Dictionary.Test.DictionaryContractTest.Void testFactorySize(Dictionary.Dictionary`2[System.Int32,System.Int32]) parents=[ 1771 4209 ], inputs=[ (0 0) (1 1) ]
plan 3734 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 32 transformer=(System.Int32)2 parents=[ ], inputs=[ ]
plan 31 transformer=(System.Int32)1 parents=[ ], inputs=[ ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 3735 transformer=array of System.Int32 of length 3 parents=[ 32 31 34 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 28 transformer=(System.Int32)(-2) parents=[ ], inputs=[ ]
plan 32 transformer=(System.Int32)2 parents=[ ], inputs=[ ]
plan 3736 transformer=array of System.Int32 of length 3 parents=[ 29 28 32 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 3737 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] Create(Int32[], Int32[]) parents=[ 3734 3735 3736 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 5528 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_GetContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 4826 3737 29 ], inputs=[ (0 0) (1 1) (2 0) ]
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Dictionary.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Dictionary.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Dictionary.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Dictionary.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Dictionary.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Dictionary.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\Utility.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
//REFASSEMBLY: c:\Users\AhmadDinkins\LearningContracts2\ContractsSubjects\Dictionary\DictionaryTest\bin\Debug\DictionaryTest.dll
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
