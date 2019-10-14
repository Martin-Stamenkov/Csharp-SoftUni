using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] childrens = Console.ReadLine().Split(" ");

            var queue = new Queue<string>(childrens);

            int count = int.Parse(Console.ReadLine());

            while (queue.Count!=1)
            {
                for (int i = 1; i <=count; i++)
                {
                    if (i == count)
                    {
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                        continue;
                    }
                    queue.Enqueue(queue.Dequeue());
 
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
