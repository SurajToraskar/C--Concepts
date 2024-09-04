using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using _31_LINQ;


namespace LINQ
{
    public class Program
    {
        static int[] QueryIntArray()
        {
            int[] nums = {5,10,15,20,25,30,35};

            var gt20 = from num in nums
                       where num > 0
                       select num;

            foreach(var num in gt20)
            {
                Console.WriteLine(num);
            }

            var ListGT20 = gt20.ToList<int>();
            var ArrayGT20 = gt20.ToArray();

            Console.WriteLine($"nums : {nums.GetType()}");
            Console.WriteLine($"ListGT20 : {ListGT20.GetType()}");
            Console.WriteLine($"ArrayGT20 : {ArrayGT20.GetType()}");

            nums[0] = 40;

            Console.WriteLine("After changing the value");
            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
            return ArrayGT20;
            
        }
        public static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            string[] dogs ={ "K 9", "Brain Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin","Lassie","Snoopy"};

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach(var dog in dogSpaces)
            {
                Console.WriteLine(dog);
            }

            

            int[] numsArray = QueryIntArray()
;
            Console.WriteLine("In Main Function");

            foreach (var num in numsArray)
            {
                Console.WriteLine(num);
            }
            
            

            Console.WriteLine("Animal and Owner class examples");

            ArrayList animalList = new ArrayList()
            {
                new Animal{Name="German Shephard",Height=.8,Weight=18,AnimalId=1},
                new Animal{Name="Chihuahuia",Height=5,Weight=130,AnimalId=2},
                new Animal{Name="Saint Bernard",Height=3.8,Weight=90,AnimalId=3}
            };

            Owner[] owners = new[]
            {
                new Owner{Name="Doug Parks",OwnerId=1},
                new Owner{Name="Sally Smith",OwnerId=2 },
                new Owner{Name="Paul Brooks",OwnerId=3 }
            };
            var newAnimalList = animalList.OfType<Animal>();
            var nameAndHeight = from animal in newAnimalList
                                select new
                                {
                                    animal.Name,
                                    animal.Weight
                                };
            Array arrayNameAndHeight = nameAndHeight.ToArray();

            foreach(var i in arrayNameAndHeight)
            {
                Console.WriteLine(i.ToString());
            }

            var innerJoin = from animal in newAnimalList
                            join owner in owners on
                            animal.AnimalId equals owner.OwnerId
                            select new
                            {
                                OwnerName = owner.Name,
                                AnimalName = animal.Name
                            };

            Console.WriteLine("Owner Name and Animal Name");
            foreach(var i in innerJoin)
            {
                Console.WriteLine($"{i.OwnerName} owns {i.AnimalName}");
            }

            var groupJoin = from owner in owners
                            orderby owner.OwnerId
                            join animal in newAnimalList
                            on owner.OwnerId equals animal.AnimalId
                            into ownerGroup
                            select new
                            {
                                Owner=owner.Name,
                                Animals=from owner2 in ownerGroup
                                        orderby owner2.Name
                                        select owner2
                            };
      
            int totalAnimals = 0;

            Console.WriteLine("Group Join");
            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine(" * "+animal.Name);
                }
            }

            var famAnimalEnumerable = animalList.OfType<Animal>();

            var smallAnimals = from animal in famAnimalEnumerable
                               where (animal.Weight <= 90)&&(animal.Height>2)
                               orderby animal.Name
                               select animal;

            foreach(var animal in smallAnimals)
            {
                Console.WriteLine($"{animal.Name} weighs {animal.Weight}lbs");
            }


            Console.ReadKey();
        }
    }
}