using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using MyClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
    [TestFixture]
    public class Tests
    {
        [Test]  // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void SingleTest()
        {
            Assert.AreEqual(2, MyClass.MySuperMethod(1, 1));
        }

        [TestCase(1, 2, 3)]  // не нужно помечать атрибутом [Test]
        [TestCase(1, -1, 0)]  // каждый такой атрибут станет отдельным тестом
        [TestCase(-2, -1, -3)]
        public void TestCases(int a, int b, int expectedResult)
        {
            Assert.AreEqual(expectedResult, MyClass.MySuperMethod(a, b));
        }
    }
}
