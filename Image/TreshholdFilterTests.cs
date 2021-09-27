using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Recognizer
{

    [TestFixture]
    public class TreshholdFilterTests
    {
        [Test]
        public void TestMethodImage1x1Fraction0()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { {123 } }, 0.0);
            var expected = new double[,] { { 0 } };

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestMethodImage1x1Fraction1()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { { 123 } }, 1.0);
            var expected = new double[,] { { 1 } };

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestMethodImage1x1Fraction0_5()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { { 123 } }, 0.5);
            var expected = new double[,] { { 0 } };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestMethodImage1x2Fraction0_5()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { { 1, 2 } }, 0.5);
            var expected = new double[,] { { 0, 1 } };

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestMethodImage1x2Fraction0_5_2()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { { 1, 0 } }, 0.5);
            var expected = new double[,] { { 1, 0 } };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestMethodImage1x4Fraction0_5()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { { 1, 2, 2, 3 } }, 0.5);
            var expected = new double[,] { { 0, 1, 1, 1 } };

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestMethod3_3()
        {
            var result = ThresholdFilterTask.ThresholdFilter(
                new double[,] { { 0.8, 0.7, 0.7 }, { 0.9, 0.9, 0.6 }, { 0, 0.1, 0.1 } }, 0.2);
            var expected = new double[,] { { 0, 0, 0 }, { 1, 1, 0 }, { 0, 0, 0 } };

            Assert.AreEqual(expected, result);
        }

    }
}
