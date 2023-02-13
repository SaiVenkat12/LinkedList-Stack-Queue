using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    internal class Stack
    {
        public Node top;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(top==null)
            {
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
        }
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("{0} is at the top", top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("{0} is Removed from the Stack", top.data);
            top = top.next;
        }
        public void isEmpty()
        {
            while(top != null)
            {
                Peak();
                Pop();
            }          
        }
        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is Empty");
            else
            {
                Console.WriteLine("STACK");
                Node temp = top;
                while(temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
