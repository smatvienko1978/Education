using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class SolverTests
    {
        void TestEquation (double a, double b, double c, params double [] expextedResult)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);
            Assert.AreEqual(expextedResult.Length, result.Length);
            for (int i = 0; i < expextedResult.Length; i++)
                Assert.AreEqual(expextedResult[i], result[i]);
        }
        [TestMethod]
        public void OrdinaryEquation()
        {
            //// Assign:
            //var a = 1;
            //var b = -3;
            //var c = 2;
            ////Act:
            //var result = QuadraticEquationSolver.Solve(a, b, c);
            ////Assert:
            //Assert.AreEqual(2, result.Length);
            //Assert.AreEqual(2, result[0]);
            //Assert.AreEqual(1, result[1]);

            TestEquation(1, -3, 2,  2, 1 );
        }
        [TestMethod]
        public void NegativeDiscriminant()
        {
            //var a = 1;
            //var b = 1;
            //var c = 1;
            ////Act:
            //var result = QuadraticEquationSolver.Solve(a, b, c);
            ////Assert:
            //Assert.AreEqual(0, result.Length);

            TestEquation(1, -1, 1);

        }
    }
}
