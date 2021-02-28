using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDS
{
   public class LinkedList
    {
        public Node head;
        public void InsertLast(int newData)
        {
            Node newNode = new Node(newData);
            if(this.head==null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("Inserted Into list "+newNode.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
