using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDates
{
    class Program
    {
        public static int[] month = new int[15] ;
        public static void updateLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                month[2] = 29;  //fird 28=>29
            }
            else if (year % 100 == 0)
            {
                month[2] = 29; //fifth 29 => 28
            }
            else if (year % 4 == 0)
            {
                month[2] = 29;
            }
            else
            {
                month[2] = 28;
            }
        }

        public static void storeMonth()
        {
            month[1] = 31;
            month[2] = 28;
            month[3] = 31;
            month[4] = 30;
            month[5] = 31;
            month[6] = 30;
            month[7] = 31;
            month[8] = 31;
            month[9] = 30;
            month[10] = 31;
            month[11] = 30;
            month[12] = 31;
        }

        public static int findPrimeDates(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            storeMonth();

            int result = 0;

            while (true)
            {
                int x = d1;
                x = x * 100 + m1;
                x = x * 10000 + y1; //second 1000 => 10000
                if (x % 4 == 0 || x % 7 == 0) // first && => ||
                {
                    result = result + 1;
                }
                if (d1 == d2 && m1 == m2 && y1 == y2)
                {
                    break;
                }
                updateLeapYear(y1);
                d1 = d1 + 1;
                if (d1 > month[m1])
                {
                    m1 = m1 + 1; 
                    d1 = 1;
                    if (m1 > 12)
                    {
                        y1 = y1 + 1; 
                        m1 = 1; //third m1 + 1 =>1
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(findPrimeDates(02, 08, 2025, 04, 09,2025));//5
            Console.ReadKey();
        }
    }
}
