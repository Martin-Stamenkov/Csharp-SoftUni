using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string resturants = Console.ReadLine();
            int numPorcion = int.Parse(Console.ReadLine());
            char takeAway = char.Parse(Console.ReadLine());
            double sushiPrice = 0;

            if (resturants == "Sushi Zone")
            {
                if (sushi == "sashimi")
                {
                    sushiPrice += 4.99;
                }
                else if (sushi == "maki")
                {
                    sushiPrice += 5.29;
                }
                else if (sushi == "uramaki")
                {
                    sushiPrice += 4.29;
                }
                else if (sushi == "temaki")
                {
                    sushiPrice += 4.29;
                }
            }
            else if (resturants == "Sushi Time")
            {
                if (sushi == "sashimi")
                {
                    sushiPrice += 5.49;
                }
                else if (sushi == "maki")
                {
                    sushiPrice += 4.69;
                }
                else if (sushi == "uramaki")
                {
                    sushiPrice += 4.49;
                }
                else if (sushi == "temaki")
                {
                    sushiPrice += 5.19;
                }
            }
            else if (resturants == "Sushi Bar")
            {
                if (sushi == "sashimi")
                {
                    sushiPrice += 5.29;
                }
                else if (sushi == "maki")
                {
                    sushiPrice += 5.55;
                }
                else if (sushi == "uramaki")
                {
                    sushiPrice += 6.25;
                }
                else if (sushi == "temaki")
                {
                    sushiPrice += 4.75;
                }
            }
            else if (resturants == "Asian Pub")
            {
                if (sushi == "sashimi")
                {
                    sushiPrice += 4.50;
                }
                else if (sushi == "maki")
                {
                    sushiPrice += 4.80;
                }
                else if (sushi == "uramaki")
                {
                    sushiPrice += 5.50;
                }
                else if (sushi == "temaki")
                {
                    sushiPrice += 5.50;
                }
            }
            double totalSum = sushiPrice * numPorcion;
            if (takeAway == 'Y')
            {
                
                totalSum += totalSum * 0.20;
            }

            if (resturants == "Asian Pub" || resturants == "Sushi Bar" || resturants == "Sushi Time" || resturants == "Sushi Zone")
            {
                 Console.WriteLine($"Total price: {Math.Ceiling(totalSum)} lv.");
            }
            else
            {
                 Console.WriteLine($"{resturants} is invalid restaurant!");
            }

        }
    }
}
