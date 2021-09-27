using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAddToPosition
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

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);
                Console.Write(node.data + " ");
                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        class Result
        {

            /*
             * Complete the 'insertNodeAtPosition' function below.
             *
             * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
             * The function accepts following parameters:
             *  1. INTEGER_SINGLY_LINKED_LIST llist
             *  2. INTEGER data
             *  3. INTEGER position
             */

            /*
             * For your reference:
             *
             * SinglyLinkedListNode
             * {
             *     int data;
             *     SinglyLinkedListNode next;
             * }
             *
             */
            //public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
            //{
            //    SinglyLinkedListNode node = new SinglyLinkedListNode(data);
            //    if (llist == null)
            //        return node;

            //    var currentNode = llist;
            //    for (int i = 0; i < position; i++)
            //    {
            //        currentNode = llist.next;
            //    }

            //    node.next = currentNode.next;
            //    currentNode.next = node;
            //    return llist;

            //}

            public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(data);
                if (llist == null )
                    return node;
                if (position==0)
                {
                    node.next = llist;
                    return node;
                }
                var currentNode = llist;
                var i = 0;
                while (currentNode!=null || i<position)
                {
                    currentNode = currentNode.next;
                }
                var temp = currentNode.next;
                currentNode.next = node;
                node.next = temp;
                return llist;
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"d:\test\ll.txt", true);

            SinglyLinkedList llist = new SinglyLinkedList();
            var input = new int[] { 16, 13, 7 };
            foreach (var item in input)
                llist.InsertNode(item);
            int data = 1;
            int position = 1;


            SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            PrintSinglyLinkedList(llist_head, " ", textWriter);
            textWriter.WriteLine();

            textWriter.Flush();
            textWriter.Close();
            Console.ReadKey();
        }

        private static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
        {
            SinglyLinkedListNode insertNode = new SinglyLinkedListNode(data);
            if (llist == null)
                return insertNode;
            if (position==0)
            {
                insertNode.next = llist;
                return insertNode;
            }

            var resultHead = llist;
            for (int i = 0; i < position-1; i++)
                llist = llist.next;

            var temp = llist.next;
            llist.next = insertNode;
            insertNode.next = temp;

            return resultHead;
        }
    }

}
