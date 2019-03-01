// <copyright file="PexAssemblyInfo.cs">Copyright ? 2017</copyright>
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Moles;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Using;
using DataStructures.Utility;
using Microsoft.Pex.Linq;
using Microsoft.Pex.Framework.Explorable;
using Microsoft.Pex.Framework;
using ReportParserLearning;
//using PexReportParser;
using DataStructures;

//using Pexum.Framework;
//[assembly: Pexum]

//[assembly: PexReportParserExecution]
[assembly: ReportParserExecution]


// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("DataStructures")]
[assembly: PexInstrumentAssembly("System.Core")]

[assembly: PexUseTypeAttribute(typeof(StackEqualityComparer))]
[assembly: PexUseTypeAttribute(typeof(DataStructures.Stack<int>))]
//[assembly: PexUseTypeAttribute(typeof(DictionaryEqualityComparer))]
//[assembly: PexUseTypeAttribute(typeof(HashSetEqualityComparer<int>))]
//[assembly: PexUseTypeAttribute(typeof(DataStructures.HashSet<int>))]
//[assembly: PexUseTypeAttribute(typeof(DataStructures.Dictionary<int,int>))]
//[assembly: PexUseTypeAttribute(typeof(DataStructures.Queue<int>))]


// Microsoft.Pex.Framework.Coverage

[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(StackEqualityComparer))]
[assembly: PexCoverageFilterType(PexCoverageDomain.UserCodeUnderTest, typeof(Stack<int>))]
//[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(HashSetEqualityComparer<int>))]
//[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(QueueEqualityComparer))]
//[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(DictionaryEqualityComparer))]
//[assembly: PexCoverageFilterType(PexCoverageDomain.UserCodeUnderTest, typeof(HashSet<int>))]
//[assembly: PexCoverageFilterType(PexCoverageDomain.UserCodeUnderTest, typeof(Dictionary<int,int>))]
//[assembly: PexCoverageFilterType(PexCoverageDomain.UserCodeUnderTest, typeof(ArrayList))]

//[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(Microsoft.Pex.Framework.PexObserve))]

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

