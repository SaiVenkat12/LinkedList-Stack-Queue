using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    internal class Queue
    {
        public Node head;
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            { 
                head = newNode;
                Console.WriteLine("{0} is inserted into the Queue ", head.data);
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into the Queue ", newNode.data);
            }
        }
        public void Dequeue()
        {
            if (head == null)
                Console.WriteLine("Queue is Empty");
            else
            {
                Console.WriteLine("{0} is removed from the Queue", head.data);
                head = head.next;
            }
        }
        public void Display()
        {
            Console.WriteLine("QUEUE");
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
