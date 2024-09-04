using System;

namespace ExceptionHandling
{
    public class Program
    {
        static double DoDivision(double x,double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double num1 = 5;
            double num2 = 0;

            try
            {
                DoDivision(num1, num2);
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Divide by Zero Error");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine("Error Ocurred");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning the database");
            }
        }
    }
}