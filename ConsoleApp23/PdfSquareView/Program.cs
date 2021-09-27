using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfSquareView
{
    class Program
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            var max = 0;
            foreach (var ch in word)
                if (h[(int)ch - 97] > max) max = h[(int)ch - 97];
         
            return max * word.Length;
        }

        static void Main(string[] args)
        {
            var input = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7";
            var parse = input.Split(' ');
            var arr = new int[26];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Int32.Parse(parse[i]);

            Console.WriteLine(designerPdfViewer(arr.ToList(), "zaba")); //28

            Console.ReadKey();
        }
    }
}
