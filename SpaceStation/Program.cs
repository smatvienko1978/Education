using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Program
    {
        public static int flatlandSpaceStations(int n, int[] arr)
        {
            Array.Sort(arr);
            int maxDistance = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int distance = (arr[i] - arr[i - 1]) / 2;
                if (maxDistance < distance) maxDistance = distance;
            }
            int lastGap = (n - 1) - arr[arr.Length - 1];
            return (lastGap < maxDistance) ? maxDistance : lastGap;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(flatlandSpaceStations(5, new int[] { 0,4})); //2
        }
    }
}
