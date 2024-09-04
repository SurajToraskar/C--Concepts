using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Zip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<int> listOne = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> listTwo = new List<int>() { 11, 12, 13, 14 ,15};
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach (int i in sumList) Console.WriteLine(i);
            Console.WriteLine(String.Join(",", sumList));

            //Aggregate
            var numList2 = new List<int>() { 1,2,3,4,5};
            Console.WriteLine($"Aggregate : {numList2.Aggregate((a,b)=>a+b)}");

            //Average
            Console.WriteLine($"Average : {numList2.Average()}");

            //All
            Console.WriteLine($"All : {numList2.All(x=>x>3)}");

            //Any
            Console.WriteLine($"Any : {numList2.Any(x=>x>3)}");
            numList2.Add(4);

            //Distinct
            Console.WriteLine($"Distinct : {String.Join(",",numList2.Distinct())}");

            //Except
            var listNumber1 = new List<int>() { 1, 2, 3, 2, 3 };
            var listNumber2 = new List<int>() { 3 };
            Console.WriteLine(String.Join(",",listNumber1.Except(listNumber2)));

            //Intersect
            Console.WriteLine(String.Join(",",listNumber1.Intersect(listNumber2)));





            Console.ReadKey();

        }
    }
}