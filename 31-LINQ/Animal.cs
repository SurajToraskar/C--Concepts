using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_LINQ
{
     class Animal
    {
        public string Name { get; set; }
        public  double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalId { get; set; }

        public Animal(string name="No Name",double weight=0,double height=0)
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
        }

        public override string ToString()
        {
            return string.Format($"{this.Name} Weighs {this.Weight}lbs and is {this.Height} inches tall");
        }
    }
}
