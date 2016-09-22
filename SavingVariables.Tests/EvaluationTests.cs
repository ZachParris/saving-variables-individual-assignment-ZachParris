using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SavingVariables.Tests
{
    [TestClass]
    public class EvaluationTests
    {
        [TestMethod]
        public void CanBeInstantiated()
        {
            Evaluation test = new Evaluation();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void EvaluateAddExpAnswerCorrect()
        {
            Evaluation evaluate = new Evaluation();
            evaluate.Evaluator(1, 2, '+');
            Assert.AreEqual(3, evaluate.answer);
        }
        [TestMethod]
        public void EvaluateSubtractionExpAnswerCorrect()
        {
            Evaluation evaluate = new Evaluation();
            evaluate.Evaluator(6, 3, '-');
            Assert.AreEqual(3, evaluate.answer);
        }
        [TestMethod]
        public void EvaluateMultiplicationExpAnswerCorrect()
        {
            Evaluation evaluate = new Evaluation();
            evaluate.Evaluator(3, 2, '*');
            Assert.AreEqual(6, evaluate.answer);
        }
        [TestMethod]
        public void EvaluateDivisionExpAnswerCorrect()
        {
            Evaluation evaluate = new Evaluation();
            evaluate.Evaluator(6, 2, '/');
            Assert.AreEqual(3, evaluate.answer);
        }
        [TestMethod]
        public void EvaluateModulusExpAnswerCorrect()
        {
            Evaluation evaluate = new Evaluation();
            evaluate.Evaluator(8, 2, '%');
            Assert.AreEqual(0, evaluate.answer);
        }
    }
}
