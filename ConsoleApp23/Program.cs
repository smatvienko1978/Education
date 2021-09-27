using System;
using System.Collections.Generic;

class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{
   
    public static Node insert(Node head, int data)
    {
        //Complete this method
        if (head == null)
        {
            head = new Node(data);
        }
        else
        {
            Node toAdd = new Node(data);
            Node current = head;
            while(current.next!=null)
            {
                current = current.next;
            }
            current.next = toAdd;

        }  
        return head;
    }

    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }


    static void Main(String[] args)
    {

        //Node head = null;
        //var arr = new int[] { 2, 3, 4, 1 };
        //foreach (var item in arr)
        //    head = insert(head, item);



        Console.ReadKey();
    }
}
