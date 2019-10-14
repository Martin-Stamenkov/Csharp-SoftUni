using System;
using System.Linq;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict =  new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" ");
                string continent = inputLine[0];
                string country = inputLine[1];
                string city = inputLine[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent][country] = new List<string>();
                        dict[continent][country].Add(city);
                    }
                }
                else
                {
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent][country] = new List<string>();
                        dict[continent][country].Add(city);
                    }
                    else
                    {
                        dict[continent][country].Add(city);
                    }

                }
            }

            foreach (var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
