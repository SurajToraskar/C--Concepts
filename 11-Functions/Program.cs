using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Functions
{
    public class Program
    {
       // <Access Specifier> <Return Type> <Method Name>(Parameters)
       // {<Body>}
        public static void sayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public static double GetSum(double x,double y)
        {
            return x + y;
        }

        public static void doubleIt(int x, out int solution)
        {
            solution = x * 2;

        }

        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        public static void printInfo(string name,int zipCode)
        {
            Console.WriteLine($"Name is {name} and zipCode is {zipCode}");
        }

        public static void Main(string[] args)
        {
            /*  Console.ForegroundColor = ConsoleColor.Green;
              sayHello();
              double x = 5;
              double y = 4;
              Console.WriteLine($"5 + 4 = {GetSum(5,4)}");*/

            /*  int solution;
              doubleIt(15, out solution);
              Console.WriteLine(solution);*/

            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Before Swap num1 : {num1} and num2 : {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"After Swap num1 : {num1} and num2 : {num2}");

            Console.WriteLine($"Params keyword : {GetSumMore(1,2,3,4,5,6,7)}");

            printInfo(zipCode: 403802, name: "Suraj Toraskar");
            Console.ReadKey();
        }
    }
}