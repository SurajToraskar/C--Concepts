using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What is your Name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

        }
    }
}