using System;
using System.Linq;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passedCars = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();

            int count = 0;

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }
                else if (inputLine == "green")
                {
                    for (int i = 0; i < passedCars; i++)
                    {
                        if(queue.Any())
                        {
                             Console.WriteLine($"{queue.Dequeue()} passed!");
                             count++;
                        }
                    }
                    continue;
                }
                queue.Enqueue(inputLine);
            }
        }
    }
}
