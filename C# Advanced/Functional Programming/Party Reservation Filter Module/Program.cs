using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                 .Split(" ")
                 .ToList();

            var command = Console.ReadLine();

            Func<string, string, bool> funcStartsWith = (name, firstLetter) => name.StartsWith(firstLetter);
            Func<string, string, bool> funcEndsWith = (name, lastLetter) => name.EndsWith(lastLetter);
            Func<string, int, bool> funcLengthName = (name, length) => name.Length == length;
            Func<string, string, bool> funcContainsString = (name, str) => name.Contains(str);

            var removeGuests = new List<string>();

            while (command != "Print")
            {
                var commandLine = command.Split(";");
                var currentFilter = commandLine[0];
                var currentTypeFilter = commandLine[1];

                if (currentFilter == "Add filter")
                {
                    if (currentTypeFilter == "Starts with")
                    {
                        var param = commandLine[2];
                        var temp = guests.Where(name => funcStartsWith(name, param)).ToList();
                        guests = guests.Where(name => !funcStartsWith(name, param)).ToList();
                        removeGuests.AddRange(temp);

                    }
                    else if (currentTypeFilter == "Ends with")
                    {
                        var param = commandLine[2];
                        var temp = guests.Where(name => funcEndsWith(name, param)).ToList();
                        guests = guests.Where(name => !funcEndsWith(name, param)).ToList();
                        removeGuests.AddRange(temp);
                    }
                    else if (currentTypeFilter == "Length")
                    {
                        var paramLength = int.Parse(commandLine[2]);
                        var temp = guests.Where(name => funcLengthName(name, paramLength)).ToList();
                        guests = guests.Where(name => !funcLengthName(name, paramLength)).ToList();
                        removeGuests.AddRange(temp);
                    }
                    else if (currentTypeFilter == "Contains")
                    {
                        var param = commandLine[2];
                        var temp = guests.Where(name => funcContainsString(name, param)).ToList();
                        guests = guests.Where(name => !funcContainsString(name, param)).ToList();
                        removeGuests.AddRange(temp);
                    }
                }
                else if (currentFilter == "Remove filter")
                {
                    if (currentTypeFilter == "Starts with")
                    {
                        var param = commandLine[2];
                        var temp = removeGuests.Where(name => funcStartsWith(name, param));
                        guests.AddRange(temp);
                        guests.Reverse();
                    }
                    else if (currentTypeFilter == "Ends with")
                    {
                        var param = commandLine[2];
                        var temp = removeGuests.Where(name => funcEndsWith(name, param));
                        guests.AddRange(temp);
                        guests.Reverse();
                    }
                    else if (currentTypeFilter == "Length")
                    {
                        var paramLength = int.Parse(commandLine[2]);
                        var temp = removeGuests.Where(name => funcLengthName(name, paramLength)).ToList();
                        guests.AddRange(temp);
                        guests.Reverse();
                    }
                    else if (currentTypeFilter == "Contains")
                    {
                        var param = commandLine[2];
                        var temp = removeGuests.Where(name => funcContainsString(name, param)).ToList();
                        guests.AddRange(temp);
                        guests.Reverse();
                    }
                }


                command = Console.ReadLine();
            }
            if (guests.Any())
            {
                Console.WriteLine(string.Join(" ", guests));
            }
        }
    }
}
