using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChessBoard
{
    class Program
    {
        private static void WriteBoard(int size)
        {
            
            int line = 0;
            while (line < size)
            {
                string result = "";
                if (line%2!=0)
                    for (int i = 0; i < size; i++)
                        if (i % 2 != 0) result += "#";
                            else result += ".";
                 else
                    for (int i = 0; i < size; i++)
                        if (i % 2 != 0) result += ".";
                        else result += "#";
                Console.WriteLine(result);
                line++;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);

            Console.ReadKey();
        }
    }
}
