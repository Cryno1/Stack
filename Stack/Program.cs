using Stack.Model;
using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyStack = new EasyStack<int>();

            easyStack.Push(1);
            easyStack.Push(4);
            easyStack.Push(2);
            easyStack.Push(6);

            var item = easyStack.Pop();

            var item2 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);

            Console.WriteLine();

            Stack<double> stack = new Stack<double>();

            var linkedStack = new LinkedStack<int>();

            var arrayStack = new ArrayStack<int>(5);

            arrayStack.Push(101);
            arrayStack.Push(10);
            arrayStack.Push(33);
            arrayStack.Push(20);
            arrayStack.Push(15);
            
            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());

            Console.WriteLine(arrayStack.ToString());


            Console.ReadLine();
        }
    }
}
