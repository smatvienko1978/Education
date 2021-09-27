using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn
{
    class Program
    {
        public static void Print(params object[] items)
        {
            for (var i = 0; i < items.Length; i++)
            {
                Console.Write(items.GetValue(i) .ToString());
                if (i < items.Length - 1)
                    Console.Write(", ");

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Print(1, 2);
            Print("a", 'b');
            Print(1, "a");
            Print(true, "a", 1);
            Console.ReadKey();
        }
    }
}
