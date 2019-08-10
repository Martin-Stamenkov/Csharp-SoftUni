using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int countBottles = int.Parse(Console.ReadLine());
            int countChips = int.Parse(Console.ReadLine());

            double totalPriceBeer = countBottles * 1.20;
            double pricePerPacketChips = totalPriceBeer * 0.45;
            double totalPriceChips = Math.Ceiling(pricePerPacketChips * countChips);
            double totalSum = totalPriceBeer + totalPriceChips;
            if (budget >= totalSum)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalSum:f2} leva left.");
            }
            else if (budget<totalSum)
            {
                Console.WriteLine($"{name} needs {Math.Abs(totalSum-budget):f2} more leva!");
            }

        }

    }
}
