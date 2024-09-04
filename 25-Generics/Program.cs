using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using _25_Generics;

namespace Generics
{
    public class Program
    {
        public static void Concatenate<T>(T a,T b)
        {
            string strA = a.ToString();
            string strB = b.ToString();
            Console.WriteLine(strA + strB);
        }
        public static void Main(string[] args)
        {
            #region Generics
            Console.ForegroundColor = ConsoleColor.Green;
            List<Animal> animalList = new List<Animal>();
            List<int> numberList = new List<int>();
            numberList.Add(24);

            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal("Paul"));
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1,new Animal() {Name="Mark" });
            animalList.RemoveAt(1);

            Console.WriteLine($"Num of Animals :{animalList.Count()}");
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
            }

            int x = 4, y = 5;
            Animal.GetSum<int>(ref x,ref y);
            string strX = "4", strY = "5";
            Animal.GetSum<String>(ref strX, ref strY);

            Concatenate<int>(3, 4);
            Concatenate<double>(4.5, 3.4);

            Rectangle<int> rectangle = new Rectangle<int>(20,50);
            Console.WriteLine(rectangle.GetArea());

            Rectangle<string> rectangle2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rectangle2.GetArea());

            Console.ReadKey();
            #endregion
        }
        public struct Rectangle<T>
        {
            private T width;
            private T length;
            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T width, T length)
            {
                this.width = width;
                this.length = length;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(width);
                double dblLength = Convert.ToDouble(length);
                return $"{Width} * {Length} = {dblLength*dblWidth}";
            }
        }


    }
}