//LAST ACTION: Dictionary.Test.DictionaryContractTest.Void PUT_GetContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32)
//EXCEPTION: Microsoft.Pex.Framework.Exceptions.PexAssumeFailedException
using Dictionary.Test;
using Dictionary.Test.Factories;
using System;
public class RandoopTest5109
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

      System.Int32 v7 = (System.Int32)3;
      System.Int32 v8 = (System.Int32)2;
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_SetContract((Dictionary.Dictionary<System.Int32, System.Int32>)v6, (System.Int32)v7, (System.Int32)v8) ;
      System.Int32[] v11 =  new System.Int32[] {};
      System.Int32 v12 = (System.Int32)3;
      Dictionary.Dictionary<System.Int32, System.Int32> v13 = Dictionary.Test.Factories.DictionaryFactory.createDictionaryArrays((System.Int32[])v11, (System.Int32)v12) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v13);

      System.Int32 v14 = (System.Int32)0;
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_RemoveContract((Dictionary.Dictionary<System.Int32, System.Int32>)v13, (System.Int32)v14) ;
      System.Int32 v17 = (System.Int32)(-1);
      System.Int32[] v18 =  new System.Int32[] {v17};
      System.Int32 v19 = (System.Int32)(-10);
      System.Int32[] v20 =  new System.Int32[] {v19};
      Dictionary.Dictionary<System.Int32, System.Int32> v21 = Dictionary.Test.Factories.DictionaryFactory.Create((System.Int32[])v18, (System.Int32[])v20) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v21);

      System.Int32 v22 = (System.Int32)0;
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_ContainsValueContract((Dictionary.Dictionary<System.Int32, System.Int32>)v21, (System.Int32)v22) ;
      System.Int32 v25 = (System.Int32)(-3);
      System.Int32[] v26 =  new System.Int32[] {v25};
      System.Int32 v27 = (System.Int32)10;
      System.Int32[] v28 =  new System.Int32[] {v27};
      Dictionary.Dictionary<System.Int32, System.Int32> v29 = Dictionary.Test.Factories.DictionaryFactory.Create((System.Int32[])v26, (System.Int32[])v28) ;
      //Regression assertion (captures the current behavior of the code)
      Assert.IsNotNull(v29);

      System.Int32 v30 = (System.Int32)(-10);
      ((Dictionary.Test.DictionaryContractTest)v0).PUT_GetContract((Dictionary.Dictionary<System.Int32, System.Int32>)v29, (System.Int32)v30) ;
      /*
      plan 121 transformer=Dictionary.Test.DictionaryContractTest constructor Void .ctor() parents=[ ], inputs=[ ]
plan 112 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 26 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 113 transformer=array of System.Int32 of length 2 parents=[ 26 29 ], inputs=[ (0 0) (1 0) ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 114 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 112 113 34 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 33 transformer=(System.Int32)3 parents=[ ], inputs=[ ]
plan 32 transformer=(System.Int32)2 parents=[ ], inputs=[ ]
plan 127 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_SetContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32, Int32) parents=[ 121 114 33 32 ], inputs=[ (0 0) (1 1) (2 0) (3 0) ]
plan 223 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 224 transformer=array of System.Int32 of length 0 parents=[ ], inputs=[ ]
plan 33 transformer=(System.Int32)3 parents=[ ], inputs=[ ]
plan 225 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] createDictionaryArrays(Int32[], Int32) parents=[ 223 224 33 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 26 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 287 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_RemoveContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 127 225 26 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 244 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 29 transformer=(System.Int32)(-1) parents=[ ], inputs=[ ]
plan 245 transformer=array of System.Int32 of length 1 parents=[ 29 ], inputs=[ (0 0) ]
plan 25 transformer=(System.Int32)(-10) parents=[ ], inputs=[ ]
plan 246 transformer=array of System.Int32 of length 1 parents=[ 25 ], inputs=[ (0 0) ]
plan 247 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] Create(Int32[], Int32[]) parents=[ 244 245 246 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 30 transformer=(System.Int32)0 parents=[ ], inputs=[ ]
plan 2221 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_ContainsValueContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 287 247 30 ], inputs=[ (0 0) (1 1) (2 0) ]
plan 3325 transformer=DummyTransformer parents=[ ], inputs=[ ]
plan 27 transformer=(System.Int32)(-3) parents=[ ], inputs=[ ]
plan 3326 transformer=array of System.Int32 of length 1 parents=[ 27 ], inputs=[ (0 0) ]
plan 34 transformer=(System.Int32)10 parents=[ ], inputs=[ ]
plan 3327 transformer=array of System.Int32 of length 1 parents=[ 34 ], inputs=[ (0 0) ]
plan 3328 transformer=Dictionary.Test.Factories.DictionaryFactory.Dictionary.Dictionary`2[System.Int32,System.Int32] Create(Int32[], Int32[]) parents=[ 3325 3326 3327 ], inputs=[ (0 0) (1 0) (2 0) ]
plan 25 transformer=(System.Int32)(-10) parents=[ ], inputs=[ ]
plan 5109 transformer=Dictionary.Test.DictionaryContractTest.Void PUT_GetContract(Dictionary.Dictionary`2[System.Int32,System.Int32], Int32) parents=[ 2221 3328 25 ], inputs=[ (0 0) (1 1) (2 0) ]
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
