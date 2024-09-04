using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool CanIVote = true;

            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", long.MinValue);

            decimal DecPiVal = 3.14526272728M;
            decimal DecRandomNumber = 3.00000000M;
            Console.WriteLine("DecPiVal + DecRandomNumber: {0} + {1} = {2}",DecPiVal,DecRandomNumber,DecRandomNumber+DecPiVal);

            Console.WriteLine("Biggest Double: {0}", double.MaxValue);
            double DblValue = 1.222222222222;
            double BigValue = 2.111111111111;
            Console.WriteLine("DblValue + BigValue: {0}",DblValue+BigValue);

            Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            float FltValue = 1.22222F;
            float FltBigValue = 2.333F;
            Console.WriteLine("FltValue + FltBigValue: {0}",FltValue+FltBigValue);

            Console.ReadKey();
        }
    }
}