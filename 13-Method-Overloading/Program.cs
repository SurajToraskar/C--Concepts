using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MethodOverloading
{
    public class Program
    {
        public static double GetSum2(double x,double y)
        {
            return x + y;
        }

        public static double GetSum2(string x,string y)
        {
            double dblX = Double.Parse(x);
            double dblY = Double.Parse(y);
            return dblX + dblY;
        }
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GetSum2(11.4, 12.1)}");
            Console.WriteLine($"{GetSum2("12","13")}");
            Console.ReadKey();
        }
    }
}