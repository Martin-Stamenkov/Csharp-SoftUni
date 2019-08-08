using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = budget * 0.30;
                }
                else if (season == "winter")
                {
                    price = budget * 0.70;
                }
                Console.WriteLine("Somewhere in Bulgaria");
            }
            if (budget > 100 && budget<= 1000)
            {
                if (season == "summer")
                {
                    price = budget * 0.40;
                }
                else if (season == "winter")
                {
                    price = budget * 0.80;
                }
                Console.WriteLine("Somewhere in Balkans");
            }
            else if (budget>1000)
            {
                price = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
            }
            if (budget>1000 || budget<=1000 && season=="winter")
            {
                Console.WriteLine("Hotel - {0:f2}", price);
            }
            else if (season=="summer")
            {
                Console.WriteLine("Camp - {0:f2}",price);
            }
        }
    }
}
