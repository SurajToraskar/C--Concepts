using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Lambda
{
    public class Program
    {
        delegate double doubleIt(double value);
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 *2 = {dblIt(5)}");

            List<int> numList = new List<int>() { 1,9,2,6,3};
            var evenList = numList.Where(x => x % 2 == 0).ToList();

            foreach(int i in evenList)
            {
                Console.WriteLine(i);
            }

            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach(int i in rangeList)
            {
                Console.WriteLine(i);
            }

            List<int> flipList=new List<int>();
            Random randomNumber = new Random();
            int j = 0;
            while (j < 100)
            {
                flipList.Add(randomNumber.Next(1, 3));
                j++;
            }

            Console.WriteLine($"Heads : {flipList.Where(h=>h==1).ToList().Count()}");
            Console.WriteLine($"Tails : {flipList.Where(t=>t==2).ToList().Count()}");
            var nameList = new List<string>() { "Doug" ,"Sally","Sue"};
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var item in sNameList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}