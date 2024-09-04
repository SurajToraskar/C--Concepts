using System;
using System.Globalization;
using System.Text;

namespace StringBuilderProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More stuff that is very important",256);

            Console.WriteLine($"sb Capacity : {sb.Capacity}");
            Console.WriteLine($"sb Length : {sb.Length}");
            Console.WriteLine($"sb2 Capacity : {sb2.Capacity}");
            Console.WriteLine($"sb2 Length : {sb2.Length}");

            sb2.AppendLine("\n More Important Text");
            Console.WriteLine();
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCustomer = "Suraj Toraskar";
            sb2.AppendFormat(enUS, "Best Customer {0}", bestCustomer);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("Text", "Characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb2.Equals(sb));
            sb2.Insert(11,"that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());


            Console.ReadKey();

        }
    }
}