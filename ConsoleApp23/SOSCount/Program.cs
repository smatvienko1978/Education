using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCount
{
    class Program
    {
        public static int marsExploration(string s)
        {
            int result = 0;
            int sosCount = s.Length / 3;
            var expectedString = "";
            for (int i = 0; i < sosCount; i++)
                expectedString += "SOS";
            for (int i = 0; i < s.Length; i++)
                if (expectedString[i] == 'S' && s[i] != 'S')
                    result++;
            return result;
        }
        static void Main(string[] args)
        {
            string message = "SOSSPSSQSSOR";

            Console.WriteLine(marsExploration(message));

            Console.ReadKey();
        }
    }
}
