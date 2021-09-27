using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatableCharacters
{
    class Program
    {
        public static int alternatingCharacters(string s)
        {
            var count = 0;
            if (s.Length == 0)
                return 0;
            var currentChar = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (currentChar == s[i])
                    count++;
                else
                    currentChar = s[i];
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(alternatingCharacters("AAAA")); //3
            Console.WriteLine(alternatingCharacters("ABABABAB"));//0
            Console.WriteLine(alternatingCharacters("AAABBB"));//4

            Console.ReadKey();
        }
    }
}
