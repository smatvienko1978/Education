using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Hello", " ", "world!" };
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
        }

        
    }
}
