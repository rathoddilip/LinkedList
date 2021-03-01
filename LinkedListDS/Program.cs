using System;

namespace LinkedListDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Linked list!!!!!!!!!!!!!!!");
            LinkedList linkedListLast = new LinkedList();//Created object of LinkedList class
            Console.WriteLine("Insert node");
            linkedListLast.InsertLast(56);
            linkedListLast.InsertLast(30);
            linkedListLast.InsertLast(70);
            linkedListLast.Display();
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
            linkedListLast.Display();
            //UC-4 
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Add Node In Between End  ");
            LinkedList linkedListForBetween = new LinkedList();
            linkedListForBetween.InsertLast(56);
            linkedListForBetween.InsertLast(70);
            linkedListForBetween.AddNodeAfterNode(30, 56);
            linkedListForBetween.Display();
            //UC5
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Delete First element ");
            linkedListForBetween.Display();
            linkedListForBetween.DeleteNodeAtFirst();
            linkedListForBetween.Display();
            //UC6
            Console.WriteLine("Delete Last element");
            linkedListLast.Display();
            linkedListLast.DeleteNodeAtLast();
            linkedListLast.Display();
            Console.ReadLine();
        }
    }
}
