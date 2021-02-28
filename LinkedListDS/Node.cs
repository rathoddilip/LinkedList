using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDS
{
    public class Node
    {
        public int data;
        public Node next;
        /// <summary>
        /// Prepare a Node
        /// </summary>
        /// <param name="dataNode"></param>
        public Node(int dataNode)
        {
            data = dataNode;
            next = null;
        }
    }
}
