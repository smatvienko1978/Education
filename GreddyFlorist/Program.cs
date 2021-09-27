﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreddyFlorist
{
    class Program
    {

        static int getMinimumCost(int k, int[] c)
        {
            Array.Sort(c);
            Array.Reverse(c);
            var multiplier = 0;
            var sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i % k == 0)
                    multiplier++;
                sum += c[i] * multiplier;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(getMinimumCost(3, new int[] { 1, 3, 5, 7, 9, })); //29
            


            
           //Console.WriteLine(getMinimumCost(3, new int[] { 2, 5, 6 })); //13
            
            var str = @"390225 426456 688267 800389 990107 439248 240638 15991 874479 568754 729927 980985 132244 488186 5037 721765 251885 28458 23710 281490 30935 897665 768945 337228 533277 959855 927447 941485 24242 684459 312855 716170 512600 608266 779912 950103 211756 665028 642996 262173 789020 932421 390745 433434 350262 463568 668809 305781 815771 550800";
            var parse = str.Split(' ');
            var arr = new List<int>();
            foreach (var item in parse)
                arr.Add(int.Parse(item));
            Console.WriteLine(getMinimumCost(3, arr.ToArray<int>())); //163578911
            Console.ReadKey();
        }
    }
}
