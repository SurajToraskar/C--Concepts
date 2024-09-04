using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using _18_AbstractClassesAndMethods;

namespace AbstractClassesMethod
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} Area : {shape.Area()}");

                Circle testCircle = shape as Circle;
                if( testCircle == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if(shape is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }

            }

            object circ1 = new Circle(5);
            Circle circ2 = (Circle)circ1;
            Console.WriteLine($"The {circ2.Name} Area is {circ2.Area()}");

            Console.ReadKey();
        }
    }
}