using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Linked List Stack and Queue");
            Stack stack= new Stack();
            Queue queue = new Queue();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Please Choose \n1.Stack \n2.Queue \n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.Add(56);
                        stack.Add(30);
                        stack.Add(70);
                        stack.Display();
                        stack.isEmpty();
                        stack.Display();
                        break;
                    case 2:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Dequeue();
                        queue.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the Correct Number !");
                        break;
                }
            }
        }
    }
}
