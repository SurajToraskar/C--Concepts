using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using _17_Inheritance;

namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {
            Animal whisker = new Animal()
            {
                Name = "Whisker",
                Sound="Meow"
            };

            Dog grover = new Dog()
            {
                Name="Grover",
                Sound="Woof",
                Sound2="Grrrrrr"
            };

            grover.Sound = "Woooooof";
            whisker.MakeSound();
            grover.MakeSound();
            whisker.SetAnimalIDInfo(12323, "Suraj");
            whisker.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine($"Is my animal healthy: {getHealth.HealthyWeight(11,46)}");

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooffff",
                Sound2="Geeerrrrr"
            };

            spot.MakeSound();

        }
    }
}