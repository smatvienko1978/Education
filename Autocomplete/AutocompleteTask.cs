using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Autocomplete
{
    internal class AutocompleteTask
    {
        /// <returns>
        /// Возвращает первую фразу словаря, начинающуюся с prefix.
        /// </returns>
        /// <remarks>
        /// Эта функция уже реализована, она заработает, 
        /// как только вы выполните задачу в файле LeftBorderTask
        /// </remarks>
        public static string FindFirstByPrefix(IReadOnlyList<string> phrases, string prefix)
        {
            var index = LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count) + 1;
            if (index < phrases.Count && phrases[index].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return phrases[index];
            
            return null;
        }

        /// <returns>
        /// Возвращает первые в лексикографическом порядке count (или меньше, если их меньше count) 
        /// элементов словаря, начинающихся с prefix.
        /// </returns>
        /// <remarks>Эта функция должна работать за O(log(n) + count)</remarks>
        public static string[] GetTopByPrefix(IReadOnlyList<string> phrases, string prefix, int count)
        {
            // тут стоит использовать написанный ранее класс LeftBorderTask
            var left = LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count)+1;
            var actualCount = Math.Min(count, GetCountByPrefix(phrases, prefix));
            var result = new string[actualCount];
            Array.Copy(phrases.ToArray(), left, result, 0, actualCount);
            return result;
        }

        /// <returns>
        /// Возвращает количество фраз, начинающихся с заданного префикса
        /// </returns>
        public static int GetCountByPrefix(IReadOnlyList<string> phrases, string prefix)
        {
            // тут стоит использовать написанные ранее классы LeftBorderTask и RightBorderTask
            var leftBorder = LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count);
            var rightBorder = RightBorderTask.GetRightBorderIndex(phrases, prefix, -1, phrases.Count);
            return rightBorder - leftBorder-1;
        }
    }

    [TestFixture]
    public class AutocompleteTests
    {
        [Test]
        public void GetCountByPrefixTest()
        {
            var phrases = new List<string> { "a", "ab", "abc", "b" };
            var prefix = "a";
            var expectedResult = 3;
            var result = AutocompleteTask.GetCountByPrefix(phrases, prefix);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetCountByPrefixEmptyTest()
        {
            var phrases = new List<string> { "a", "ab", "abc", "b" };
            var prefix = "c";
            var expectedResult = 0;
            var result = AutocompleteTask.GetCountByPrefix(phrases, prefix);
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void GetTopByPrefixTest()
        {
            var phrases = new List<string> { "a", "ab", "abc", "b" };
            var prefix = "a";
            var count = 2;
            var expectedResult = new[] { "a", "ab" };
            var result = AutocompleteTask.GetTopByPrefix(phrases, prefix, count);
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void GetTopByPrefixTestLessThanCount()
        {
            var phrases = new List<string> { "a", "ab", "abc", "b" };
            var prefix = "a";
            var count = 4;
            var expectedResult = new[] { "a", "ab", "abc" };
            var result = AutocompleteTask.GetTopByPrefix(phrases, prefix, count);
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void GetTopByPrefixTestEmpty()
        {
            var phrases = new List<string> { "a", "ab", "abc", "b" };
            var prefix = "c";
            var count = 2;
            var expectedResult = new string[0];
            var result = AutocompleteTask.GetTopByPrefix(phrases, prefix, count);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
