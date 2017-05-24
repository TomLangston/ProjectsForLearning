using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefiningClasses;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestPlayerConstructors()
        {
            var myPlayer = new player("Sanchez", 0);
        }
    }
}
