using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TextWithBorder
{
    class Program
    {
        private static void WriteTextWithBorder(string text)
        {
            // TOP
            Line(text);

            //Middle
            Console.WriteLine("| " + text + " |");

            //Down

            Line(text);
        }

        private static void Line(string text)
        {
            Console.Write('+');
            for (int i = 0; i < text.Length + 2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('+');
        }

        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");

            Console.ReadKey();
        }
        
    }
}
