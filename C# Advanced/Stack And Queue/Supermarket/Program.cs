using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    Console.WriteLine(queue.Count + " people remaining.");
                    break;
                }
                else if (input=="Paid")
                {
                    while (queue.Any())
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    continue;
                }
                queue.Enqueue(input);
            }
        }
    }
}
