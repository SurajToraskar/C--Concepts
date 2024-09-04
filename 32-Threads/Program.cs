using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using _32_Threads;

namespace Threads
{
    public class Program
    {
        public static void Print1()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }


        public static void ToCount(int maxValue)
        {
            for (int i = 0; i < maxValue; i++)
            {
                Console.WriteLine(i);
            }
        }


        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Thread t = new Thread(Print1);
            t.Start();
            for(int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }

            Console.WriteLine();

            Console.WriteLine("Sleep Function Starts");
            int num = 1;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Sleep Function Ends");

            Console.WriteLine("Bank Account");

            BankAccount account = new BankAccount(10);
            Thread.CurrentThread.Name = "main";
            Thread[] threads = new Thread[15];

            account.BankBalance();


            for(int i = 0; i < 15; i++)
            {
                Thread t1 = new Thread(new ThreadStart(account.IssueWithdraw));
                t1.Name = i.ToString();
                threads[i] = t1;
            }

            account.BankBalance();

            for(int i = 0; i < threads.Length; i++)
            {
                Console.WriteLine($"Thread {threads[i].Name} Alive : {threads[i].IsAlive}");
                threads[i].Start();
                Console.WriteLine($"Thread {threads[i].Name} Alive : {threads[i].IsAlive}");
            }

            Console.WriteLine($"Current Priority {Thread.CurrentThread.Priority}");
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} Ending");
            Console.ReadKey();




            Thread t38 = new Thread(() => ToCount(10));
            t38.Start();

            new Thread(() =>
            {
                ToCount(10);
                ToCount(20);
            }).Start();
        }
     
    }
}