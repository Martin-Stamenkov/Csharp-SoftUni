using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            int push = commands[0];
            int pop = commands[1];
            int peek = commands[2];

            if (push <= numbers.Length)
            {
                for (int i = 0; i < push; i++)
                {
                    stack.Push(numbers[i]);
                }
            }
            if (stack.Count >= pop)
            {
                for (int i = 0; i < pop; i++)
                {
                    stack.Pop();
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