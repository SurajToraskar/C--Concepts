using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DateTimeSpan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            DateTime awesomeDate = new DateTime(2001,05,29);
            Console.WriteLine("Day of the week :{0}",awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(1);
            awesomeDate = awesomeDate.AddMonths(5);
            awesomeDate = awesomeDate.AddYears(2);
            Console.WriteLine("New Date : {0}",awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0,15,0));
            Console.WriteLine("New TimeSpan :{0}", lunchTime.ToString());
            Console.ReadKey();
        }
    }
}