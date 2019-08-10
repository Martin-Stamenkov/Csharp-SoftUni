using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numSets = int.Parse(Console.ReadLine());
            double price = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    price += 56*2;
                }
                else if (size == "big")
                {
                    price += 28.70*5;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price += 36.66*2;
                }
                else if (size == "big")
                {
                    price += 19.60*5;
                }
            }
            if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price += 42.10*2;
                }
                else if (size == "big")
                {
                    price += 24.80*5;
                }
            }
            if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price += 20 * 2;
                }
                else if (size == "big")
                {
                    price += 15.20 * 5;
                }
            }
            double totalPrice = price * numSets;
            
            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (totalPrice > 1000)
            {
                totalPrice -= totalPrice * 0.50;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}