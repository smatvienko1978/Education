using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace ConsoleApp21
{
    class Program
    {
        static void Main()
        {
            //var m = new Mathematika();
            //Console.WriteLine(m.Sum(2,3));
            var line = "a\"b";
            //for (int i = 0; i < line.Length; i++)
            //{
            //    Console.WriteLine(line.Length);
            //    Console.WriteLine(i+ " " + line[i]);
            //}
            string str1 = "stringOne";
            string str2 = "stringTwo";
            string str3 = str1 + "\\" + str2;
            Console.WriteLine(line);
            var chArray = line.ToCharArray();

            for (int i = 0; i < chArray.Length; i++)
            {
                Console.WriteLine(i+ " " + chArray[i]);
            }
            

            //foreach (var item in str3)
            //{
            //    Console.WriteLine(line.Contains(@"\"));
            //}
            Console.ReadKey();
        }
    }
}
