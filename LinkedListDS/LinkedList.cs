using System;
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
        /// <summary>
        /// Delete at first node
        /// </summary>
        public void DeleteNodeAtFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        /// <summary>
        /// Delete node at last
        /// </summary>
        public void DeleteNodeAtLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing To Delete");
                return;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        /// <summary>
        /// Search perticular  30 node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return true;
        }
        /// <summary>
        /// Delete perticular node
        /// </summary>
        /// <param name="value"></param>
        public void DeleteNodeWithValue(int value)
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            Node prev = this.head;
            Node pointsToValue = this.head;
            while (pointsToValue.data != value)
            {
                if (pointsToValue == null)
                {
                    break;
                }
                pointsToValue = pointsToValue.next;
            }
            while (prev.next.data != value)
            {
                if (prev == null)
                {
                    break;
                }
                prev = prev.next;
            }
            prev.next = pointsToValue.next;

        }
        public void SortDisplay()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to display");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
            Console.WriteLine();
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
