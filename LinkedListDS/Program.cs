using System;

namespace LinkedListDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Linked list!!!!!!!!!!!!!!!");
            LinkedList linkedList = new LinkedList();//Created object of LinkedList class
            linkedList.InsertLast(56);
            linkedList.InsertLast(30);
            linkedList.InsertLast(70);
            linkedList.Display();
            Console.WriteLine("---------------------------------------");
            linkedList.InsertFront(70);
            linkedList.InsertFront(30);
            linkedList.InsertFront(56);
            linkedList.Display();
            Console.WriteLine("---------------------------------------");
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
