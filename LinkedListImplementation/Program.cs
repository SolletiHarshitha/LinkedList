using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Linked List--------------------");
            LinkedList linkedList = new LinkedList();
            //Adding elements to the list
            linkedList.AddAtLast(56);
            linkedList.AddAtLast(30);
            linkedList.AddAtLast(70);
            //Dispaly the list
            linkedList.Display();
        }
    }
}
