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
    public class MedianFilterTests
    {
        [Test]
        public void MedianCountTests()
        {
            var oddLeght = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            var evenLeght = new double[] { 1.0, 2.0, 3.0, 4.0};

            Assert.AreEqual(3.0, MedianFilterTask.MedianCount(oddLeght), 0.01);
            Assert.AreEqual(2.5, MedianFilterTask.MedianCount(evenLeght), 0.01);
        }
        [Test]
        public void MedianFilterTest()
        {
            var arr = new double[1, 3] { { 0.1, 0.3, 0.5 } };
            var result = MedianFilterTask.MedianFilter(arr);

            Assert.AreEqual(0.2, result[0,0], 0.01);

        }
    }
}
