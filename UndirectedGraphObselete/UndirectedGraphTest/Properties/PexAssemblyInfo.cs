// <copyright file="PexAssemblyInfo.cs">Copyright ? 2017</copyright>
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Moles;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Using;
using UndirectedGraph.Utility;
using Microsoft.Pex.Framework.Explorable;
using Microsoft.Pex.Framework;
//using PexReportParser;
using UndirectedGraph;
using Common.Utility;


//[assembly: PexReportParserExecution]


// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("UndirectedGraph")]
[assembly: PexInstrumentAssembly("System.Core")]

[assembly: PexUseTypeAttribute(typeof(UndirectedGraphEqualityComparer))]


// Microsoft.Pex.Framework.Coverage

[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterType(PexCoverageDomain.UserOrTestCode, typeof(UndirectedGraphEqualityComparer))]
[assembly: PexCoverageFilterType(PexCoverageDomain.UserCodeUnderTest, typeof(UndirectedGraph<int, Edge<int>>))]

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



//[assembly: PexLinqPackage]

