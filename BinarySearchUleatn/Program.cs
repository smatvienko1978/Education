using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchUleatn
{
    class Program
    {
        public static int LinearSearch(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value)
                    return i;
            return -1;
        }
        public static int BinarySearch(int[] arr, int value)
        {
            var left = 0;
            var right = arr.Length - 1;
            while (left<right)
            {
                var middle = (left + right) / 2;
                if (arr[middle] <= value)
                    right = middle;
                else
                    left = middle + 1;
            }
            if (arr[left] == value)
                return left;
            return -1;           
        }
        public static int BinarySearchRecursive (int[]arr, int value, int left, int right)
        {
            if (left <= right)
            {
                var middle = (left + right) / 2;
                if (value < arr[middle])
                    BinarySearchRecursive(arr, value, left, middle - 1);
                if (value > arr[middle])
                    BinarySearchRecursive(arr, value, middle + 1, right);
                return middle;       
            }
            return -1;
        }
        //public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        //{
        //    if (right > array.Length)
        //        return -1;
        //    if (left == right)
        //        return array[left]==value?left:-1;
        //    var m = (left + right) / 2;
        //    if (array[m] < value)
        //        return BinSearchLeftBorder(array, value, m + 1, right);
        //    if (array[m] == value)
        //        return m;
        //    return BinSearchLeftBorder(array, value, left, m -1);
        //}
        public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        {
            var result = BinSearch(array, value, left, right);
            if (result == -1) return -1;
            return result - 1;
        }
        public static int BinSearch(long[] array, long value, int left, int right)
        {
            if (left == -1) left = 0;
            if (right > array.Length || left < 0)
                return -1;
            if (left == right)
                return array[left] == value ? left : -1;
            var m = (left + right) / 2;
            if (array[m] < value)
                return BinSearch(array, value, m + 1, right);
            if (array[m] == value)
                return m;
            return BinSearch(array, value, left, m - 1);
        }
        private static int FindLeftBorder(long[] arr, long value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4};
            //Console.WriteLine(LinearSearch(arr, 11));
            //Console.WriteLine(LinearSearch(arr,5));
            //Console.WriteLine(BinarySearchRecursive(arr, 2, 0, 4));
            Console.WriteLine(FindLeftBorder(new long[] { 1, 2, 3,4 }, 4));
            Console.ReadKey();
        }
    }
}
