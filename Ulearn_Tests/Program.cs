using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn_Tests
{
    class Program
    {
        static void Make42(int[] a, List<int>[] b, string c)
        {
            a = new[] { 42 };
            b[0].Add(42);
            b[1] = new List<int> { 42 };
            c += "42";
        }

        static void Main(string[] args)
        {
            //var varr = 1 + "100" + 2 * 3;
            //var varr = 3.0 / 6 == 1 / 2 && Math.Sqrt(3) * Math.PI < 5.441399;
            // var varr = new[] { new[] { 1, 4, 0.0 } }[0][1];
            //var varr = ("\\\\" + new[] { @"1\\t\""", "abx" }[0]).Length;
            var varr = new[] { new string[3], new[] { "a", "b" } }[0][1];

            Console.WriteLine(varr);
            Console.ReadKey();


            var a = new int[1];
            var b = new[] { new List<int>(), new List<int>() };
            var c = "0";
            Make42(a, b, c);
            Console.WriteLine(string.Join(",", a[0], c));
            Console.WriteLine(string.Join(",", b[0]));
            Console.WriteLine(string.Join(",", b[1]));



            Console.ReadKey();
        }
    }
}
