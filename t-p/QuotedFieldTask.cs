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

        [TestCase("' '", 0, " ", 3)]
        [TestCase("'a '", 0, "a ", 4)]
        [TestCase("'a ", 0, "a ", 3)]
        [TestCase("' a'bcd", 0, " a", 4)]

        [TestCase("\"a\"b", 0, "a", 3)]
        [TestCase("'QF \"'", 0, "QF \"", 7)]
      //  [TestCase("aa\"a\'", 2, "a\'", 4)]
        [TestCase("\"a'\"", 0, "a\'", 4)]
        
        //[TestCase("a 'b' 'c' d", 0, "a b c d", 9)]

        public void Test(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(new Token(expectedValue, startIndex, expectedLength), actualToken);
        }
    }

    class QuotedFieldTask
    {
        public static Token ReadQuotedField(string line, int startIndex)
        {
            char startEndQuote = line[startIndex];
            char innerQuote = InnerQuote(startEndQuote);
            int closeQuote = 0;

            var field = line.Substring(startIndex+1); // start trim
            if (field.IndexOf(startEndQuote) >= 0)
                field = field.Substring(0, field.IndexOf(startEndQuote));  // end trim to quote
            else
                closeQuote = -1;

            int serviceSymbolCount = ServiceSymbolCounter(field);
            //if (startEndQuote == '\"')
            //    serviceSymbolCount--;

            return new Token(field, startIndex, field.Length + serviceSymbolCount + closeQuote);
        }
        private static int ServiceSymbolCounter(string field)
        {
            int result = 0 ;
            foreach (var item in field)
            {
                if (item == '\\' || item == '\"' )//|| item == '\'')
                    result++;
            }
            return result+2;
        }

        private static char InnerQuote(char startEndQuote)
        {
            if (startEndQuote == '\'')
                return '\"';
            else return '\'';
        }
    }
}
