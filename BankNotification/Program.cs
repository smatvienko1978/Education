using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNotification
{
    class Program
    {
        public static int activityNotifications(List<int> expenditure, int d)
        {
            var temp = new int[d];
            var result = 0;
            var mediana = 0;
            for (int i = d; i < expenditure.Count; i++)
            {
                expenditure.CopyTo(i - d, temp, 0, d);
                Array.Sort(temp);
                if (d % 2 == 0)
                    mediana = (temp[d / 2] + temp[d / 2 + 1]) / 2;
                else mediana= temp[d / 2];
                if (expenditure[i] >= 2 * mediana)
                    result++;
            }
            return result;
        }
        private static int CalcMedianSpend(List<int> expenditure, int d, int date)
        {
            if (date < d) return int.MaxValue;
            var temp = new int[d];
            expenditure.CopyTo(date - d, temp, 0, d);
            Array.Sort(temp);
            if (d % 2 == 0)
                return (temp[d / 2] + temp[d / 2 + 1]) / 2;
            return temp[d / 2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(activityNotifications(new List<int>() { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 5)); //2
           // Console.WriteLine(activityNotifications(new List<int>() { 1, 2, 3, 4, 4 }, 4)); //0
            Console.ReadKey();
        }
    }
}
