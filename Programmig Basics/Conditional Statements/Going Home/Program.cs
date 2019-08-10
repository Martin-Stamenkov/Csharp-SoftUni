using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceKm = double.Parse(Console.ReadLine());
            double petrolFor100km = double.Parse(Console.ReadLine());
            double pricePetrol = double.Parse(Console.ReadLine());
            double moneyWins = double.Parse(Console.ReadLine());

            double carPetrolCost = distanceKm * petrolFor100km / 100;
            double totalCost = carPetrolCost * pricePetrol;
            if (totalCost > moneyWins)
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {(moneyWins / 5):f2} money.");
            }
            else if (totalCost<=moneyWins)
            {
                Console.WriteLine($"You can go home. {moneyWins-totalCost:f2} money left.");
            }

        }
    }
}
