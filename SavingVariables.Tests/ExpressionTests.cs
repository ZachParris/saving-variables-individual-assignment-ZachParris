using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SavingVariables.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void ExpCanBeCreated()
        {
            Expression expNotNull = new Expression();
            Assert.IsNotNull(expNotNull);
        }
        [TestMethod]
        public void AcceptsSpaces()
        {
            Expression tester = new Expression();
            tester.Parser("a = 2");
        }
        [TestMethod]
        public void CaptureVariable()
        {
            Expression tester = new Expression();
            tester.Parser("a = 2");
            Assert.AreEqual("a", tester.variable);
        }

        [TestMethod]
        public void CatureValueOfVariable()
        {
            Expression tester = new Expression();
            tester.Parser("a = 2");
            Assert.AreEqual(2, tester.number);
        }

        [TestMethod]
        public void CatchesInvalidExp()
        {
            Expression tester = new Expression();
            tester.Parser("+2");
            Assert.IsTrue(tester.invalidEntry);
        }

        [TestMethod]
        public void CatchesInvalidChar()
        {
            Expression tester = new Expression();
            tester.Parser("2<3");
            Assert.IsTrue(tester.invalidEntry = true);
        }
        [TestMethod]
        public void CatchesInvalidterm()
        {
            Expression tester = new Expression();
            tester.Parser("4*H");
            Assert.IsTrue(tester.invalidEntry = true);
        }
        [TestMethod]
        public void CatchesInvalidNumberOfTerms()
        {
            Expression tester = new Expression();
            tester.Parser("44+99");
            Assert.IsTrue(tester.invalidEntry = true);
        }
    }
}
