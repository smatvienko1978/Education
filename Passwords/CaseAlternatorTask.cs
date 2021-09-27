using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        //Тесты будут вызывать этот метод
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            // TODO
            //var subWord = word.ToArray();
            if (startIndex == word.Length)
            {
                result.Add(new string(word));
                return;
            }

            var lower = char.ToLower(word[startIndex]);
            var upper = char.ToUpper(word[startIndex]);
            word[startIndex] = lower;
            AlternateCharCases(word, startIndex + 1, result);
            if (lower != upper && char.IsLetter(word[startIndex]))
            {
                word[startIndex] = upper;
                AlternateCharCases(word, startIndex + 1, result);
                if (!result.Contains(new string(word)))
                    result.Add(new string(word));
            }
        }
    }
}