using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class Program
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }
        public static void PrintList (Node node)
        {
            int i = 0;
            while (node != null && i<200)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
                i++;
            }

        }
        static void Main(string[] args)
        {
            Node first = new Node();
            first.Value = 1;

            Node second = new Node();
            second.Value = 2;

            Node third = new Node();
            third.Value = 3;

            first.Next = second;
            second.Next = third;
            //third.Next = first;

            PrintList(first);

            Console.ReadKey();
        }
    }
}
