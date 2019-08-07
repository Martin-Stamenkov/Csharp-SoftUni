using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split(" ");
                string currentCommand = tokens[0];
                if (currentCommand == "Delete")
                {
                    int currentNum = int.Parse(tokens[1]);
                    numbers.RemoveAll(x => x == currentNum);
                }
                else if (command == "Insert")
                {
                    int currentNum = int.Parse(tokens[1]);
                    int element = int.Parse(tokens[2]);
                    numbers.Insert(element, currentNum);
                }

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
