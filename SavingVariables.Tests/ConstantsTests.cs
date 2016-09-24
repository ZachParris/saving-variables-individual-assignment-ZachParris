using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SavingVariables.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void ConstCanBeInstantiated()
        {
            Constants tester = new Constants();
            Assert.IsNotNull(tester);
        }
        [TestMethod]
        public void ConstantsCanBeAddedToRepository()
        {
            Constants tester = new Constants();
            char x = default(char);
            tester.AddVariableToRepository(x, 1);
            Assert.AreEqual(tester.GetConstant(x), 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionThrownForExistingVar()
        {
            Constants tester = new Constants();
            char x = default(char);
            tester.AddVariableToRepository(x, 1);
            tester.AddVariableToRepository(x, 2);
        }
    }
}
