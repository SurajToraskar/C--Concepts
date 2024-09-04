using System;

namespace FormatOutput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Currency : {0:c}",24.5267);
            Console.WriteLine("Pads With 0s : {0:d4}",24);
            Console.WriteLine("Decimals : {0:f3}", 23.272828);
            Console.WriteLine("Commas :{0:n4}",240003);

            Console.ReadKey();
        }
    }
}