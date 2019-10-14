using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, HashSet<string>>> dict = new Dictionary<string, Dictionary<string, HashSet<string>>>(); 
            while (command != "Statistics")
            {
                string[] tokens = command.Split(" ");
                if (command.Contains("joined"))
                {
                    string newVlogger = tokens[0];

                    if (!dict.ContainsKey(newVlogger))
                    {
                        dict[newVlogger] = new Dictionary<string, HashSet<string>>();
                        dict[newVlogger]["followers"] = new HashSet<string>();
                        dict[newVlogger]["followed"] = new HashSet<string>();
                    }
                }
                else if (command.Contains("followed"))
                {
                    string vlogger = tokens[0];
                    string followedVlogger = tokens[2];
                    if (vlogger == followedVlogger)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    if (dict.ContainsKey(vlogger) && dict.ContainsKey(followedVlogger))
                    {
                        dict[followedVlogger]["followers"].Add(vlogger);
                        dict[vlogger]["followed"].Add(followedVlogger);
                 
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            int count = 1;

            foreach (var item in dict.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["followed"].Count()))
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["followed"].Count} following");
                if (count == 1)
                {
                    foreach (var followers in item.Value["followers"].OrderBy(x=>x))
                    {
                    Console.WriteLine($"*  {followers}");

                    }
                }
                count++;
            }
        }
    }
}
