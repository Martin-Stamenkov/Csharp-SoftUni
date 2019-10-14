using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine()
                .Split(", ");

            var queue = new Queue<string>(songs);

            while (queue.Any())
            {
                var line = Console.ReadLine();
                var command = line.Split(" ");
                var currentCommand = command[0];

                if (currentCommand == "Add")
                {
                    var newSong = line.Substring(4);
                    if (!queue.Contains(newSong))
                    {
                        queue.Enqueue(newSong);
                    }
                    else
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                }
                else if (currentCommand == "Play")
                {
                    queue.Dequeue();
                }
                else if (currentCommand == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }

            }
            Console.WriteLine("No more songs!");

        }
    }
}
