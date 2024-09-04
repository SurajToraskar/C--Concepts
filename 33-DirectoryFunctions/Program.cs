using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DirectoryFunction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo surajDir=new DirectoryInfo(@"C:\Users\toras\Desktop\asp.net-mvc-5\C#-full-course\C#-full-course.sln");
            Console.WriteLine(surajDir.FullName);
            Console.WriteLine(surajDir.Name);
            Console.WriteLine(surajDir.Parent);
            Console.WriteLine(surajDir.Attributes);
            Console.WriteLine(surajDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\toras\Desktop\asp.net-mvc-5\C#-full-course\C#CourseData");
            dataDir.Create();
            // Directory.Delete(@"C:\Users\toras\Desktop\asp.net-mvc-5\C#-full-course\C#CourseData");

            string[] customers = { "Bob Smith","Sally Smith","Robert Smith"};

            string textFilePath=@"C:\Users\toras\Desktop\asp.net-mvc-5\C#-full-course\C#CourseData\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);

            foreach(string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {customer}");
            }

            DirectoryInfo currentDirectory = new DirectoryInfo(@"C:\Users\toras\Desktop\asp.net-mvc-5\C#-full-course");
            FileInfo[] csFile = currentDirectory.GetFiles("*.cs",SearchOption.AllDirectories);

            Console.WriteLine($"Matches : {csFile.Length}");

            foreach(FileInfo file in csFile)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }


            Console.ReadKey();
        }
    }
}