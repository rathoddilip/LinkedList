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
            //UC7
            Console.WriteLine("Search for Node 30"); 
            LinkedList searchlinkedList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            searchlinkedList.head = node56;
            searchlinkedList.Display();
            searchlinkedList.Display();
            if (searchlinkedList.Search(30))
                Console.WriteLine("Node found");
            else
            {
                Console.WriteLine("Node not found");
            }
            Console.WriteLine("Add node after node");
            LinkedList linkedListAddAfterNode = new LinkedList();

            linkedListAddAfterNode.InsertLast(56);
            linkedListAddAfterNode.InsertLast(30);
            linkedListAddAfterNode.InsertLast(70);
            linkedListAddAfterNode.AddNodeAfterNode(40,30);
            linkedListAddAfterNode.Display();
            Console.ReadLine();
        }
    }
}
