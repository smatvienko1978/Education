using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        public static int makeAnagram(string a, string b)
        {
            var result = 0;
            int[] aFreq = new int[26];
            aFreq.Initialize();

            foreach (var ch in a)
                aFreq[ch - 97]++;
            foreach (var ch in b)
                aFreq[ch - 97]--;
            foreach (var item in aFreq)
                result += Math.Abs(item);
            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(makeAnagram("cde", "abc")); //4
            Console.WriteLine(makeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke")); //30
            Console.ReadKey();
        }
    }
}
