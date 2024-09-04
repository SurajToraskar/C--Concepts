using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListChapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            #region ArrayList

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine($"Count : {aList.Count}");
            Console.WriteLine($"Capacity : {aList.Capacity}");

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] {"Mike","Suraj"});

            aList.AddRange(aList2);
            aList.Sort();
            aList.Reverse();

            aList.Insert(1, "Turkey");
            aList2.RemoveAt(0);
            aList2.RemoveRange(0, 2);

            string[] myArray = (string[])aList.ToArray(typeof(string));
            #endregion


            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            Console.ReadKey();
        }
    }
}