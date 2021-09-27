using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyString
{
    class Program
    {
        public static string funnyString(string s)
        {
            var stringList = new List<int>();
            for (int i = 0; i < s.Length; i++)
                stringList.Add((int)s[i] - 96);

            var mirrorList = new List<int>();
            for (int i = s.Length - 1; i >= 0; i--)
                mirrorList.Add((int)s[i]-96);

            for (int i = 0; i < s.Length-1; i++)
                  if (Math.Abs(stringList[i] - stringList[i + 1]) != Math.Abs(mirrorList[i] - mirrorList[i + 1]))
                    return "Not Funny";
            return "Funny";
        }
        static void Main(string[] args)
        {
            var s = "acxz";
            Console.WriteLine(funnyString(s));

            Console.ReadKey();
        }
    }
}
