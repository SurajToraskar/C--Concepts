using System;


namespace ConditionalStatement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());

            if ((age > 5) && (age <= 7))
            {
                Console.WriteLine("Go to Elementary School");
            }else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to Middle School");
            }else if ((age > 13) && (age<17))
            {
                Console.WriteLine("Go to School");
            }
            else
            {
                Console.WriteLine("Go to Collage");
            }

            if ((age < 14) || (age > 69))
            {
                Console.WriteLine("You Shouldn't Work");
            }

            Console.WriteLine($"!true : {!true}");

            bool canDrive = age >= 16 ? true : false;
            Console.WriteLine(canDrive);

            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to DayCare");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Elementary School");
                    break;
                default:
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("figure out your own life");

            string name1 = "Suraj";
            string name2 = "Suraj";
            if (name1.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("String are Equals");
            }

        }
    }
}