using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutSticks
{
    class Program
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            var result = new List<int>();
            result.Add(arr.Count);

            var minStik = arr.Min();
            while (arr.Max()>minStik)
            {
                for (int i = 0; i < arr.Count; i++)
                    arr[i] -= minStik; 

                arr = RemoveAll(arr, 0);
                result.Add(arr.Count);
                minStik = arr.Min();
            }
            return result;


        }
        public static List<int> RemoveAll(List<int> arr, int element)
        {
            while (arr.Contains(element))
                arr.Remove(element);
            return arr;
        }
        static void Main(string[] args)
        {
            var result = cutTheSticks(new List<int>() { 4, 5, 10, 8, 11 });
            foreach (var item in result)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
