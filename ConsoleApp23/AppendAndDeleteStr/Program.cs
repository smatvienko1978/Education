using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendAndDeleteStr
{
    class Program
    {
        public static string appendAndDelete(string s, string t, int k)
        {
            var subStringLengh = 0;
            var maxSubstringLeng = Math.Min(s.Length, t.Length);
            for (int i = 0; i < maxSubstringLeng; i++)
                if (s[i] == t[i])
                    subStringLengh++;
                else
                    break;

            var steps = 0;
            steps = s.Length - subStringLengh + t.Length - subStringLengh;
            return steps <= k ? "Yes" : "No";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(appendAndDelete("zzzzz", "zzzzzzz", 2)); //YES
            //Console.WriteLine(appendAndDelete("ashley", "ash", 2)); //NO
            //Console.WriteLine(appendAndDelete("aba", "aba", 7)); //YES

            Console.ReadKey();
        }
    }
}
