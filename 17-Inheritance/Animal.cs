using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Inheritance
{
     class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public static int numberOfAnimals;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum,string owner )
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public int NumberOfAnimals
        {
            get { return numberOfAnimals; }
            set
            {
                numberOfAnimals += value;
            }
        }
        
        readonly int idNum;

        public Animal():this("No Name","No Sound") { }

        public Animal(string name):this(name,"No Sound") { }

        public Animal(string name,string sound)
        {
            this.Name = name;
            this.Sound = sound;
            NumberOfAnimals = 1;

            Random randomNumber = new Random();
            idNum=randomNumber.Next(1, 100000000);
        }


        public class AnimalHealth
        {
            public bool HealthyWeight(double height,double weight)
            {
                double calc = height / weight;
                return (calc >= .18) && (calc <= .27) ? true : false;
            }
        }




    }
}
