using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SavingVariables.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackCanBeCreated()
        {
            Stack tester = new Stack();
            Assert.IsNotNull(tester);
        }
        [TestMethod]
        public void CanGetLastEquation()
        {
            Stack tester = new Stack();
            tester.lastInput = "a = 2";
            Assert.AreEqual("a = 2", tester.lastInput);
        }
    }
}
