using System;

namespace LinkedListDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Linked list!!!!!!!!!!!!!!!");
            LinkedList linkedList = new LinkedList();//Created object of LinkedList class
            Console.WriteLine("Inserte node");
            linkedList.InsertLast(56);
            linkedList.InsertLast(30);
            linkedList.InsertLast(70);
            linkedList.Display();
            //UC-2
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Insert node at front");
            LinkedList linkedListFront = new LinkedList();
            linkedListFront.InsertFront(70);
            linkedListFront.InsertFront(30);
            linkedListFront.InsertFront(56);
            linkedListFront.Display();
            //UC-3
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Append new node");
            LinkedList linkedListAppend = new LinkedList();
            linkedListAppend.Append(56);
            linkedListAppend.Append(30);
            linkedListAppend.Append(70);
            linkedList.Display();
            //UC-4 
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Add Node In Between End Demo ");
            LinkedList linkedListForBetween = new LinkedList();
            linkedListForBetween.InsertLast(56);
            linkedListForBetween.InsertLast(70);
            linkedListForBetween.AddNodeAfterNode(30, 56);
            linkedListForBetween.Display();
            //UC5
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Delete First element demo");
            linkedListForBetween.Display();
            linkedListForBetween.DeleteNodeAtFirst();
            linkedListForBetween.Display();

            Console.ReadLine();
        }
    }
}
