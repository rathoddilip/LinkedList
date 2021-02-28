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
            Console.ReadLine();
        }
    }
}
