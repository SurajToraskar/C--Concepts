using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using _19_Interfaces;

namespace Interfaces
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Vehicle buick = new Vehicle("Buick", 4, 160);
            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} can't be driven");
            }

            Console.ReadKey();
        }
    }
}