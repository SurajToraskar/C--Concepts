using System;

namespace Casting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("1");
            double doubleFromStr = double.Parse("12.2222");
            string stringFromDouble = doubleFromStr.ToString();

            Console.WriteLine($"DataType : {stringFromDouble.GetType()}");

            double dblValue = 12.345;
            Console.WriteLine($"Integer: {(int)dblValue}");
            Console.ReadKey();

        }
    }
}