using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;


namespace EnumeratedTypes
{
    public class Program
    {

        public static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with code {(byte)cc}");
        }

        public enum CarColor:byte
        {
            Orange=1,
            Blue,
            Green,
            Red,
            Yellow
        }
       
        public static void Main(string[] args)
        {
            CarColor car1 = CarColor.Green;
            
        }
    }
}