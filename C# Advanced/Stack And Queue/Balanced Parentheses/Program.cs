using System;
using System.Linq;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var queue = new Queue<char>();

            for (int i = 0; i < input.Length / 2; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = input.Length - 1; i >= input.Length / 2; i--)
            {
                if (input[i] == '}' && queue.Peek() == '{' || queue.Peek() == '[' && input[i] == ']' || queue.Peek() == '(' && input[i] == ')')
                {
                    queue.Dequeue();
                }
               else if (input[i] == '{' && queue.Peek() == '}' || queue.Peek() == ']' && input[i] == '[' || queue.Peek() == ')' && input[i] == '(')
                {
                queue.Dequeue();
                }
            }
            if (queue.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
