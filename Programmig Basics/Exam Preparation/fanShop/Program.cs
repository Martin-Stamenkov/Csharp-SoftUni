using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int countArticuls = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 0; i < countArticuls; i++)
            {
                string nameArticuls = Console.ReadLine();
                if (nameArticuls == "hoodie")
                {
                    totalPrice += 30;
                }
                else if (nameArticuls == "keychain")
                {
                    totalPrice += 4;
                }
                else if (nameArticuls == "T-shirt")
                {
                    totalPrice += 20;
                }
                else if (nameArticuls == "flag")
                {
                    totalPrice += 15;
                }
                else if (nameArticuls == "sticker")
                {
                    totalPrice += 1;
                }
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought {countArticuls} items and left with {budget - totalPrice} lv.");
            }
            else if (budget<=totalPrice)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget-totalPrice)} more lv.");
            }
        }
    }
}
