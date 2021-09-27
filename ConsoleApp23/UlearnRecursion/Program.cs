using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnRecursion
{
    class Program
    {
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            // Выводим в обратном порядке все элементы с индексом больше startIndex
            if (items.Length > 0)
                if (startIndex < items.Length - 1)
            {
                WriteReversed(items, startIndex + 1);
                Console.Write(items[startIndex]);
            }
            else

                Console.Write(items[startIndex]);
            
            
            //// Выводим в обратном порядке все элементы с индексом больше startIndex
            //if (startIndex == 0)
            //    Console.Write(items[startIndex]);
            //else
            //{
            //    WriteReversed(items, startIndex + 1);
            //    // а потом выводим сам элемент startIndex

            //    Console.Write(items[startIndex]);
        }

        //static void Make(int n)
        //{
        //    for (int i = n-1; i >=0; i--)
        //    {
        //        Console.Write(i + " ");
        //        Make(i);
        //    }
        //}
        static void Main(string[] args)
        {
            // Make(2);
            //WriteReversed(new char[] { '1','2','3'},0);
            //WriteReversed(new char[] { '1', '1', '2', '2', '3', '3' });
            WriteReversed(new char[] { });
            Console.ReadKey();
        }
    }
}
