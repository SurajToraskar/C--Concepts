using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            #region Dictionary
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent","Superman");
            superheroes.Add("Tony Stark","Ironman");
            superheroes.Add("Steve Roger", "Captian America");
            superheroes.Add("Bruce Wayne", "Batman");

            superheroes.Remove("Clark Kent");

            Console.WriteLine($"Count : {superheroes.Count}");
            Console.WriteLine($"Tony Stark : {superheroes.ContainsKey("Tony Stark")}");

            superheroes.TryGetValue("Tony stark", out string  value);
            Console.WriteLine($"Tony Stark : {value}");


            Console.WriteLine("===========================================================================");
            foreach(KeyValuePair<string,string> item in superheroes)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            Console.WriteLine("===========================================================================");
            foreach(string i in superheroes.Keys) {
                Console.WriteLine(i);
            }
            Console.WriteLine("===========================================================================");
            foreach(string i in superheroes.Values)
            {
                Console.WriteLine(i);
            }

            superheroes.Clear();

            #endregion
            Console.ReadKey();
        }
    }
}