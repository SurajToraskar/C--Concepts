using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace StacksImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Stacks
            Console.ForegroundColor = ConsoleColor.Green;
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Peek : {stack.Peek()}");
            Console.WriteLine($"pop : {stack.Pop()}");
            Console.WriteLine($"Contains : {stack.Contains(2)}");
            object[] numArray = stack.ToArray();
            Console.WriteLine(String.Join(",", numArray));

            foreach(object obj in stack)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
            #endregion
        }
    }
}