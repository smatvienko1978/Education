using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Autocomplete
{
    [TestFixture]
    public class LeftBorderTests
    {
        [Test]
        public void LeftBorderTest1()
        {
            // TODO: Add your test code here
            //var answer = 42;
            //Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            List<string> phrases = new List<string>() { "a", "ab", "abc" };
            phrases.AsReadOnly();
            string prefix = "ab";
            int expected = 0;

            Assert.AreEqual(expected, LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count));
        }
    }
}
