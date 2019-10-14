using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            Func<int, int> add = x => x + 1;
            Func<int, int> multyply = x => x * 2;
            Func<int, int> subtract = x => x - 1;

            while (command!="end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command == "multyply")
                {
                    numbers = numbers.Select(multyply).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                command = Console.ReadLine();
            }
        }
    }
}
