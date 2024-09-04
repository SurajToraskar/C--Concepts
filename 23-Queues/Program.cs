using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Queues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Queue
            Console.ForegroundColor = ConsoleColor.Green;
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine($"1 in Queue {queue.Contains(1)}");
            Console.WriteLine($"Remove : {queue.Dequeue()}");
            Console.WriteLine($"Peek : {queue.Peek()}");
            object[] numArray=queue.ToArray();
            Console.WriteLine(String.Join(",", numArray));
            foreach(object obj in numArray )
            {
                Console.WriteLine(obj);
            }

            queue.Clear();
            #endregion
        }
    }
}