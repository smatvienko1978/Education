using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongStringCountA
{
    class Program
    {
        public static long repeatedString(string s, long n)
        {
            long multiplier = (long)Math.Floor((double)n / (double)s.Length);
            int tail = (int)(n- multiplier * s.Length);
            
            long count = 0;
            foreach (var ch in s)
                if (ch == 'a')
                    count++;

            count = count * multiplier;

            for (var i = 0; i < tail; i++)
                if (s[i] == 'a')
                    count++;
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(repeatedString("aba",10));
            
        }
    }
}
