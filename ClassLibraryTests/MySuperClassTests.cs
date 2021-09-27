using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class MySuperClassTests
    {
        [TestMethod()]
        public void MySuperMethodTest_10and20_30returned()
        {
            int a = 10;
            int b = 20;
            int expected = 30;

            int actual = MySuperClass.MySuperMethod(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}