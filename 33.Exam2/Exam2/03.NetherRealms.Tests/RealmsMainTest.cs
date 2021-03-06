// <copyright file="RealmsMainTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03.NetherRealms;

namespace _03.NetherRealms.Tests
{
    [TestClass]
    [PexClass(typeof(RealmsMain))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RealmsMainTest
    {

        [PexMethod(MaxRunsWithoutNewTests = 200)]
        [PexAllowedException(typeof(NullReferenceException))]
        public void Main(string[] args)
        {
            RealmsMain.Main(args);
            // TODO: add assertions to method RealmsMainTest.Main(String[])
        }
    }
}
