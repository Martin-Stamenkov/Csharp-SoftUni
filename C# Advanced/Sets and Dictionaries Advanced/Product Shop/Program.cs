using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] tokens = command.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict[shop] = new Dictionary<string, double>();
                    if (!dict[shop].ContainsKey(product))
                    {
                        dict[shop][product] = 0;
                    }
                    dict[shop][product] = price;
                }
                else
                {
                    dict[shop][product] = price;
                }

                command = Console.ReadLine();
            }

            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var shop in dict)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
