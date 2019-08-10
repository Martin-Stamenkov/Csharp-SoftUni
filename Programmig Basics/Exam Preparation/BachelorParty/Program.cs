using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int singerPrice = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int couvert = 0;
            int countGests = 0;

            while (command != "The restaurant is full")
            {
                int numPeople = int.Parse(command);
                countGests += numPeople;
                if (numPeople < 5)
                {
                    couvert += 100*numPeople;
                }
                else if (numPeople >= 5)
                {
                    couvert += 70*numPeople;
                }

                command = Console.ReadLine();
                
            }
            if (couvert >= singerPrice)
            {
                Console.WriteLine($"You have {countGests} guests and {couvert - singerPrice} leva left.");
            }
            else 
            {
                Console.WriteLine($"You have {countGests} guests and {couvert} leva income, but no singer.");
            }
        }
    }
}
