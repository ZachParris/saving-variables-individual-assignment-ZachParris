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
            tester.lastInput = "1+2";
            Assert.AreEqual("1+2", tester.lastInput);
        }
        [TestMethod]
        public void CanGetLastAnswer()
        {
            Stack tester = new Stack();
            Assert.AreEqual(0, tester.lastResult);
        }
    }
}
