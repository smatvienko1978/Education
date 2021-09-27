using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProffesor
{
    class Program
    {
        public static string angryProfessor(int k, List<int> a)
        {
            var studentscount = 0;
            foreach (var item in a)
            {
                if (item <= 0)
                    studentscount++;

            }
            return studentscount < k ? "YES" : "NO";
        }
        static void Main(string[] args)
        {
            var input = new List<List<int>>() { 
            new List<int>() {  4, -93, -86, 49, -62, -90, -63, 40, 72, 11, 67 },
            new List<int>() { 10,23, -35, -2, 58, -67, -56, -42, -73, -19, 37},
            new List<int>() { 9, 13, 91, 56, -62, 96, -5, -84, -36, -46, -13},
            new List<int>() { 8, 45, 67, 64, -50, -8, 78, 84, -51, 99, 60},
            new List<int>() { 7, 26, 94, -95, 34, 67, -97, 17, 52, 1, 86},
            new List<int>() { 2, 19, 29, -17, -71, -75 ,-27, -56, -53, 65, 83},
            new List<int>() { 10, -32, -3, -70, 8, -40, -96, -18, -46, -21, -79},
            new List<int>() { 9,-50, 0, 64, 14, -56, -91, -65, -36, 51, -28},
            new List<int>() { 6,-58 ,-29, -35, -18 ,43, -28, -76,43, -13, 6},
            new List<int>() { 1, 88, -17 ,-96 ,43 ,83, 99, 25, 90, -39 ,86} };

            foreach (var item in input)
            {
                var k = item[0];
                var arr = new List<int>();
                for (int i = 1; i < item.Count; i++)
                    arr.Add(item[i]);

                Console.WriteLine(angryProfessor(k, arr));

            }
                Console.ReadKey();
                //NO
                //YES
                //YES
                //YES
                //YES
                //NO
                //YES
                //YES
                //NO
                //NO
            
        }
    }
}
