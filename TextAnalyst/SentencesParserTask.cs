using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var parceSentences = text.Split(new[] { '.', '!', '?', ';', ':', '(', ')' }, 
                System.StringSplitOptions.RemoveEmptyEntries); // .!?;:()
            foreach (var sentense in parceSentences)
            {
                if (sentense!="")
                {
                    var builder = new StringBuilder();
                    foreach (var item in sentense)
                        if (char.IsLetter(item) || item == '\'')
                            builder.Append(item.ToString());
                        else
                            builder.Append(" ");
                    //text.Trim(' ');
                    var txt = builder.ToString();
                    var parceWord = txt.Split(new[] {' '}, System.StringSplitOptions.RemoveEmptyEntries);
                    var listWord = new List<string>();
                    //if (parceWord.Length > 0 && parceWord[0] != "")
                    //{
                       foreach (var item in parceWord)
                        {
                            //if (item!="")
                            listWord.Add(item.ToLower());
                        }
                    //}
                    if (listWord.Count>0)
                    sentencesList.Add(listWord);
                }
            }
            return sentencesList;
        }
    }
}