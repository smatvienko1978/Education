using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public static void PrintList(LinkedListNode<T> node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var first = new LinkedListNode<string>("Hello ");
            //var second = new LinkedListNode<string>("world");
            //var third = new LinkedListNode<string>("!");
            var first = new LinkedListNode<int>(42);
            var second = new LinkedListNode<int>(43);
            var third = new LinkedListNode<int>(0);

            first.Next = second;
            second.Next = third;

            //var node = first;
            //while (node!=null)
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;
            //}

            LinkedListNode<int>.PrintList(first);
            //LinkedListNode<string>.PrintList(first);
            //PrintList(first);
            Console.ReadKey();
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + " " + (i + 1).ToString() + " " + i  % 10); ;
               
            }
            Console.ReadKey();
        }

        
    }
}
