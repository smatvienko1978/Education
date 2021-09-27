using NUnit.Framework;

namespace MyLib.Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void MyLib_Sum_20_30retutns50()
        {
            var a = 20;
            var b = 30;
            var m = new Mathematika();
            var result = m.Sum(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}