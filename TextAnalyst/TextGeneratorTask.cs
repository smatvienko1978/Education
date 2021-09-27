using System.Collections.Generic;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(
            Dictionary<string, string> nextWords,
            string phraseBeginning,
            int wordsCount)
        {
            var result = phraseBeginning;
            for (int i = 0; i < wordsCount; i++)
            {
                var parceResult = result.Split();
                if (parceResult.Length==1)
                {
                    result = AddTwoGramm(nextWords, result, parceResult);
                }
                if (parceResult.Length>=2)
                {
                    result = AddThreeGramm(nextWords, result, parceResult);

                }

            }
            return result;
        }

        private static string AddThreeGramm(Dictionary<string, string> nextWords, string result, string[] parceResult)
        {
            var key2Words = parceResult[parceResult.Length - 2] + " " + parceResult[parceResult.Length - 1];
            if (nextWords.ContainsKey(key2Words))
            {
                result += " " + nextWords[key2Words];
            }
            else
            {
                result = AddTwoGramm(nextWords, result, parceResult);
            }

            return result;
        }

        private static string AddTwoGramm(Dictionary<string, string> nextWords, string result, string[] parceResult)
        {
            var key1Word = parceResult[parceResult.Length - 1];
            if (nextWords.ContainsKey(key1Word))
            {
                result += " " + nextWords[key1Word];
            }

            return result;
        }
    }
}