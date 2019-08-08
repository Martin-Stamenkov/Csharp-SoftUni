using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double countFishingMan = int.Parse(Console.ReadLine());

            double priceBoat = 0;
            double discount = 0;

            if (season == "Spring")
            {
                priceBoat = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceBoat = 4200;

            }
            else if (season == "Winter")
            {
                priceBoat = 2600;
            }
            if (countFishingMan <= 6)
            {
                discount = 0.1;
            }
            else if (countFishingMan > 6 && countFishingMan <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }

            double priceAfterDiscount = priceBoat - priceBoat * discount;

            if (countFishingMan % 2 == 0 && season != "Autumn")
            {
                priceAfterDiscount = priceAfterDiscount - (priceAfterDiscount * 0.05);

            }
            if (budget < priceAfterDiscount)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(budget - priceAfterDiscount));
            }
            else if (budget >= priceAfterDiscount)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - priceAfterDiscount);
            }
        }
    }
}
