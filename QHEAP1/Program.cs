using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHEAP1
{
    class Program
    {
        public static Dictionary<int, int> heap = new Dictionary<int, int>();
        public static int min = int.MinValue;

        public static StringBuilder result = new StringBuilder();

        static void Main(string[] args)
        {
            var str = @"1 286789035
1 255653921
1 274310529
1 494521015
3
2 255653921
2 286789035
3
1 236295092
1 254828111
2 254828111
1 465995753
1 85886315
1 7959587
1 20842598
2 7959587
3
1 -51159108
3
2 -51159108
3
1 789534713";

            //var countOperation = int.Parse(Console.ReadLine());
            //var operations = new string[countOperation];

            //var operations = new string[] { "1 4", "1 9", "3", "2 4", "3" };

            var operations = str.Split('\n');

            for (int i = 0; i < operations.Length; i++)
                //CallOperation(Console.ReadLine());
                CallOperation(operations[i]);
            //result.Remove(result.Length - 1, 1);
            //Console.WriteLine(result.ToString());
            Console.ReadKey();
        }

        private static void CallOperation(string operation)
        {
            var parse = operation.Split(' ');
            var op = int.Parse(parse[0]);
            if (op == 3)
            {
                Console.WriteLine(CalcMin());
                //result.Append(CalcMin() + "\n");
                return;
            }
            var value = int.Parse(parse[1]);
            if (op == 1)
                if (heap.ContainsKey(value))
                    heap[value]++;
                else
                    heap.Add(value, 1);
            if (op == 2)
                if (heap.ContainsKey(value))
                    if (heap[value] > 1)
                        heap[value]--;
                    else
                        heap.Remove(value);
        }

        private static string CalcMin()
        {
           return   heap.Keys.Min().ToString();
           
        }
    }
}
