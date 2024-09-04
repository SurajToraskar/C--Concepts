using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Delegates
{
    public class Program
    {
        public delegate void Arithmetic(double num1,double num2);
        public static void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Subtract(double num1,double num2)
        {
            Console.WriteLine(num1 - num2);

        }

        public static void Main(String[] args)
        {
            #region Delegates
            Console.ForegroundColor = ConsoleColor.Green;

            Arithmetic add, sub, addSub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;

            Console.WriteLine($"Add {6} and {10}");
            add(6, 10);
            Console.WriteLine($"Add and Subtract {10} and {4}");
            addSub(10, 4);



            Console.ReadKey();
            #endregion

        }
    }
}