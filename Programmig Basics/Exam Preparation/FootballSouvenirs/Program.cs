using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamCountry = Console.ReadLine();
            string typeSouvenirs = Console.ReadLine();
            int countSouvenirs = int.Parse(Console.ReadLine());
            double priceForSouvenirs = 0;
            double totalSum = 0;

            if (teamCountry == "Argentina" && typeSouvenirs == "flags" || typeSouvenirs == "caps" || typeSouvenirs == "posters"|| typeSouvenirs == "stickers")
            {
                if (typeSouvenirs == "flags")
                {
                    totalSum += priceForSouvenirs = 3.25;
                }
                else if (typeSouvenirs == "caps")
                {
                    totalSum += priceForSouvenirs = 7.25;
                }
                else if (typeSouvenirs == "posters")
                {
                    totalSum += priceForSouvenirs = 5.10;
                }
                else if (typeSouvenirs == "stickers")
                {
                    totalSum += priceForSouvenirs = 1.25;
                }

                Console.WriteLine($"Pepi bought {countSouvenirs} {typeSouvenirs}  of {teamCountry} {totalSum * countSouvenirs:f2} lv.");
            }

            else if (teamCountry == "Brazil")
            {
                if (typeSouvenirs == "flags")
                {
                    totalSum += priceForSouvenirs = 4.20;
                }
                else if (typeSouvenirs == "caps")
                {
                    totalSum += priceForSouvenirs = 8.50;
                }
                else if (typeSouvenirs == "posters")
                {
                    totalSum += priceForSouvenirs = 5.35;
                }
                else if (typeSouvenirs == "stickers")
                {
                    totalSum += priceForSouvenirs = 1.20;
                }
                Console.WriteLine($"Pepi bought {countSouvenirs} {typeSouvenirs}  of {teamCountry} {totalSum * countSouvenirs:f2} lv.");
            }
            else if (teamCountry == "Croatia")
            {

                if (typeSouvenirs == "flags")
                {
                    totalSum += priceForSouvenirs = 2.75;
                }
                else if (typeSouvenirs == "caps")
                {
                    totalSum += priceForSouvenirs = 6.90;
                }
                else if (typeSouvenirs == "posters")
                {
                    totalSum += priceForSouvenirs = 4.95;
                }
                else if (typeSouvenirs == "stickers")
                {
                    totalSum += priceForSouvenirs = 1.10;
                }
                Console.WriteLine($"Pepi bought {countSouvenirs} {typeSouvenirs}  of {teamCountry} {totalSum * countSouvenirs:f2} lv.");
            }
            else if (teamCountry == "Denmark")
            {

                if (typeSouvenirs == "flags")
                {
                    totalSum += priceForSouvenirs = 3.10;
                }
                else if (typeSouvenirs == "caps")
                {
                    totalSum += priceForSouvenirs = 6.50;
                }
                else if (typeSouvenirs == "posters")
                {
                    totalSum += priceForSouvenirs = 4.80;
                }
                else if (typeSouvenirs == "stickers")
                {
                    totalSum += priceForSouvenirs = 0.90;
                }
                Console.WriteLine($"Pepi bought {countSouvenirs} {typeSouvenirs}  of {teamCountry} {totalSum * countSouvenirs:f2} lv.");
            }
            if (teamCountry != "Argentina" || teamCountry != "Denmark" || teamCountry != "Croatia" || teamCountry != "Brazil")
            {
                Console.WriteLine("Invalid country!");
            }
            else if (typeSouvenirs != "flags" || typeSouvenirs != "caps" || typeSouvenirs != "posters" || typeSouvenirs != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }

        }
    }
}

