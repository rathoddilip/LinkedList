﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDS
{
   public class LinkedList
    {
        public Node head;
        /// <summary>
        /// UC-1
        /// </summary>
        /// <param name="newData"></param>
        public Node InsertLast(int newData)
        {
            Node newNode = new Node(newData);
            if(this.head==null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;// changing the next pointer 
            }
            Console.WriteLine("Inserted Into list "+newNode.data);
            return newNode;
        }
        public Node GetLastNode()
        {
            Node last = this.head;
            while(last.next!=null)
            {
                last = last.next;
            }
            return last;
        }
        /// <summary>
        /// UC-2 
        /// </summary>
        /// <param name="newData"></param>
        public void InsertFront(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next=this.head;
            this.head = newNode;
            Console.WriteLine("Inserted at front:"+newData);
        }
        /// <summary>
        /// UC3 Append
        /// </summary>
        /// <param name="newData"></param>
        public void Append(int newData)
        {
           InsertLast(newData);  
        }
       public void InsertAfterNode(Node prevNode, int newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node newNode = new Node(newData);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }
        /// <summary>
        /// UC-4 Add between node
        /// </summary>
        /// <param name="preNode"></param>
        /// <param name="addAfterNode"></param>
        public void AddNodeAfterNode(int newData, int addAfterNode)
        {
            Node newNode = new Node(newData);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.data != addAfterNode)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;

            }
            Console.WriteLine("Added in between Node: "+newData);
        }

        public Node Display()
        {
            Console.WriteLine("Displaying nodes");
            Node listdata = this.head;
            if(listdata == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while(listdata != null)
                {
                    Console.WriteLine("Nodes in Linked List: "+ listdata.data);
                    listdata = listdata.next;
                }
               
            }
            return listdata;
        }
    }
}
