using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CodeWars
{
    class Program
    {
        static  string CamelCase (string input)
        {
            var parse = input.Split('-','_');
            string result =parse[0];
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            for (int i = 1; i < parse.Length; i++)
                result += ti.ToTitleCase(parse[i]);
            

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CamelCase("the-stealth-warrior"));
            Console.WriteLine(CamelCase("The_Stealth_Warrior"));

            Console.ReadKey();
        }
    }
}
