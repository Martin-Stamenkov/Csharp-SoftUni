using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> funcStartsWith = (name, firstLetter) => name.StartsWith(firstLetter);
            Func<string, string, bool> funcEndsWith = (name, lastLetter) => name.EndsWith(lastLetter);
            Func<string, int, bool> funcNameLength = (name, length) => name.Length == length; 

            var guests = Console.ReadLine()
                 .Split(" ")
                 .ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandLine = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandLine[0];
                string criteria = commandLine[1];

                if (currentCommand == "Double")
               {
                    if (criteria == "StartsWith")
                    {
                        string firstLetter = commandLine[2];
                        var temp = guests.Where(name => funcStartsWith(name, firstLetter)).ToList();
                        AddRange(guests, temp);
                    }
                    else if (criteria == "EndsWith")
                    {
                        string lastLetter = commandLine[2];
                        var temp = guests.Where(name => funcEndsWith(name, lastLetter)).ToList();
                        AddRange(guests, temp);
                    }
                    else if (criteria == "Length")
                    {
                        int length = int.Parse(commandLine[2]);
                        var temp = guests.Where(name => funcNameLength(name, length)).ToList();
                        AddRange(guests,temp);
                    }
                    
                }
                else if (currentCommand == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        string firstLetter = commandLine[2];
                        guests = guests.Where(name => !funcStartsWith(name, firstLetter)).ToList();
                       
                    }
                    else if (criteria == "EndsWith")
                    {
                        string lastLetter = commandLine[2];
                        guests = guests.Where(name => !funcEndsWith(name, lastLetter)).ToList();
                    }
                    else if (criteria == "Length")
                    {
                        int length = int.Parse(commandLine[2]);
                        guests = guests.Where(name => !funcNameLength(name, length)).ToList();
                    }
                }

                command = Console.ReadLine();
            }
            guests = guests.OrderBy(x => x).ToList();

            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(", ",guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        private static void AddRange(List<string> guests, List<string> temp)
        {
            foreach (var name in temp)
            {
                int index = guests.IndexOf(name);
                guests.Insert(index, name);
            }
        }
    }
}
