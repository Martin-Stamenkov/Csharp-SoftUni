using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var stack = new Queue<int>();

            int enqueue = commands[0];
            int dequeue = commands[1];
            int peek = commands[2];

            if (enqueue <= numbers.Length)
            {
                for (int i = 0; i < enqueue; i++)
                {
                    stack.Enqueue(numbers[i]);
                }
            }
            if (stack.Count >= dequeue)
            {
                for (int i = 0; i < dequeue; i++)
                {
                    stack.Dequeue();
                }
            }
            if (stack.Any())
            {
                if (stack.Contains(peek))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
