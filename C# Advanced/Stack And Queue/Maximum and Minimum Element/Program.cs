using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ");

                string currentCommand = commands[0];
                
                if (currentCommand == "1")
                {
                    string num = commands[1];
                    stack.Push(num);
                }
                else if (currentCommand == "2")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                }
                else if (currentCommand == "3")
                {
                    Console.WriteLine(stack.Max());
                }
                else if (currentCommand == "4")
                {
                    Console.WriteLine(stack.Min());
                }

            }
            Console.WriteLine(string.Join(", ",stack));

        }
    }
}
