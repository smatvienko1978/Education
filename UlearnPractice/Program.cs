using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnPractice
{
    class Program
    {
        //Rec1. Возвести число в натуральную степень P за \Theta(\log P)Θ(logP). Рекурсивный и нерекурсивный варианты.
        //public static int Degree(int number, int degree)
        //{
        //    if (number <= 0 || degree <= 0)
        //        return -1;
        //    if (degree == 1)
        //        return number;

        //    int result = number;
        //    for (int i = 1; i < degree; i++)
        //        result = result * number;
        //    return result;
        //}
        //public static int DegreeRecursion(int number, int degree)
        //{
        //    if (degree == 1)
        //        return number;

        //    return number * DegreeRecursion(number, degree - 1);
        //}

        static int contGoodCombination;
        private static void QueensPlacement(int dimension, int queensNumber)
        {
            var combinations = new List<List<int>>();
            MakeCombinations(new bool[dimension * dimension], combinations, queensNumber);

            foreach (var item in combinations)
                PrintPieceCombination(item);
        }

        private static void PrintPieceCombination(List<int> combination)
        {
            var n = (int)Math.Sqrt(combination.Count());
            var arr = new int[n, n];
            int counter = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = combination[counter];
                    counter++;
                }
           
            if (IsPeace(arr))
                PrintBoard(arr);
        }

        private static bool IsPeace(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == 1)
                        if (isDamaged(arr, i, j))
                            return false;
            return true;
        }

        private static bool isDamaged(int[,] arr, int i, int j)
        {
            if (IsVerticalDamaged(arr, i, j)) return true;
            if (IsHorizontalDamaged(arr, i, j)) return true;
            if (IsMainDiagonalDamaged(arr, i, j)) return true;
            if (IsSeconfDiagonalDamaged(arr, i, j)) return true;
            return false;
        }

        private static bool IsSeconfDiagonalDamaged(int[,] arr, int i, int j)
        {
            //up
            var shift = 1;
            while (i - shift >= 0 && j + shift < arr.GetLength(0))
            {
                if (arr[i - shift, j +  shift] == 1)
                    return true;
                shift++;
            }
            //down
            shift = 1;
            while (i + shift < arr.GetLength(0) && j - shift >= 0)
            {
                if (arr[i + shift, j - shift] == 1)
                    return true;
                shift++;
            }

            return false;
        }

        private static bool IsMainDiagonalDamaged(int[,] arr, int i, int j)
        {
            //up
            var shift = 1;
            while (i - shift >= 0 && j - shift >= 0)
            { 
                if (arr[i - shift, j - shift] == 1)
                    return true;
                shift++;
            }
            //down
            shift = 1;
            while (shift + i < arr.GetLength(0) && j + shift < arr.GetLength(0))
            {
                if (arr[i + shift, j + shift] == 1)
                    return true;
                shift++;
            }
            return false;
        }

        private static bool IsHorizontalDamaged(int[,] arr, int i, int j)
        {
            for (int column = 0; column < arr.GetLength(0); column++)
            {
                if (column == j)
                    continue;
                if (arr[i, column] == 1)
                    return true;
            };
            return false;
        }

        private static bool IsVerticalDamaged(int[,] arr, int i, int j)
        {
            for (int line = 0; line < arr.GetLength(1); line++)
            {
                if (line == i)
                    continue;
                if (arr[line, j] == 1)
                    return true;
            };
            return false;
        }

        private static void PrintBoard(int[,] arr)
        {
            Console.WriteLine(++contGoodCombination);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
           // Console.WriteLine();
        }

        static void MakeCombinations(bool[] combinations, List<List<int>> Combinations, int elements, int position = 0)
        {
            if (elements == 0)
            {
                for (int i = position; i < combinations.Length; i++)
                    combinations[i] = false;
                var line = new List<int>();
                foreach (var item in combinations)
                {
                  //  Console.Write((item ? 1 : 0) + " ");
                    line.Add(item ? 1 : 0);
                }
                Combinations.Add(line);
                //Console.WriteLine();
                return;
            }
            if (position == combinations.Length && elements > 0)
                return;
            combinations[position] = true;
            MakeCombinations(combinations, Combinations, elements - 1, position + 1);
            combinations[position] = false;
            MakeCombinations(combinations, Combinations, elements, position + 1);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Degree(2, 8));
            //Console.WriteLine(DegreeRecursion(2,8));
            QueensPlacement(4,4);
            Console.ReadKey();
        }


    }
}
