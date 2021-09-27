using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Program
    {
        public static string pangrams(string s)
        {
            var abc = new int[26];
            for (int i = 0; i < 26; i++)
                abc[i] = 0;

            s = s.ToLower();
            foreach (char ch in s)
                if (Char.IsLetter(ch))
                    abc[(int)ch - 97]++;

            foreach (var item in abc)
                if (item == 0)
                    return "not pangram";

            return "pangram";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the next prize")); //YES
            Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the prize")); //NOT
            Console.ReadKey();
        }
    }
}
