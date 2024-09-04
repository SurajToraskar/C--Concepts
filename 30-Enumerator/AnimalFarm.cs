using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace _30_Enumerator
{
     class AnimalFarm:IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();
        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm() { }

        public Animal this[int index]
        {
            get { return animalList[index]; }
            set
            {
                animalList.Insert(index, value);
            }
        }
         
        public int Count
        {
            get
            {
                return this.animalList.Count();
            }
        }



        public IEnumerator GetEnumerator()
        {
            return this.animalList.GetEnumerator();
        }


    }
}
