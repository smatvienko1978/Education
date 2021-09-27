using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeighedUniformString
{
    class Program
    {
        public static List<string> weightedUniformStrings(string s, List<int> queries)
        {
            List<string> subStrings = GetSubStrings(s);
            List<int> weightStrings = GetWeightStrings(subStrings);
            return GetCrossList(weightStrings, queries);

        }

        private static List<int> GetWeightStrings(List<string> subStrings)
        {
            var result = new List<int>();
            foreach (var item in subStrings)
            {
                int weight = 0;
                foreach (var ch in item)
                {
                    weight += (int)ch - 96;
                }
                result.Add(weight);
            }
            //foreach (var item in result)
            //    Console.WriteLine(item);
            return result;
        }

        private static List<string> GetSubStrings(string s)
        {
            var result = new List<string>();
            int itemLeght = 0;
            for (int i = 0; i < s.Length; i++)
            {



                string item = "";
                itemLeght = 0;
                while (i + itemLeght < s.Length)
                {
                    if (s[i] == s[i + itemLeght])   //(s[i].Equals(s[i + itemLeght]))
                    {
                        item += s[i + itemLeght];
                        result.Add(item);
                        itemLeght++;
                    }
                    else
                    {
                        i += itemLeght - 1;
                        break;
                    }
                }
                if (i + itemLeght == s.Length)
                    break;
            }
            //foreach (var item in result)
            //    Console.WriteLine(item);
            return result;
        }



        private static List<string> GetCrossList(List<int> weightStrings, List<int> queries)
        {
            var result = new List<string>();
            foreach (var item in queries)
            {
                if (weightStrings.Contains(item))
                    result.Add("Yes");
                else
                    result.Add("No");
            }
            return result;
        }

        static void Main(string[] args)
        {
            //var result = weightedUniformStrings("abbcccdddd", new List<int>() { 1, 7, 5, 4, 15 }); //'Yes', 'No', 'No', 'Yes', 'No'
            //var result = weightedUniformStrings("aaabbbbcccddd", new List<int>() {  9, 7, 8, 12, 5 });
            var result = weightedUniformStrings("abccddde", new List<int>() { 6, 1, 3, 12, 5, 9, 10 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}