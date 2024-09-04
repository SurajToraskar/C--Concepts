using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DateAndTimeSpan
{
     class Animal
    {
        public static int NumberOfAnimals = 0;
        private string Name;
        private string Sound;
        public const string SHELTER = "Animal Shelter";
        public readonly int idNum;

        public Animal():this("No Name","No Sound") { }
        
        public Animal(string name):this(name,"No Sound") { }

        public Animal(string name, string Sound)
        {
            SetName(name);
            sound = Sound;
            SetGetNumberOfAnimals = 1;
            Random randomNumber = new Random();
            idNum = randomNumber.Next(1,2147483640);
            
        }

        public void MakeSound()
        {
            Console.WriteLine($"{this.Name} says {this.Sound}");
        }

        public static int GetNumAnimals()
        {
            return NumberOfAnimals;
        }
        
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.Name = name;
            }
            else
            {
                this.Name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        public string GetName()
        {
            return this.Name;
        }
        public string sound {
            get { return this.Sound; }
            set
            {
                if (value.Length > 10)
                {
                    this.Sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    this.Sound = value;
                }
            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int SetGetNumberOfAnimals
        {
            get
            {
                return NumberOfAnimals;
            }
            set
            {
                NumberOfAnimals += value;
            }
        }

    }
}
