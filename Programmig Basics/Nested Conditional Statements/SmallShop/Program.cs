using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double total = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    total = quantity * 0.50;
                }
                else if (product == "water")
                {
                    total = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    total = quantity * 1.20;
                }
                else if (product == "sweets")
                {
                    total = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    total = quantity * 1.60;
                }

                Console.WriteLine(total);
            }

            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    total = quantity * 0.40;
                }
                else if (product == "water")
                {
                    total = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    total = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    total = quantity * 1.30;
                }
                else if (product == "peanuts")
                {
                    total = quantity * 1.50;
                }
                Console.WriteLine(total);
            }

            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    total = quantity * 0.45;
                }
                else if (product == "water")
                {
                    total = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    total = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    total = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    total = quantity * 1.55;
                }
                Console.WriteLine(total);
            }
        }
    }
}
