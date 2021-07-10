using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    class LinkedList
    {
        internal Node head;
        public LinkedList()
        {
            this.head = null;
        }
        //Method to add elements at last
       internal void AddAtLast(int data)
        {
            Node newNode = new Node(data);
            if(head==null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        //Method to display elements
        internal void Display()
        {
            if(head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Console.Write("  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.Next;
                }
                Console.Write("Null\n");
            }
        }
    }
}
