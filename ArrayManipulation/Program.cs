using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            //it's works but needs more faster solution
            //var array = new long[n + 1];
            //array.Initialize();
            //foreach (var item in queries)
            //{
            //    int lowBond = item[0];
            //    int upBond = item[1];
            //    int value = item[2];
            //    for (int i = lowBond; i <= upBond; i++)
            //        array[i] += value;
            //}
            //return array.Max();
            var array = new int[n + 1];
            array.Initialize();
            foreach (var item in queries)
            {
                int lowBond = item[0];
                int upBond = item[1];
                int value = item[2];
                array[lowBond]+= value;
                array[upBond + 1] -= value;
            }


            long max = long.MinValue;
            long current = 0;
            foreach (var item in array)
            {
                current += item;
                if (max < current)
                    max = current;
            }


            return max;
            }

        static void Main(string[] args)
        {
            //var queries = new List<List<int>>() {
            //    new List<int>() { 1, 2, 100 },
            //    new List<int>() { 2, 5, 100 },
            //    new List<int>() { 3, 4, 100} };
            var queries = new List<List<int>>() {
                new List<int>() { 1, 5, 3 },
                new List<int>() { 4, 8, 7 },
                new List<int>() { 6, 9, 1 } };

            Console.WriteLine(arrayManipulation(10, queries)); //200
            Console.ReadKey();
            //var dc = new Dictionary<int, long>();
            var str = new StringBuilder();
        }
    }
}
