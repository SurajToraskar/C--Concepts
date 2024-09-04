using System;
using System.Globalization;

namespace ArrayChapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int[] numberArray = new int[3];
            numberArray[0] = 3;
            string[] nameArray = { "Suryakant", "Sonali", "Suraj", "Sairaj" };
            var randomArray = new[] { "Apple", "Mango" };
            object[] array = { "names", 123, 1.2, true };
            Console.WriteLine("array :{0}", array[0].GetType());
            Console.WriteLine("nameArray Length :{0}", nameArray.Length);
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine($"numberArray {i} : {numberArray[i]}");
            }
            string[,] stringArray = { { "Yamaha", "Ninja" },
                                      { "BMW","Mercedes"} };

            Console.WriteLine($"stringArray: {stringArray[0, 1]}");
            Console.WriteLine($"stringArray: {stringArray.GetValue(0, 1)}");

            for (int i = 0; i < stringArray.GetLength(0); i++)
            {
                for (int j = 0; j < stringArray.GetLength(0); j++)
                {
                    Console.WriteLine(stringArray[i, j]);
                }
                Console.WriteLine("");
            }
            int[] randomNumberArray = { 1, 2, 3, 4, 5, 6 };
            printArray(randomNumberArray, "foreach-Method");
            Console.WriteLine("----------------");
            Array.Sort(randomNumberArray);
            Console.WriteLine($"Sorted : {randomNumberArray}");
            Array.Reverse(randomNumberArray);
            Console.WriteLine(randomNumberArray);

            int[] srcArray = { 1, 2, 3, 4 };
            int[] destArray = new int[3];

            Array.Copy(srcArray,0,destArray,0,2);
            Console.WriteLine($"Destination : {destArray}");

            printArray(destArray, "DestinationArray");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            Console.WriteLine($"anotherArray : {anotherArray}");

            printArray((int[])anotherArray, "AnotherArray");

            int[] numArray = { 10, 22, 21 };

            Console.ReadKey();

        }


        static void printArray(int[] numberArray,string message)
        {
            foreach(int i in numberArray)
            {
                Console.WriteLine($"Number:{i} and Message:{message}");
            }
        }
    }
}