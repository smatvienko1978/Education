using System.Collections.Generic;
using System.IO;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var result = new Dictionary<string, string>();

            var tempList = new Dictionary<string, int>();
            var tempGramm = "";
            foreach (var sentence in text)
            {
                for (int i = 0; i < sentence.Count - 1; i++)
                {
                    tempGramm = sentence[i] + " " + sentence[i + 1];
                    if (tempList.ContainsKey(tempGramm))
                    {
                        tempList[tempGramm]++;
                    }
                    else
                    {
                        tempList.Add(tempGramm, 1);
                    }
                }
                if (sentence.Count >= 2)
                {
                    for (int i = 0; i < sentence.Count - 2; i++)
                    {
                        tempGramm = sentence[i] + " " + sentence[i + 1] + " " + sentence[i + 2];
                        if (tempList.ContainsKey(tempGramm))
                        {
                            tempList[tempGramm]++;
                        }
                        else
                        {
                            tempList.Add(tempGramm, 1);
                        }
                    }
                }
            }


            //var tempSave = new string[tempList.Count];
            //int j = 0;
            //foreach (var item in tempList)
            //{
            //    tempSave[j++] = item.Key + " " + item.Value;
            //}
            //File.WriteAllLines(@"d:\test\test3.txt", tempSave);

            //StreamWriter sw = new StreamWriter(@"d:\test\test.txt", true, System.Text.Encoding.Default);


            foreach (var item in tempList)
            {
                var tempParce = item.Key.ToString().Split(' ');
                if (tempParce.Length <= 2)
                {
                    if (!result.ContainsKey(tempParce[0]))
                    {
                        result.Add(tempParce[0], tempParce[1]);
                    }
                    else
                    {
                        if (tempList[tempParce[0] + " " +
                            result[tempParce[0]]] == item.Value)
                        {
                            if (string.CompareOrdinal(result[tempParce[0]], tempParce[1]) > 0)
                            {
                                result[tempParce[0]] = tempParce[1];
                            }
                        }
                        if (tempList[tempParce[0]+ " "+
                            result[tempParce[0]]] < item.Value)
                        {
                            result[tempParce[0]] = tempParce[1];
                        }
                    }
                }
                if (tempParce.Length > 2)
                {
                    if (!result.ContainsKey(tempParce[0] + " " + tempParce[1]))
                    {
                        result.Add(tempParce[0]+ " " + tempParce[1], tempParce[2]);
                    }
                    else
                    {
                        if (tempList[tempParce[0] + " " + tempParce[1] + " "
                                + result[tempParce[0] + " " + tempParce[1]]] == item.Value)
                        {
                            if (string.CompareOrdinal(result[tempParce[0] + " " + tempParce[1]], tempParce[2]) > 0)
                            {
                                result[tempParce[0] + " " + tempParce[1]] = tempParce[2];
                            }
                        }
                        if ( tempList[tempParce[0] + " " + tempParce[1]+ " "
                                + result[tempParce[0] + " " + tempParce[1]]] < item.Value)
                        {
                            result[tempParce[0] + " " + tempParce[1]] = tempParce[2];
                        }
                    }

                }
            }
            return result;
        }
   }
}