using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MergeTwoSortedList
{
    class Program
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(" ");
                }
            }
        }

        // Complete the mergeLists function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode head = new SinglyLinkedListNode(0);
            SinglyLinkedListNode ans = head;

            while (head1 != null && head2 != null)
            {

                if (head1.data <= head2.data)
                {
                    if (ans.data < head1.data)
                    {
                        ans.next = head1;
                        head1 = head1.next;
                        ans = ans.next;
                    }
                    else
                        head1 = head1.next;
                }
                else
                {
                    if (ans.data < head2.data)
                    {
                        ans.next = head2;
                        head2 = head2.next;
                        ans = ans.next;
                    }
                    else
                        head2 = head2.next;
                }
                
            }


            if (head1 != null)
                ans.next = head1;

            if (head2 != null)
                ans.next = head2;

            return head.next;
        }

        static void Main(string[] args)
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            list1.InsertNode(1);
            list1.InsertNode(2);
            list1.InsertNode(3);

            SinglyLinkedList list2 = new SinglyLinkedList();
            list2.InsertNode(2);
            list2.InsertNode(3);
            list2.InsertNode(4);

            PrintSinglyLinkedList(mergeLists(list1.head, list2.head));
            Console.ReadKey();

        }
    }
}
