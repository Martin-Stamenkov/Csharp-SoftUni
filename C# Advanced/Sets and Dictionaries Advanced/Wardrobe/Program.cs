using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] clothes = Console.ReadLine().Split(" -> ");
                string currentColor = clothes[0];
                string[] eachCloth = clothes[1].Split(",");

                if (!wardrobe.ContainsKey(currentColor))
                {
                    wardrobe[currentColor] = new Dictionary<string, int>();
                }
                foreach (var item in eachCloth)
                {
                    if (!wardrobe[currentColor].ContainsKey(item))
                    {
                        wardrobe[currentColor][item] = 0;
                    }
                    wardrobe[currentColor][item]++;
                }
            }

            string[] searchCloth = Console.ReadLine().Split(" ");
            string color = searchCloth[0];
            string cloth = searchCloth[1];

            foreach (var eachColor in wardrobe)
            {
                Console.WriteLine($"{eachColor.Key} clothes:");

                foreach (var item in eachColor.Value)
                {
                    if (color == eachColor.Key && cloth == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
