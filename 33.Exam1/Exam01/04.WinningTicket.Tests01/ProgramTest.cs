// <copyright file="ProgramTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.WinningTicket;

namespace _04.WinningTicket.Tests
{
    [TestClass]
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramTest
    {

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public void Main(string[] args)
        {
            Program.Main(args);
            // TODO: add assertions to method ProgramTest.Main(String[])
        }
    }
}
