using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1MonthPrepKit
{
    class Program
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var dict = new Dictionary<string, int>();
            foreach (var item in strings)
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                    dict[item]++;

            var result = new List<int>();
            foreach (var item in queries)
                if (dict.ContainsKey(item))
                    result.Add(dict[item]);
                else
                    result.Add(0);
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
