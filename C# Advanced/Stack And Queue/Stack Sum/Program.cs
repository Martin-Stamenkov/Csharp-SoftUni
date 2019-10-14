using System;
using System.Linq;
using System.Collections.Generic;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                string currentCommand = command[0].ToLower();

                if (currentCommand == "end")
                {
                    break;
                }
                else if (currentCommand == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (currentCommand == "remove")
                {
                    int count = int.Parse(command[1]);

                    for (int i = 0; i < count; i++)
                    {
                        if (count > stack.Count)
                        {
                            break;
                        }
                        if(stack.Any())
                        {
                            stack.Pop();
                        }
                    }
                }

            }
            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
