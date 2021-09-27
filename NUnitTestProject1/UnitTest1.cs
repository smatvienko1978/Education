using NUnit.Framework;
using ConsoleApp22;
using System.Collections.Generic;
//using ConsoleApp22.MyLib;

namespace NUnitTestProject1
{
    public class Tests
    {

        // [Test]
        [TestCase("19:05:45","07:05:45PM")]
        [TestCase("00:05:45", "12:05:45AM")]
        [TestCase("12:05:45", "12:05:45PM")]

        [TestCase("06:40:03", "06:40:03AM")]


        public static void RunTests(string expected24h, string input12h)
        {
            Assert.AreEqual(expected24h, ConsoleApp22.MyLib.timeConversion (input12h));
        }
    }
}