using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceFlowers = 0;
            double discount = 0;

            if (flowers == "Roses")
            {
                priceFlowers = numFlowers * 5;
                if (numFlowers > 80)
                {
                    discount = priceFlowers -( 5 * 0.10);
                }
            }
            else if (flowers == "Dahlias")
            {
                priceFlowers = numFlowers * 3.80;
                if (numFlowers > 90)
                {
                    discount = priceFlowers - (3.80 * 0.15);
                }

            }
            else if (flowers == "Tulips")
            {
                priceFlowers = numFlowers * 2.80;
                if (numFlowers > 80)
                {
                    discount = priceFlowers - (2.80 * 0.15);
                }
            }
            else if (flowers == "Narcissus")
                
            {
                priceFlowers = numFlowers * 3;

                if (numFlowers<120)
                {
                    discount =priceFlowers* 1.15;
                }

            }
            else if (flowers == "Gladiolus")
            {
                priceFlowers = numFlowers * 2.50;
                if (numFlowers<80)
                {
                    discount = priceFlowers* 1.20;
                }
            }
            double total = Math.Abs(budget - priceFlowers);           
            
            if (budget >= priceFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {total:f2} leva left.");
            }
            else 
            {
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", Math.Abs(budget-priceFlowers));
            }
        }
    }
}
