using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using _20_ComplexOopExamples;

namespace OopExample
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powerbtn = new PowerButton(TV);

            TV.Volume = 10;
            powerbtn.Execute();
            powerbtn.IncreaseVolume();
            powerbtn.IncreaseVolume();
            powerbtn.Undo();





            Console.ReadKey();
        }
    }
}