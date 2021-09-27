using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_test
{
    class Program
    {
        public static int truckTour(List<List<int>> petrolpumps)
        {
            int pump = 0;
            while (true)
            {
                int fuel = 0;
                bool flag = false;
                for (int i = pump; i < petrolpumps.Count; i++)
                {
                    fuel += petrolpumps[i][0];
                    fuel -= petrolpumps[i][1];
                    if (fuel<0)
                    {
                        pump++;
                        flag = true;
                        break;
                    }
                }
                if (flag) continue;
                for (int i = 0; i < pump; i++)
                {
                    fuel += petrolpumps[i][0];
                    fuel -= petrolpumps[i][1];
                    if (fuel < 0)
                    {
                        pump++;
                        break;
                    }
                }
                return pump;
            }
        }
        static void Main(string[] args)
        {
            var petrolpumps = new List<List<int>>();
            //{
            //    new List<int>() { 1, 5 },
            //    new List<int>() {10, 3 },
            //    new List<int>() { 3, 4} };
            string path = @"D:\test\truck.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                int count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    var row = new List<int>();
                    var line = sr.ReadLine().Split(' ');
                    row.Add(int.Parse(line[0]));
                    row.Add( int.Parse(line[1]));
                    petrolpumps.Add(row);
                }
            }
                Console.WriteLine(truckTour(petrolpumps)); //573
            Console.ReadKey();
        }
    }
}
