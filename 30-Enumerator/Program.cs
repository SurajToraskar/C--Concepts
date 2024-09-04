using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using _30_Enumerator;

namespace Enumerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Dukar");
            myAnimals[1] = new Animal("Kutro");
            myAnimals[2] = new Animal("Manjur");
            myAnimals[3] = new Animal("hundir");

            foreach (Animal i in myAnimals)
            {
                Console.WriteLine(i.Name);
            }

            Box box1 = new Box(2,3,4);
            Box box2 = new Box(5,6,7);
            Box box3 = box1 + box2;
            Box box4= box1 + box2;
            
            Console.WriteLine(box3);

            Console.WriteLine((Box)2);
            Console.WriteLine((int)box1);

            #region Anonymous Type

            var shopkins = new
            {
                Name = "Chocolate",
                Price = 70
            };

            Console.WriteLine($"{shopkins.Name} costs Rs {shopkins.Price}Rs");


            var toyShop = new[]
            {
                new{Name="Transformer-Toy" ,Price=800},
                new{Name="Hot-Wheels",Price=900}
            };

            foreach(var item in toyShop)
            {
                Console.WriteLine($"{item.Name} costs Rs {item.Price}");
            }
            #endregion

            Console.ReadKey();

        }
    }
}