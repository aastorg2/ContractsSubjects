// <copyright file="PexAssemblyInfo.cs" company="Microsoft">Copyright ?Microsoft 2010</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Linq;
using Microsoft.Pex.Framework.Using;
using NetBigInteger;
using System.Text;
using System;
using NUnit.Framework;
// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "NUnit")]
//[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("NetBigInteger")]
[assembly: PexInstrumentAssembly("System.Core")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]

// Microsoft.Pex.Linq
[assembly: PexLinqPackage]

//[assembly: PexUseType(typeof(NetXorEncryption))]
//[assembly: PexInstrumentType(typeof(EncoderFallbackBuffer))]
//[assembly: PexInstrumentType(typeof(Buffer))]
//[assembly: PexInstrumentAssembly("System")]
