using System.Collections.Generic;
using NUnit.Framework;

namespace TableParser
{
    [TestFixture]
    public class FieldParserTaskTests
    {
        [TestCase("text", new[] { "text" })]
        [TestCase("hello world", new[] { "hello", "world" })]
        [TestCase("hello  world", new[] { "hello", "world" })]
        [TestCase("hello  'world'", new[] { "hello", "world" })]
        [TestCase("'hello' world", new[] { "hello", "world" })]
        [TestCase("'hello''world'", new[] { "hello", "world" })]
        [TestCase("'hel lo'world", new[] { "hel lo", "world" })]
        [TestCase("''", new[] { "" })]
        [TestCase("'' 'word'", new[] { "", "word" })]
        [TestCase("\"\\\\\"", new[] { "\\" })]
        [TestCase("text ", new[] { "text" })]
        [TestCase("a'bef", new[] { "a", "bef" })]
        [TestCase("'bef ", new[] { "bef " })]
        [TestCase("", new string[] { })]
        [TestCase("\"\'\"'world'", new string[] { "\'", "world" })]
        [TestCase("\"\'\"'wo\"rld'", new string[] { "\'", "wo\"rld" })]
        [TestCase("'\\\'a\\\''", new[] { "'a'" })]
        [TestCase("\"\\\"a\\\"\"", new[] { "\"a\"" })]
        public static void Test(string input, string[] expectedResult)
        {
            var actualResult = FieldsParserTask.ParseLine(input);
            Assert.AreEqual(expectedResult.Length, actualResult.Count);
            for (int i = 0; i < expectedResult.Length; ++i)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i].Value);
            }
        }
        // Скопируйте сюда метод с тестами из предыдущей задачи.
    }

    public class FieldsParserTask
    {
        // При решении этой задаче постарайтесь избежать создания методов, длиннее 10 строк.
        // Подумайте как можно использовать ReadQuotedField и Token в этой задаче.
        public static List<Token> ParseLine(string line)
        {
            return new List<Token> { ReadQuotedField(line, 0) }; // сокращенный синтаксис для инициализации коллекции.
        }
        
        //private static Token ReadField(string line, int startIndex)
        //{
        //    return new Token(line, 0, line.Length);
        //}

        public static Token ReadQuotedField(string line, int startIndex)
        {
            return QuotedFieldTask.ReadQuotedField(line, startIndex);
        }
    }
}