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
            tester.Parser("1 + 2");
        }
        [TestMethod]
        public void CaptureFirstTerm()
        {
            Expression tester = new Expression();
            tester.Parser("1+2");
            Assert.AreEqual(1, tester.variable);
        }

        [TestMethod]
        public void CaptureOperator()
        {
            Expression opTester = new Expression();
            opTester.Parser("1+2");
            Assert.AreEqual('+', opTester._operator);
        }

        [TestMethod]
        public void CatureSecondTerm()
        {
            Expression tester = new Expression();
            tester.Parser("1+2");
            Assert.AreEqual(2, tester.term_2);
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
