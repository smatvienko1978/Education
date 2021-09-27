using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedList
{
    class Solution
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

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data); 

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
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
            SinglyLinkedList llistMerge = new SinglyLinkedList();
            var pointer1 = head1;
            var pointer2 = head2;
            while (true)
            {
                if (pointer1==null)
                {
                    while (pointer2!=null)
                    {
                        llistMerge.InsertNode(pointer2.data);
                        pointer2 = pointer2.next;
                    }
                    break;
                }
                if (pointer2 == null)
                {
                    while (pointer1 != null)
                    {
                        llistMerge.InsertNode(pointer1.data);
                        pointer1 = pointer1.next;
                    }
                    break;
                }
                if (pointer1.data<pointer2.data)
                {
                    llistMerge.InsertNode(pointer1.data);
                    pointer1 = pointer1.next;
                }
                else
                {
                    llistMerge.InsertNode(pointer2.data); 
                    pointer2 = pointer2.next;
                }
            }
            return llistMerge.head;

        }
        static void Main(string[] args)
        {
            SinglyLinkedList llist1 = new SinglyLinkedList();
            llist1.InsertNode(1);
            llist1.InsertNode(2);
            llist1.InsertNode(3);

            SinglyLinkedList llist2 = new SinglyLinkedList();
            llist2.InsertNode(3);
            llist2.InsertNode(4);

            var merge = mergeLists(llist1.head, llist2.head);

            PrintSinglyLinkedList(merge, " "); // 1 2 3 3 4

            Console.ReadKey();
        }
    }
}
