using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Select
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var oneToTen = new List<int>();
            oneToTen.AddRange(Enumerable.Range(1, 10));
            var squares = oneToTen.Select(x => x * x);
            foreach(var i in squares){
                Console.WriteLine(i);
            }

        }
    }
}