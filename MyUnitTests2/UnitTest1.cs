﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace MyUnitTests2
{
    [TestClass]
    public class UnitTest
    {
        void Test(double a, double b, double c,
            int length, double x1, double x2)
        {
            var result = QuadricEquation.Solve(a, b, c);
            Assert.AreEqual(length, result.Length);
            if (length > 0)
                Assert.AreEqual(result[0], x1);
            if (length > 1)
                Assert.AreEqual(result[1], x2);
        }



        [TestMethod]
        public void OrdinaryCase()
        {
            Test(2, -4, -6, 2, 3, -1);

        }

        [TestMethod]
        public void NegativeDiscriminant()
        {
            Test(-2, -4, -6, 0, 0, 0);

        }

        [TestMethod]
        public void ZeroA()
        {
            Test(0, 1, 1, 1, -1, 0);
        }

        [TestMethod]
        public void FunctionalTest()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 100; i++)
            {
                var a = rnd.NextDouble() * 10;
                var b = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;
                var solution = QuadricEquation.Solve(a, b, c);
                for (int j = 0; j < solution.Length; j++)
                {
                    Assert.AreEqual(
                        0,
                        a * solution[j] * solution[j] + b * solution[j] + c,
                        10e-6);
                }
            }
        }
    }
}
