using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHEAP2
{
    class Program
    {
        public static List<int> heap = new List<int>();
        public static int min = int.MaxValue;
        public static StringBuilder result = new StringBuilder();
        static void Main(string[] args)
        {
            var str = @"1 3
1 65
2 65
3
2 3
1 7
3
1 -1
3
2 -1
3
2 7";
            //var operations = new string[] { "1 4", "1 9", "3", "2 4", "3" };
            var operations = str.Split('\n');
            for (int i = 0; i < operations.Length; i++)
                CallOperation(operations[i]);
            Console.WriteLine(result.ToString());


            //var countOperation = int.Parse(Console.ReadLine());
            //var operations = new string[countOperation];
            //for (int i = 0; i < operations.Length; i++)
            //    CallOperation(Console.ReadLine());
            //Console.WriteLine(result.ToString());

            Console.ReadKey();
        }

        private static void CallOperation(string operation)
        {
            var parse = operation.Split(' ');
            var op = int.Parse(parse[0]);
            if (op == 3)
            {
                result.Append(min.ToString() + "\n");
                return;
            }
            var value = int.Parse(parse[1]);
            if (op == 1)
            {
                heap.Add(value);
                if (value < min)
                    min = value;
            }
            if (op == 2)
            {
                heap.Remove(value);
                if (heap.Count > 0)
                {
                    if (value<=min)
                    {
                        min = heap.Min();
                    }
                }
                else
                    min = int.MaxValue;
            }
        }
    }
}
