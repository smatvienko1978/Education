using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ReverseWords
{
    class Program
    {
        public static string ReverseWords(string str)
        {
            string result = "";
            var parse = str.Split(' ');
            
            for (int i = 0; i < parse.Length; i++)
            {
                var temp = parse[i].ToCharArray();

                for (int j = temp.Length-1 ; j >= 0 ; j--)
                {
                    //Console.WriteLine(temp[j]);
                    result += temp[j];
                }
                if (i<parse.Length-1) result += " ";
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("This is an example!") + "=" + "sihT si na !elpmaxe"+"....");
            Console.WriteLine(ReverseWords("double  spaces"));

            Console.ReadKey();
        }
    }
}
