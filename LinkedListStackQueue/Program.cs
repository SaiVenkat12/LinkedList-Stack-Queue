﻿using System;
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
            stack.Add(30);
            stack.Add(50);
            stack.Add(10);
            stack.Display();
            Console.ReadLine();
        }
    }
}