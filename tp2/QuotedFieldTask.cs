using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TableParser
{
    [TestFixture]
    public class QuotedFieldTaskTests
    {
        [TestCase("''", 0, "", 2)]
        [TestCase("'a'", 0, "a", 3)]

        [TestCase("a 'b' 'c' d", 0, "a b c d", 9)]
        [TestCase("a\"b", 0, "a\"b", 6)]
        [TestCase("QF \"", 0, "QF \"", 7)]
        public void Test(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(new Token(expectedValue, startIndex, expectedLength), actualToken);
        }
       
        // Добавьте свои тесты
        
    }

    class QuotedFieldTask
    {
        public static Token ReadQuotedField(string line, int startIndex)
        {
            var builder = new StringBuilder();
            var endLine = line[startIndex];
            var charArray = line.ToCharArray();

            for (int i = 0 ; i < charArray.Length; i++)
            {
                if (charArray[i].ToString() == @"'")
                    continue;
                    
                if (charArray[i] == endLine && i>startIndex)
                    break;

                builder.Append(charArray[i].ToString());

            }
            var result = builder.ToString();
            var slash = 0;
            foreach (var item in result)
            {
                if (item=='\\' || item=='\"')
                {
                    slash++;
                }
            }
            return new Token(result, startIndex, result.Length+2+slash);
        }
    }
}
