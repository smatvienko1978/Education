using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDolbyLinkedList
{
    class Program
    {
            public class DoublyLinkedListNode
            {
                public int data;
                public DoublyLinkedListNode next;
                public DoublyLinkedListNode prev;

                public DoublyLinkedListNode(int nodeData)
                {
                    this.data = nodeData;
                    this.next = null;
                    this.prev = null;
                }
            }

            public class DoublyLinkedList
            {
                public DoublyLinkedListNode head;
                public DoublyLinkedListNode tail;

                public DoublyLinkedList()
                {
                    this.head = null;
                    this.tail = null;
                }

                public void InsertNode(int nodeData)
                {
                    DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                    if (this.head == null)
                    {
                        this.head = node;
                    }
                    else
                    {
                        this.tail.next = node;
                        node.prev = this.tail;
                    }

                    this.tail = node;
                }
            }

            static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
            {
                while (node != null)
                {
                    textWriter.Write(node.data);

                    node = node.next;

                    if (node != null)
                    {
                        textWriter.Write(sep);
                    }
                }
            }

            public static DoublyLinkedListNode reverse(DoublyLinkedListNode llist)
            {
           
            DoublyLinkedListNode current = llist, prev = null, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
            }
        static void Main(string[] args)
        {
        }
    }
}
