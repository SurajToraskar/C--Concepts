using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using _14_DateAndTimeSpan;
using _15_ClassAndObject;

namespace ClassAndObject
{
    public class Program
    {
        struct Rectangle
        {
            public double Length;
            public double Width;

            public Rectangle(double length=1,double width = 1)
            {
                this.Length = length;
                this.Width = width;

            }
            public double Area()
            {
                return Length * Width;
            }
        }
        public static void Main(string[] args)
        {
            /*    Console.ForegroundColor = ConsoleColor.Green;
                Rectangle rectangle1;
                rectangle1.Length = 200;
                rectangle1.Width = 50;
                Console.WriteLine($"Area of Rectangle1 : {rectangle1.Area()}");

                Rectangle rectangle2;
                rectangle2.Length = 300;
                rectangle2.Width = 100;
                Console.WriteLine($"Area of Rectangle2 : {rectangle2.Area()}");

                rectangle2 = rectangle1;
                rectangle1.Length = 500;
                Console.WriteLine($"rectangle2.Length : {rectangle2.Length}");


                Animal fox = new Animal("red","Raw");


                Console.WriteLine($"Number of Animal : {Animal.GetNumAnimals()}");

                Console.WriteLine($"Area of Rectangle : {ShapeMath.GetArea("rectangle",20,10)}");

                Console.WriteLine($"Area of Circle : {ShapeMath.GetArea("circle",10,10)}");


                int? randomNum = null;
                if (randomNum == null)
                {
                    Console.WriteLine("randomNumber is null");
                }

                if (!randomNum.HasValue)
                {
                    Console.WriteLine("randomNumber is null");
                }

                */

            Animal cat = new Animal();
            cat.SetName("Panchu");
            cat.sound="Meow";
            Console.WriteLine($"The cat is name {cat.GetName()} and says {cat.sound}");
            cat.Owner = "Suraj";
            Console.WriteLine($"{cat.GetName()} owner is {cat.Owner}");
            Console.WriteLine($"{cat.GetName()} shelter id is {cat.idNum}");
            Console.WriteLine($"Number of Animals is {Animal.SetGetNumberOfAnimals}");




            Console.ReadKey();
        }
    }
}