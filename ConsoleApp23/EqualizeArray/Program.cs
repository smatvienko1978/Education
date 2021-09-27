using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeArray
{
    class Program
    {
        public static int equalizeArray(List<int> arr)
        {
            var max = 0;
            for (int i = arr.Min(); i <= arr.Max(); i++)
            {
                if (arr.Contains(i))
                {
                    var tempMax = 0;
                    for (int j = 0; j < arr.Count; j++)
                        if (i == arr[j])
                            tempMax++;

                    if (tempMax > max)
                        max = tempMax;
                }
            }

            return arr.Count - max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(equalizeArray(new List<int>() { 3, 3, 2, 1, 3 })); //4

            Console.ReadKey();
        }
    }
}
