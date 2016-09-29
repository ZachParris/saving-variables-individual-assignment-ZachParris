using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SavingVariables.DAL;
using Moq;

namespace SavingVariables.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        Mock<VariablesRepository> mock_repo { get; set; }
        
        [TestInitialize]
        public void Initialize()
        {
            mock_repo = new Mock<VariablesRepository>();
        }

        [TestMethod]
        public void ConstCanBeInstantiated()
        {
            Constants tester = new Constants();
            Assert.IsNotNull(tester);
        }

        [TestMethod]
        public void VariablesCanBeAddedToRepository()
        {
            Constants tester = new Constants(mock_repo.Object);
            string x = "x";
            tester.AddVariableToRepository(x, 1);
            mock_repo.Verify(r => r.AddVariableAndValue(x, 1), Times.Once());
        }
    }
}
