// <copyright file="PexAssemblyInfo.cs">Copyright ? 2017</copyright>
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Moles;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Using;
using Microsoft.Pex.Linq;
using Microsoft.Pex.Framework.Explorable;
using Microsoft.Pex.Framework;
using ClientAPI;
using Stack;
//using Pexum.Framework;
//[assembly: Pexum]

//[assembly: PexReportParserExecution]


// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("ClientCode")]
[assembly: PexInstrumentAssembly("System.Core")]

[assembly: PexUseTypeAttribute(typeof(Stack.Utility.StackEqualityComparer))]
[assembly: PexUseTypeAttribute(typeof(Stack.Stack<int>))]
//[assembly: PexUseTypeAttribute(typeof(DictionaryEqualityComparer))]
//[assembly: PexUseTypeAttribute(typeof(HashSetEqualityComparer<int>))]
//[assembly: PexUseTypeAttribute(typeof(DataStructures.HashSet<int>))]
//[assembly: PexUseTypeAttribute(typeof(DataStructures.Dictionary<int,int>))]
//[assembly: PexUseTypeAttribute(typeof(DataStructures.Queue<int>))]


// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterType(PexCoverageDomain.UserCodeUnderTest, typeof(StackClient))]
//[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, typeof(AbstractStack))]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(Stack.Utility.StackEqualityComparer))]
[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(Stack.Stack<int>))]


// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]
// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Moles
[assembly: PexAssumeContractEnsuresFailureAtBehavedSurface]
[assembly: PexChooseAsBehavedCurrentBehavior]

[assembly: PexInstrumentAssembly("Microsoft.VisualBasic", InstrumentationLevel = PexInstrumentationLevel.Excluded)]



[assembly: PexLinqPackage]

