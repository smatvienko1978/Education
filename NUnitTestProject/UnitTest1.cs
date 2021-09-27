using NUnit.Framework;
using ClassLibrary;

namespace NUnitTestProject
{
    [TestFixture]  // <= это называется атрибут.
                   // Таким атрибутом нужно пометить класс, чтобы система тестирования начала искать в нем тесты.
    public class Tests
    {
        [Test]  // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void SingleTest()
        {
            Assert.AreEqual(2, MySuperClass.MySuperMethod(1, 1));
        }
        [Test]
        public void CoupleTests()
        {
            Assert.AreEqual(5, MySuperClass.MySuperMethod(4, 1));
            Assert.AreNotEqual(5, MySuperClass.MySuperMethod(4, 2));
        }

        [TestCase(1, 2, 3)]  // не нужно помечать атрибутом [Test]
        [TestCase(1, -1, 0)]  // каждый такой атрибут станет отдельным тестом
        [TestCase(-2, -1, -3)]
        

        public void TestCases(int a, int b, int expectedResult)
        {
            Assert.AreEqual(expectedResult, MySuperClass.MySuperMethod(a, b));
        }
    }
}