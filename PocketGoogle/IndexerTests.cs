using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace PocketGoogle
{
    [TestFixture]
    public class IndexerTests
    {
        [Test]
        public void GetPositions()
        {
            // TODO: Add your test code here
            //var answer = 42;
            //Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            var ind = new Indexer();
            ind.Add(0, "A B C");
            ind.Add(1, "B C");
            ind.Add(2, "A C A C");
            ind.Add(3, "F, f ff");

            var getResult = ind.GetPositions(3, "f");
            var result = "";
            for (int i = 0; i < getResult.Count; i++)
            {
                result += getResult[i].ToString();
                if (i < getResult.Count-1)
                    result += ", ";
            }
            Assert.AreEqual("3", result);

        }
    }
}
