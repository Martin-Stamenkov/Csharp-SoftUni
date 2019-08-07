using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();
            for (int i = 0; i < numOfCommands; i++)
            {

                string[] commandLine = Console.ReadLine().Split(" ");
                string names = commandLine[0];
                if (commandLine.Contains("not"))
                {
                    if (guest.Contains(names))
                    {
                        guest.Remove(names);
                    }
                    else
                    {
                        Console.WriteLine($"{names} is not in the list!");
                    }
                }
                else
                {
                    if (guest.Contains(names))
                    {
                        Console.WriteLine($"{names} is already in the list!");
                    }
                    else
                    {
                        guest.Add(names);
                    }
                }
            }
            for (int i = 0; i < guest.Count; i++)
            {
                Console.WriteLine(guest[i]);
            }
        }
    }
}
