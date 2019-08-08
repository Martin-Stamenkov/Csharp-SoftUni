using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacprice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double total = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            double discount = 0.0;

            int sumtoys = puzzles + dolls + bears + minions + trucks;
            if (sumtoys >= 50)
            {
                 discount = total * 0.25;
            }
            double sumAfterDiscount = total - discount;
            double rent = sumAfterDiscount * 0.10;
            double totalAfterRent = sumAfterDiscount - rent;
            double totalsum = totalAfterRent - vacprice;
            if (totalsum >= vacprice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", totalAfterRent-vacprice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", Math.Abs(vacprice-totalAfterRent));

            }



        }

    }
}  