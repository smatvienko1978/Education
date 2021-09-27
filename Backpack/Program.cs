using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack
{
    class Program
    {
        public static int[] weights = { 4, 1, 3 };
        public static int[] values = { 4000, 2500, 2000 };

        public static int CountMax(int[] weights, int[] values, int maxCapacity)
        {
            // строим массив и закладываем место на ячейки пустышки
            //выходящие из левого верхнего угла
            var arr = new int[values.Length+1, weights.Length+1];

            for (int i = 1; i <= weights.Length; i++)       //проходим по всем вещам
                for (int j = 1; j <= values.Length; j++)    //проходим по всем рюкзакам
                    if (i == 0 || j == 0)                   //попадаем в ячейку пустышку
                        arr[i, j] = 0;
                    else
                         //если вес текущей вещи больше размера рюкзака
                         //казалось бы откуда значение возьмется для первой вещи 
                         //при таком условии. А оно возьмется из ряда пустышки
                         if (weights[i - 1] > j)
                        //здесь по формуле. Значение над текущей ячейкой
                            arr[i, j] = arr[i - 1, j];
                         else
                        //Значение по вертикали: ряд вверх
                        //и по горизонтали: вес рюкзака - вес текущей вещи
                        arr[i, j] = Math.Max(arr[i-1,j], values[i - 1] + arr[i - 1, j - weights[i - 1]]);
            // возвращаем правую нижнюю ячейку
            return arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
        }
            static void Main(string[] args)
        {
            Console.WriteLine(CountMax(weights, values, 4));
            Console.ReadKey();
        }
    }
}
