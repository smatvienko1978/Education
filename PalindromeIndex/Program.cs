using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class Program
    {
        public static int palindromeIndex(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                    if (isPalidrom(s, i, j - 1))
                       return j;
                    else
                        return i;
                i++;
                j--;
            }
            return -1;
        }
        static bool isPalidrom(String s, int i, int j)
        {
            while (i < j)
                if (s[i++] != s[j--])
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(palindromeIndex("aaa")); //3
            Console.ReadKey();
        }
    }
}
