using System;

namespace WhileLoop
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");

            Random randomNumber = new Random();
            int secretNumber = randomNumber.Next(1,11);
            int numberGuessed = 0;

            do
            {
                Console.Write("Guess The Number Between 0 to 10 :");
                numberGuessed = int.Parse(Console.ReadLine());

            } while (secretNumber != numberGuessed);
            Console.WriteLine("You Guessed it Correct .The number is {0}", secretNumber);

        }
    }
}