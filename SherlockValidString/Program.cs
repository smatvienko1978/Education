using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockValidString
{
    class Program
    {
        public static string isValid(string s)
        {
            var chArray = new int[26];
            chArray.Initialize();

            foreach (var ch in s)
                chArray[ch-96]++;

            bool firstTime = true;
            int firstValue = 0;
            bool firstVarning = false;
            for (int i = 0; i < 26; i++)
            {
                if (chArray[i] == 0) continue;
                if (firstTime)
                {
                    firstValue = chArray[i];
                    firstTime = false;
                    continue;
                }
                if (firstValue!=chArray[i])
                {
                    if (firstVarning)
                        return "NO";
                    if (chArray[i] - firstValue > 1)
                        return "NO";
                    else
                        firstVarning = true;
                }
            }
            return "YES";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(isValid("aabbcd")); //NO
            Console.ReadKey();
        }
    }
}
